using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_KomodoClaimsDeptRepo
{
    
    public class Claims
    {
        public string ClaimID { get; set; }
        public string TypeOfClaim { get; set; }  
        public string Description { get; set; }
        public decimal ClaimAmt { get; set; }
        public DateTime DateOfIncident { get; set; }
        public DateTime DateOfClaim { get; set; }
        public bool IsValid { get; set; }
        public Claims()
        {

        }
        public Claims(string claimID, string typeOfClaim, string description, decimal claimAmt, DateTime dateOfIncident, DateTime dateOfClaim, bool isValid)
        {
            ClaimID = claimID;
            TypeOfClaim = typeOfClaim;
            Description = description;
            ClaimAmt = claimAmt;
            DateOfIncident = dateOfIncident;
            DateOfClaim = dateOfClaim;
            IsValid = isValid;
        }
    }
}
