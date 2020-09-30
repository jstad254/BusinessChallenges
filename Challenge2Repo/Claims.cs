using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Repo
{
    public enum ClaimType
    {
        Car,
        Home,
        Theft
    }
    public class Claims
    {
        public int ClaimID { get; set; }
        public ClaimType TypeOfClaim { get; set; }  
        public string Description { get; set; }
        public decimal ClaimAmt { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public TimeSpan ElapsedTime { get; set; }
        public bool IsValid { get; set; }
        public Claims()
        {

        }
    }
}
