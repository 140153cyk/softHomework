using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Crawler
{
    public class SimpleCrawler
    {
        private ConcurrentDictionary<string, bool> visited = new ConcurrentDictionary<string, bool>();
        private ConcurrentQueue<string> urls = new ConcurrentQueue<string>();

        public event Action<String> addUrl;
        public event Action<String> error;

        public string startUrl { get; set; }
        public string site { get; set; }
        public string info { get; set; }

        public int fileName { get; set; } = 0;
        public SimpleCrawler()
        {           
           startUrl = "http://www.cnblogs.com/dstang2000/";                      
        }
        public void initCrawler()
        {

                if (!visited.ContainsKey(startUrl))
                {
                    visited.TryAdd(startUrl, false);
                   
                }//加入初始页面
            
            site = GetDomainName(startUrl);
        }
      

        public void Crawl(string current)
        {   
            string html= DownLoad(current);  // 下载
            addUrl(current);
            visited[current] = true;
            Parse(html, current);//解析,并加入新的链接
        }

            public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);

                lock (this)
                {
                    fileName++;
                    File.WriteAllText(fileName.ToString(), html, Encoding.UTF8);
                }             
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
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";//(?<url> [^""'#>]+)
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


                if (visited.Count<10&&visited.TryAdd(strRef,false)) {
                    urls.Enqueue(strRef);
                    urls.TryDequeue(out string arg);
                    Task.Run(() => { Crawl(arg); });
                } ;

                
                
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
            //@"^https?://(?<host>[\w.-]+)(:\d+)?($|/)(\w/)*(?<file>[^#?]*)"
            Uri uri = new Uri(url);
            return uri.Host;
           
        }  
        public static void Main(String[] args)
        {

        }
    }
    
    
}
