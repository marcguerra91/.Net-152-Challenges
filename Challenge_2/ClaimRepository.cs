using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    public class ClaimRepository
    {
        Queue<Claim> _queueOfClaims = new Queue<Claim>();

        public void AddContentToQueue(Claim content)
        {
            _queueOfClaims.Enqueue(content);
        }

        public Queue<Claim> GetClaimsQueue()
        {
            return _queueOfClaims;
        }
    }
}
