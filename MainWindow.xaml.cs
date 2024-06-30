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
    public partial class MainWindow : Window
    {
        //needs int for the user number too
        public string strUserNumber = string.Empty;
        public string strItemName = string.Empty;
        //needs int for the price too
        //public int intItemPrice = null;
        public string strItemPrice = string.Empty;

        public MainWindow()
        {

            InitializeComponent();
            SaleScreenInputAmountLabel.Text = string.Empty;
            SaleScreenTotalPriceLabel.Text = string.Empty;
            ItemRow1btn.Content = string.Empty;
            ItemRow1lbl1.Text = string.Empty;
            ItemRow1lbl2.Text = string.Empty;
            ItemRow2btn.Content = string.Empty;
            ItemRow2lbl1.Text = string.Empty;
            ItemRow2lbl2.Text = string.Empty;
            
            // FOR I = MAKE IT 19. IF EMPTY BUTTON DISABLED ELSE CLICKABLE
            if (ItemRow1btn.Content == string.Empty)
            {
                ItemRow1btn.IsEnabled = false;
            }
            if (ItemRow2btn.Content == string.Empty)
            {
                ItemRow2btn.IsEnabled = false;
            }
        }

        private void btnTillNumber1_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == string.Empty)
            {
                strUserNumber = "1";
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }

        private void btnItemTest_Click(object sender, RoutedEventArgs e)
        {
            if (strUserNumber == string.Empty)
            {
                strUserNumber = "1";
            }
            strItemName = Convert.ToString(btnItemTest.Content);
            ItemRow1btn.IsEnabled = true;
            ItemRow1btn.Content = strItemName;
            strItemPrice = "35";
            ItemRow1lbl2.Text = strItemPrice;
            ItemRow1lbl1.Text = strUserNumber;
            strUserNumber = string.Empty;
        }

        private void btnTillNumberClear_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text != string.Empty)
            {
                strUserNumber = string.Empty;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
    }
}