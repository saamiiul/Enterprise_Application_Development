using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobPortal.Client.Services
{
    public class SearchServiceClick
    {
        private bool SearchClick;
        public event Action OnChange;
        public bool MySearchClick
        {
            get { return SearchClick; }
            set { SearchClick = value; NotifyChange();
            }
        }
        private void NotifyChange() => OnChange?.Invoke();
    }
}
