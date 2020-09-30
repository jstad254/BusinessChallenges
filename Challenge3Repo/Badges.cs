using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge3Repo
{
    public class Badges
    {
        public int BadgeID { get; }
        public string BadgeName { get; }

        //public List<string> doorList = new List<string>();
        public List<Badges> DoorList { get; set;}

        public Badges() { }
        public Badges(int badgeID, string badgeName, List<Badges> doorList )
        {
            BadgeID = badgeID;
            BadgeName = badgeName;
            DoorList = doorList;
        }
    }
}
