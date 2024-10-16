using SciChart.Charting.Visuals;
using System.Configuration;
using System.Data;
using System.Windows;

namespace SciChart3DCrash
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            SciChartSurface.SetRuntimeLicenseKey("your code"); 


        }
    }

}
