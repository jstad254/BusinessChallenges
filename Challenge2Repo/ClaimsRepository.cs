using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge2_KomodoClaimsDeptRepo
{
    public class ClaimsRepository
    {
        //Claims claims = new Claims();

        private Queue<Claims> _claimQueue = new Queue<Claims>();

        // Create       Add new claim
        public void AddClaims(Claims claim)
        {
            _claimQueue.Enqueue(claim);

        }
        // Read         List all claims in queue
        public Queue<Claims> GetClaims()
        {
            return _claimQueue;
        }

        // Update       no updating required
        // Delete       Delete claim from queue... dequeue?
        public void DequeueClaims(Claims claim)
        {
            _claimQueue.Dequeue(claim);
        }
    }
}
