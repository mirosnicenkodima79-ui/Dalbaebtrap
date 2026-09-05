using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalbaebTrap.UI.ViewModels.Settings;

namespace DalbaebTrap.UI.Elements.Settings.Pages
{
    /// <summary>
    /// Interaction logic for DalbaebTrapPage.xaml
    /// </summary>
    public partial class DalbaebTrapPage
    {
        public DalbaebTrapPage()
        {
            DataContext = new DalbaebTrapViewModel();
            InitializeComponent();
        }
    }
}
