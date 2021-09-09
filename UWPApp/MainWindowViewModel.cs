using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPApp
{
    public class MainWindowViewModel
    {
        public ObservableCollection<IIdentity> Identities { get; set; }

        public MainWindowViewModel()
        {
            Identities = new ObservableCollection<IIdentity>() { new HomeIdentity(), new OfficeIdentity() };
        }
    }
}
