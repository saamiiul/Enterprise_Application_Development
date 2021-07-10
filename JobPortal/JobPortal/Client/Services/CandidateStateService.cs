using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class CandidateStateService
    {
        Candidate can = new Candidate();
        
        private Candidate myCandidate;
        public event Action OnChange;
        public Candidate MyCandidateState
        {
            get { return myCandidate; }
            set { myCandidate = value;
                NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
