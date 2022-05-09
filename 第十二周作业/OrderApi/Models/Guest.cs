using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Models
{
   public class Guest
    {
        public int GuestID { get; set; }
        public string Name { get; set; }

        public Guest(int GuestID, string name)
        {
            this.GuestID = GuestID;
            Name = name;
        }
        public Guest() { }

        public override string ToString()
        {
            return $"GuestID:{GuestID} Name:{Name}";
        }

        public override bool Equals(object obj)
        {
            return obj is Guest guest &&obj!=null&&
                   GuestID == guest.GuestID &&
                   Name == guest.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GuestID, Name);
        }
    }
}
