using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Crawler
{
    public class SimpleCrawler
    {
        private Hashtable visited = new Hashtable();
        public Action<String> addUrl;
        public Action<String> error;
        private int count = 0;
        public string startUrl { get; set; }
        public string site { get; set; }
        public string info { get; set; }
        public SimpleCrawler()
        {           
           startUrl = "http://www.cnblogs.com/dstang2000/";                      
        }
        public static void Main(String[] args)
        {

        }
        public void Crawl()
        {
            if(visited[startUrl]==null)visited.Add(startUrl, false);//加入初始页面
            site = GetDomainName(startUrl);

            while (true)
            {
                string current = null;
                foreach (string url in visited.Keys)
                {
                    if ((bool)visited[url]) continue;
                    current = url;
                }

                if (current == null || count > 10) break;

                string html = DownLoad(current); // 下载
                
                addUrl(current);
                visited[current] = true;
                count++;
                Parse(html, current);//解析,并加入新的链接

            }
        }


        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                error(ex.Message);
                return "";
            }
        }

        private void Parse(string html, string currentUrl)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', '>');

                if (!Regex.IsMatch(strRef, @"(http|HTTP)"))
                {
                    Uri origin = new Uri(currentUrl);
                    Uri absolute = new Uri(origin, strRef);
                    strRef = absolute.ToString();
                }//相对地址转绝对地址

                if (!isAPage(strRef)) continue;
                //判断爬取的是网页

                if (!strRef.Contains(site)) continue;
                //判断只爬取指定网站

                if (strRef.Length == 0) continue;
                if (visited[strRef] == null) visited[strRef] = false;
            }
        }
        private bool isAPage(string url)
        {
            if (url.IndexOf('?') > 0) url = url.Substring(0, url.IndexOf('?'));
            if (Regex.IsMatch(url, @"\.(html|hml|aspx|jsp)")) return true;
            if (Regex.IsMatch(url, @"/[^.]+$")) return true;
            if (url.EndsWith("/")) return true;
            return false;
        }
        public static string GetDomainName(string url)
        {
            string result = url;
            if (result.IndexOf("http://") > -1)
            {
                result= result.Replace("http://", string.Empty);
            }
            else if (result.IndexOf("https://")> -1)
            {
                result = result.Replace("https://", string.Empty);
            }
            result=result.Replace("/", string.Empty);
            if (result.IndexOf('/') > 0) return result.Substring(0, result.IndexOf('/'));
            else return result;
        }
    }
    
    
}
