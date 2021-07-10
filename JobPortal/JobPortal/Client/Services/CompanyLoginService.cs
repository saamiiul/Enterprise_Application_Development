using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class CompanyLoginService
    {
        private bool CompanyLogin;
        public event Action OnChange;
        public bool MyCompanyLogin
        {
            get { return CompanyLogin; }
            set
            {
                CompanyLogin = value; NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
