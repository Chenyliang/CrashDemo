using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SciChart3DCrash
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var window = new SciChart3DWindow();
                window.Show();
                await Task.Delay(2000);
                window.Close();
            }
        }

        private async void Button_Click1(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                var window = new SciChart2DWindow();
                window.Show();
                await Task.Delay(2000);
                window.Close();
            }
        }
    }
}