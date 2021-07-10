using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class CompanyStateService
    {
        private Company MyCompany;
        public event Action OnChange;
        public Company MyCompanyState
        {
            get { return MyCompany; }
            set { MyCompany = value;
                NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();

    }
}
