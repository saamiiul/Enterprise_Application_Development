using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class CandidateLoginService
    {
        private bool CandidateLogin;
        public event Action OnChange;
        public bool MyCandidateLogin
        {
            get { return CandidateLogin; }
            set { CandidateLogin = value;
                NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
