using System;
using System.Collections.Generic;
using System.Text;

namespace OrderPro
{
   public class Guest
    {
        public static List<Guest> guests { get; } = new List<Guest>();

        public int AccountNum { get; set; }
        public string Name { get; set; }

        public Guest(int accountNum, string name)
        {
            AccountNum = accountNum;
            Name = name;
            Guest.guests.Add(this);
        }
        public Guest() 
        {
            Guest.guests.Add(this);
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Guest guest &&obj!=null&&
                   AccountNum == guest.AccountNum &&
                   Name == guest.Name;
        }

        public override int GetHashCode()
        {
            int hashCode = 1406675682;
            hashCode = hashCode * -1521134295 + AccountNum.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }
    }
}
