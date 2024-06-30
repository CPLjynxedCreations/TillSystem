using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TillSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string number = null;
        public MainWindow()
        {

            InitializeComponent();
            /* FOR I = MAKE IT 19. IF EMPTY BUTTON DISABLED ELSE CLICKABLE
            if (item.Content == string.Empty)
            {
                item.IsEnabled = false;
            }
            else
            {
                item.IsEnabled = true;
            }*/
        }

        private void btnTillNumber1_Click(object sender, RoutedEventArgs e)
        {
            // for i crap
            if (SaleScreenInputAmountLabel.Text == string.Empty)
            {
                number = "1";
                SaleScreenInputAmountLabel.Text = number;
            }
            /*
            else if (ItemRow2lbl1.Text == string.Empty)
            {
                number = "1";
                ItemRow2lbl1.Text = number;
            }*/
        }
    }
}