using System;
using System.Collections.Generic;
using System.Text;

namespace Work1
{
    class Guest
    {
        public int AccountNum { get; set; }
        public string Name { get; set; }

        public Guest(int accountNum, string name)
        {
            AccountNum = accountNum;
            Name = name;
        }

        public override string ToString()
        {
            return $"AccountNum:{AccountNum} Name:{Name}";
        }

        public override bool Equals(object obj)
        {
            return obj is Guest guest &&
                   AccountNum == guest.AccountNum &&
                   Name == guest.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(AccountNum, Name);
        }
    }
}
