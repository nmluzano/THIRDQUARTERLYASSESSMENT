using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NicoleLuzano.ThirdQuarterlyAssessment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> municipalities = new List<string>()
            {
                "Dinalupihan",
                "Davao City",
                "Angeles City",
                "Brooke's Point",
                "Olongapo City"
            };
            cboMunicipalities.ItemsSource = municipalities;

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cboMunicipalities.SelectedIndex == 0)
            {
                myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(14.8781,120.4546);
                myMap.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 1)
            {
                myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(7.130099278801634, 125.42804470063739);
                myMap.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 2)
            {
                myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(15.160460231120194, 120.60047399746576);
                myMap.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 3)
            {
                myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(8.827339952813013, 117.83041789939554);
                myMap.ZoomLevel = 13;
            }
            if (cboMunicipalities.SelectedIndex == 4)
            {
                myMap.Center = new Microsoft.Maps.MapControl.WPF.Location(14.834821290849918, 120.2820978394843);
                myMap.ZoomLevel = 13;
            }

        }
    }
}
