using System.Diagnostics;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TillSystem
{
    public partial class MainWindow : Window
    {
        //****
        private List<string> listSaleScreen = new List<string>();
        private int intItemFoundLine = 0;

        public string strItemName = string.Empty;
        public string strUserNumber = string.Empty;
        public string strItemPrice = string.Empty;
        public int intUserNumber = 0;
        public int intRow1ItemAmount = 0;
        public int intRow2ItemAmount = 0;
        public int intItemPrice = 0;
        public int intRow1LineTotal = 0;
        public int intRow2LineTotal = 0;
        public int intTotalSale = 0;
        private int intSaleRowSelection;
        private string strStartSaleScreenTotalPriceLabel = "0.00";
        private string strEmpty = string.Empty;
        private int intCheckRowNeg = 0;

        public MainWindow()
        {

            InitializeComponent();
            ClearStartingStrings();
        }

        #region NUMBER PAD BUTTONS
        private void btnTillNumber0_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "0";
                intUserNumber = 0;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber1_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "1";
                intUserNumber = 1;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber2_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "2";
                intUserNumber = 2;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber3_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "3";
                intUserNumber = 3;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber4_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "4";
                intUserNumber = 4;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber5_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "5";
                intUserNumber = 5;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber6_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "6";
                intUserNumber = 6;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber7_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "7";
                intUserNumber = 7;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber8_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "8";
                intUserNumber = 8;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber9_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty)
            {
                strUserNumber = "9";
                intUserNumber = 9;
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumberClear_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text != strEmpty)
            {
                ClearInputStrings();
            }
            else
            {
                ClearRow();
            }
            //else if toggle button delete row
            //shift rows();
            //if row content null. (save row number)
            //next until not null
            //shift labels to null row
            //repeat ShiftRows() until no blank spaces until after items
        }
        private void btnTillNumberCancel_Click(object sender, RoutedEventArgs e)
        {
            CancelSale();
        }
        private void btnTillNumberMinus_Click(object sender, RoutedEventArgs e)
        {
            if (intUserNumber > 0)
            {
                intUserNumber = intUserNumber * -1;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        #endregion

        private void btnItemTest_Click(object sender, RoutedEventArgs e)
        {
            intItemPrice = 22;
            strItemName = Convert.ToString(btnItemTest.Content);
            //****
            listSaleScreen.Add(strItemName);

            if (intUserNumber == 0)
            {
                intUserNumber = 1;
            }
            if (ItemRow1btn.Content == strEmpty || ItemRow1btn.Content == strItemName)
            {
                ItemRow1btn.IsEnabled = true;
                ItemRow1btn.Content = strItemName;
                intRow1ItemAmount = intRow1ItemAmount + intUserNumber;
                strUserNumber = intRow1ItemAmount.ToString();
                ItemRow1lbl1.Text = strUserNumber;
                intRow1LineTotal = intItemPrice * intRow1ItemAmount;
                strItemPrice = intRow1LineTotal.ToString();
                ItemRow1lbl2.Text = strItemPrice;
                ClearInputStrings();
                intUserNumber = 0;
                SetSaleTotal();
            }
            else if (ItemRow2btn.Content == strEmpty || ItemRow2btn.Content == strItemName)
            {
                ItemRow2btn.IsEnabled = true;
                ItemRow2btn.Content = strItemName;

                intRow2ItemAmount = intRow2ItemAmount + intUserNumber;
                strUserNumber = intRow2ItemAmount.ToString();
                ItemRow2lbl1.Text = strUserNumber;

                intRow2LineTotal = intItemPrice * intRow2ItemAmount;
                strItemPrice = intRow2LineTotal.ToString();
                ItemRow2lbl2.Text = strItemPrice;
                ClearInputStrings();
                SetSaleTotal();

            }
        }


        private void btnItemTest2_Click(object sender, RoutedEventArgs e)
        {
            intItemPrice = 15;
            strItemName = Convert.ToString(btnItemTest2.Content);
            //****
            if (strUserNumber == strEmpty)
            {
                intUserNumber = 1;
            }
            //****
            if (!listSaleScreen.Contains(strItemName))
            {
                listSaleScreen.Add(strItemName);
                AddSaleScreenItem();
            }
            else
            {
                CheckSaleScreenItems();
            }
        }

        private void ItemRow1btn_Checked(object sender, RoutedEventArgs e)
        {
            intSaleRowSelection = 1;
            SaleRowSelected();
        }
        private void ItemRow2btn_Checked(object sender, RoutedEventArgs e)
        {
            intSaleRowSelection = 2;
            SaleRowSelected();
        }

        private void SetSaleTotal()
        {
            intTotalSale = intRow1LineTotal + intRow2LineTotal;
            Convert.ToDecimal(intTotalSale);
            SaleScreenTotalPriceLabel.Text = intTotalSale.ToString("0.00");
        }
        //****
        private void CheckSaleScreenItems()
        {
            if (ItemRow1btn.Content == strItemName)
            {
                intItemFoundLine = 1;
                AddSaleScreenItem();
            }
            if (ItemRow2btn.Content == strItemName)
            {
                intItemFoundLine = 2;
                AddSaleScreenItem();
            }
        }
        private void AddSaleScreenItem()
        {
            if (intItemFoundLine == 1)
            {
                intRow1ItemAmount = intRow1ItemAmount + intUserNumber;
                strUserNumber = intRow1ItemAmount.ToString();
                ItemRow1lbl1.Text = strUserNumber;
                intRow1LineTotal = intItemPrice * intRow1ItemAmount;
                strItemPrice = intRow1LineTotal.ToString();
                ItemRow1lbl2.Text = strItemPrice;
                ClearInputStrings();
                SetSaleTotal();
            }
            if (intItemFoundLine == 2)
            {
                intRow2ItemAmount = intRow2ItemAmount + intUserNumber;
                strUserNumber = intRow2ItemAmount.ToString();
                ItemRow2lbl1.Text = strUserNumber;
                intRow2LineTotal = intItemPrice * intRow2ItemAmount;
                strItemPrice = intRow2LineTotal.ToString();
                ItemRow2lbl2.Text = strItemPrice;
                ClearInputStrings();
                SetSaleTotal();
            }
            if (intItemFoundLine == 0)
            {
                if (ItemRow1btn.Content == strEmpty)
                {
                    ItemRow1btn.IsEnabled = true;
                    ItemRow1btn.Content = strItemName;
                    intRow1ItemAmount = intRow1ItemAmount + intUserNumber;
                    strUserNumber = intRow1ItemAmount.ToString();
                    ItemRow1lbl1.Text = strUserNumber;
                    intRow1LineTotal = intItemPrice * intRow1ItemAmount;
                    strItemPrice = intRow1LineTotal.ToString();
                    ItemRow1lbl2.Text = strItemPrice;
                    ClearInputStrings();
                    SetSaleTotal();
                }
                else if (ItemRow2btn.Content == strEmpty)
                {
                    ItemRow2btn.IsEnabled = true;
                    ItemRow2btn.Content = strItemName;
                    intRow2ItemAmount = intRow2ItemAmount + intUserNumber;
                    strUserNumber = intRow2ItemAmount.ToString();
                    ItemRow2lbl1.Text = strUserNumber;
                    intRow2LineTotal = intItemPrice * intRow2ItemAmount;
                    strItemPrice = intRow2LineTotal.ToString();
                    ItemRow2lbl2.Text = strItemPrice;
                    ClearInputStrings();
                    SetSaleTotal();
                }
            }
        }

        private void SaleRowSelected()
        {
            if (intSaleRowSelection == 1) { ItemRow2btn.IsChecked = false; }
            if (intSaleRowSelection == 2) { ItemRow1btn.IsChecked = false; }
        }

        private void ClearRow()
        {
            if (ItemRow1btn.IsChecked == true && intSaleRowSelection == 1)
            {
                ItemRow1lbl1.Text = strEmpty;
                ItemRow1lbl2.Text = strEmpty;
                ItemRow1btn.Content = strEmpty;
                intRow1LineTotal = 0;
                intRow1ItemAmount = 0;
                ItemRow1btn.IsChecked = false;
                SetSaleTotal();
            }
            if (ItemRow2btn.IsChecked == true && intSaleRowSelection == 2)
            {
                ItemRow2lbl1.Text = strEmpty;
                ItemRow2lbl2.Text = strEmpty;
                ItemRow2btn.Content = strEmpty;
                intRow2LineTotal = 0;
                intRow2ItemAmount = 0;
                ItemRow2btn.IsChecked = false;
                SetSaleTotal();
            }
        }
        private void ClearStartingStrings()
        {
            SaleScreenInputAmountLabel.Text = strEmpty;
            SaleScreenTotalPriceLabel.Text = strStartSaleScreenTotalPriceLabel;
            ItemRow1btn.Content = strEmpty;
            ItemRow1lbl1.Text = strEmpty;
            ItemRow1lbl2.Text = strEmpty;
            ItemRow2btn.Content = strEmpty;
            ItemRow2lbl1.Text = strEmpty;
            ItemRow2lbl2.Text = strEmpty;
        }
        private void ClearInputStrings()
        {
            intUserNumber = 0;
            strUserNumber = strEmpty;
            strItemName = strEmpty;
            SaleScreenInputAmountLabel.Text = strEmpty;
        }

        private void CancelSale()
        {
            strItemName = strEmpty;
            strUserNumber = strEmpty;
            strItemPrice = strEmpty;
            intUserNumber = 0;
            intRow1ItemAmount = 0;
            intRow2ItemAmount = 0;
            intItemPrice = 0;
            intRow1LineTotal = 0;
            intRow2LineTotal = 0;
            intTotalSale = 0;
            intSaleRowSelection = 0;
            ItemRow1btn.Content = strEmpty;
            ItemRow1lbl1.Text = strEmpty;
            ItemRow1lbl2.Text = strEmpty;
            ItemRow2btn.Content = strEmpty;
            ItemRow2lbl1.Text = strEmpty;
            ItemRow2lbl2.Text = strEmpty;
            SaleScreenTotalPriceLabel.Text = strStartSaleScreenTotalPriceLabel;
        }
    }
}