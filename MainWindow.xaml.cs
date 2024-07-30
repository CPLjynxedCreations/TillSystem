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
        public string strItemName = string.Empty;
        public string strUserNumber = string.Empty;
        public string strItemPrice = string.Empty;
        public int intUserNumber = 0;
        private bool boolIsMinus;
        public int intRow1ItemAmount = 0;
        public int intRow2ItemAmount = 0;
        public int intRow3ItemAmount = 0;
        public int intItemPrice = 0;
        public int intRow1LineTotal = 0;
        public int intRow2LineTotal = 0;
        public int intRow3LineTotal = 0;
        public int intTotalSale = 0;
        private int intSaleRowSelection;
        private string strStartSaleScreenTotalPriceLabel = "0.00";
        private string strEmpty = string.Empty;
        private int intCheckRowNeg = 0;

        private bool boolMoveRow2;
        private bool boolMoveRow3;

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
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 1;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber2_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 2;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber3_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 3;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber4_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 4;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber5_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 5;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber6_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 6;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber7_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 7;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber8_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 8;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
                SaleScreenInputAmountLabel.Text = strUserNumber;
            }
        }
        private void btnTillNumber9_Click(object sender, RoutedEventArgs e)
        {
            if (SaleScreenInputAmountLabel.Text == strEmpty || SaleScreenInputAmountLabel.Text == "-")
            {
                intUserNumber = 9;
                if (boolIsMinus)
                {
                    intUserNumber = intUserNumber * -1;
                }
                boolIsMinus = false;
                strUserNumber = Convert.ToString(intUserNumber);
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
            else
            {
                boolIsMinus = true;
                SaleScreenInputAmountLabel.Text = "-";
            }
        }
        #endregion

        #region TILL BUTTONS
        private void btnItemTest_Click(object sender, RoutedEventArgs e)
        {
            intItemPrice = 22;
            strItemName = Convert.ToString(btnItemTest.Content);
            if (strUserNumber == strEmpty)
            {
                intUserNumber = 1;
            }
            CheckRowStrings();
        }
        private void btnItemTest2_Click(object sender, RoutedEventArgs e)
        {
            intItemPrice = 15;
            strItemName = Convert.ToString(btnItemTest2.Content);
            if (strUserNumber == strEmpty)
            {
                intUserNumber = 1;
            }
            CheckRowStrings();
        }
        private void btnItemTest3_Click(object sender, RoutedEventArgs e)
        {
            intItemPrice = 30;
            strItemName = Convert.ToString(btnItemTest3.Content);
            if (strUserNumber == strEmpty)
            {
                intUserNumber = 1;
            }
            CheckRowStrings();
        }
        #endregion

        #region ADD TO SALE SCREEN
        private void AddSaleScreenRow1()
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
        private void AddSaleScreenRow2()
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
        private void AddSaleScreenRow3()
        {
            ItemRow3btn.IsEnabled = true;
            ItemRow3btn.Content = strItemName;
            intRow3ItemAmount = intRow3ItemAmount + intUserNumber;
            strUserNumber = intRow3ItemAmount.ToString();
            ItemRow3lbl1.Text = strUserNumber;
            intRow3LineTotal = intItemPrice * intRow3ItemAmount;
            strItemPrice = intRow3LineTotal.ToString();
            ItemRow3lbl2.Text = strItemPrice;
            ClearInputStrings();
            SetSaleTotal();
        }
        #endregion

        #region ROW SELECTION
        private void CheckRowStrings()
        {
            if (ItemRow1btn.Content == strItemName)
            {
                AddSaleScreenRow1();
            }
            else if (ItemRow2btn.Content == strItemName)
            {
                AddSaleScreenRow2();

            }
            else if (ItemRow3btn.Content == strItemName)
            {
                AddSaleScreenRow3();

            }
            else if (ItemRow1btn.Content == strEmpty)
            {
                AddSaleScreenRow1();
            }
            else if (ItemRow2btn.Content == strEmpty)
            {
                AddSaleScreenRow2();
            }
            else if (ItemRow3btn.Content == strEmpty)
            {
                AddSaleScreenRow3();
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
        private void ItemRow3btn_Checked(object sender, RoutedEventArgs e)
        {
            intSaleRowSelection = 3;
            SaleRowSelected();
        }

        private void SetSaleTotal()
        {
            intTotalSale = intRow1LineTotal + intRow2LineTotal + intRow3LineTotal;
            Convert.ToDecimal(intTotalSale);
            SaleScreenTotalPriceLabel.Text = intTotalSale.ToString("0.00");
        }

        private void SaleRowSelected()
        {
            if (intSaleRowSelection == 1) { ItemRow2btn.IsChecked = false; ItemRow3btn.IsChecked = false; }
            if (intSaleRowSelection == 2) { ItemRow1btn.IsChecked = false; ItemRow3btn.IsChecked = false; }
            if (intSaleRowSelection == 3) { ItemRow1btn.IsChecked = false; ItemRow2btn.IsChecked = false; }
        }
        #endregion

        #region CLEAR AND MOVE ROWS
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
                ItemRow1btn.IsEnabled = false;
                SetSaleTotal();
                MoveItems();
            }
            if (ItemRow2btn.IsChecked == true && intSaleRowSelection == 2 || boolMoveRow2)
            {
                ItemRow2lbl1.Text = strEmpty;
                ItemRow2lbl2.Text = strEmpty;
                ItemRow2btn.Content = strEmpty;
                intRow2LineTotal = 0;
                intRow2ItemAmount = 0;
                ItemRow2btn.IsChecked = false;
                ItemRow2btn.IsEnabled = false;
                SetSaleTotal();
                boolMoveRow2 = false;
                MoveItems();
            }
            if (ItemRow3btn.IsChecked == true && intSaleRowSelection == 3 || boolMoveRow3)
            {
                ItemRow3lbl1.Text = strEmpty;
                ItemRow3lbl2.Text = strEmpty;
                ItemRow3btn.Content = strEmpty;
                intRow3LineTotal = 0;
                intRow3ItemAmount = 0;
                ItemRow3btn.IsChecked = false;
                ItemRow3btn.IsEnabled = false;
                SetSaleTotal();
                boolMoveRow3 = false;
                MoveItems();
            }
        }

        private void MoveItems()
        {
            if (ItemRow1btn.Content == strEmpty && ItemRow2btn.Content != strEmpty)
            {
                ItemRow1btn.Content = ItemRow2btn.Content;
                intRow1ItemAmount = intRow2ItemAmount;
                ItemRow1lbl1.Text = ItemRow2lbl1.Text;
                intRow1LineTotal = intRow2LineTotal;
                ItemRow1lbl2.Text = ItemRow2lbl2.Text;
                boolMoveRow2 = true;
                ItemRow1btn.IsEnabled = true;
                SetSaleTotal();
            }
            else if (ItemRow1btn.Content == strEmpty && ItemRow2btn.Content == strEmpty)
            {
                return;
            }
            if (ItemRow2btn.Content == strEmpty && ItemRow3btn.Content != strEmpty)
            {
                ItemRow2btn.Content = ItemRow3btn.Content;
                intRow2ItemAmount = intRow3ItemAmount;
                ItemRow2lbl1.Text = ItemRow3lbl1.Text;
                intRow2LineTotal = intRow3LineTotal;
                ItemRow2lbl2.Text = ItemRow3lbl2.Text;
                boolMoveRow3 = true;
                ItemRow2btn.IsEnabled = true;
                SetSaleTotal();
            }
            else if (ItemRow2btn.Content == strEmpty && ItemRow3btn.Content == strEmpty)
            {
                return;
            }
        }

        private void CancelSale()
        {
            strItemName = strEmpty;
            strUserNumber = strEmpty;
            strItemPrice = strEmpty;
            intUserNumber = 0;
            intRow1ItemAmount = 0;
            intRow2ItemAmount = 0;
            intRow3ItemAmount = 0;
            intItemPrice = 0;
            intRow1LineTotal = 0;
            intRow2LineTotal = 0;
            intRow3LineTotal = 0;
            intTotalSale = 0;
            intSaleRowSelection = 0;
            ItemRow1btn.Content = strEmpty;
            ItemRow1lbl1.Text = strEmpty;
            ItemRow1lbl2.Text = strEmpty;
            ItemRow2btn.Content = strEmpty;
            ItemRow2lbl1.Text = strEmpty;
            ItemRow2lbl2.Text = strEmpty;
            ItemRow3btn.Content = strEmpty;
            ItemRow3lbl1.Text = strEmpty;
            ItemRow3lbl2.Text = strEmpty;
            SaleScreenTotalPriceLabel.Text = strStartSaleScreenTotalPriceLabel;
            ItemRow1btn.IsEnabled = false;
            ItemRow2btn.IsEnabled = false;
            ItemRow3btn.IsEnabled = false;
        }
        #endregion

        #region CLEAR STARTING RUN
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
            ItemRow3btn.Content = strEmpty;
            ItemRow3lbl1.Text = strEmpty;
            ItemRow3lbl2.Text = strEmpty;
        }

        private void ClearInputStrings()
        {
            intUserNumber = 0;
            strUserNumber = strEmpty;
            strItemName = strEmpty;
            SaleScreenInputAmountLabel.Text = strEmpty;
        }
        #endregion

    }
}