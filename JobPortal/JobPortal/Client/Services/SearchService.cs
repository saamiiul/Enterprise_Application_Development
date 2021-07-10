using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class SearchService
    {
        private SearchJob MyJob;
        public event Action OnChange;
        public SearchJob MySearchJob
        {
            get { return MyJob; }
            set { MyJob = value; NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
