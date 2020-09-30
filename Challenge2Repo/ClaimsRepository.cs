using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2Repo
{
    class ClaimsRepository
    {
        Claims claims = new Claims();

        private List<Claims> _listOfClaims = new List<Claims>();

        // Create       Add new claim
        public void AddClaims(Claims claim)
        {
            _listOfClaims.Add(claim);
        }
        // Read         List all claims in queue
        public List<Claims> GetClaims()
        {
            return _listOfClaims;
        }

        // Update       no updating required

        // Delete       Delete claim from queue... dequeue?
        public void DeleteClaims(Claims claim)
        {
            _listOfClaims.Remove(claim);
        }
    }
}
