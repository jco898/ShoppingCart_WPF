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

namespace Assignment5
{
    /*
     * Name: Joshua Ostromogilski
     * ID: 0972010
     * Assignment # 5
     */

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ShoppingCart cart = new ShoppingCart();

        public MainWindow()
        {
            InitializeComponent();
        }

        /*
         * btnAddApple_Click()
         * 
         * Input:   object sender
         *          RoutedEventArgs e
         *          
         * Description: Click method used for adding an apple to the cart.
         *              The apple quantity and total cost is also updated.
         */
        private void btnAddApple_Click(object sender, RoutedEventArgs e)
        {
            cart.SetApples(1);
            qntApple.Text = cart.GetApples().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveApple_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing an apple.
         *              Apple quantity and total cost is also updated.
         */
        private void btnRemoveApple_Click(object sender, RoutedEventArgs e)
        {
            cart.SetApples(-1);
            qntApple.Text = cart.GetApples().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddBanana_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding bananas.
         *              Banana quantity and total cost will be updated.
         */
        private void btnAddBanana_Click(object sender, RoutedEventArgs e)
        {
            cart.SetBananas(1);
            qntBanana.Text = cart.GetBananas().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveBanana_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing a banana.
         *              Banana quantity and total cost is also updated.
         */
        private void btnRemoveBanana_Click(object sender, RoutedEventArgs e)
        {
            cart.SetBananas(-1);
            qntBanana.Text = cart.GetBananas().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddOrange_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding an orange.
         *              Orange quantity and total cost is updated in the form.
         */
        private void btnAddOrange_Click(object sender, RoutedEventArgs e)
        {
            cart.SetOranges(1);
            qntOrange.Text = cart.GetOranges().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveOrange_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method for removing oranges.
         *              Orange quantity and total cost will be updated.
         */
        private void btnRemoveOrange_Click(object sender, RoutedEventArgs e)
        {
            cart.SetOranges(-1);
            qntOrange.Text = cart.GetOranges().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddCarrot_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding carrots.
         *              Carrot quantity and total cost will be updated.
         */
        private void btnAddCarrot_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCarrots(1);
            qntCarrot.Text = cart.GetCarrots().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveCarrot_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing a carrot.
         *              Carrot quantity and total cost is also updated.
         */
        private void btnRemoveCarrot_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCarrots(-1);
            qntCarrot.Text = cart.GetCarrots().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddPotato_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding a potato.
         *              Quantity and total cost is also updated on the form.
         */
        private void btnAddPotato_Click(object sender, RoutedEventArgs e)
        {
            cart.SetPotatoes(1);
            qntPotato.Text = cart.GetPotatoes().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemovePotato_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing a potato.
         *              Potato quantity and total cost is updated.
         */
        private void btnRemovePotato_Click(object sender, RoutedEventArgs e)
        {
            cart.SetPotatoes(-1);
            qntPotato.Text = cart.GetPotatoes().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddSpinach_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding spinach.
         *              Spinach quantity and total cost will be updated on the form.
         */
        private void btnAddSpinach_Click(object sender, RoutedEventArgs e)
        {
            cart.SetSpinach(1);
            qntSpinach.Text = cart.GetSpinach().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveSpinach_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing spinach.
         *              The quantity and total cost will also be updated.
         */
        private void btnRemoveSpinach_Click(object sender, RoutedEventArgs e)
        {
            cart.SetSpinach(-1);
            qntSpinach.Text = cart.GetSpinach().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddBeef_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding beef to the cart.
         *              Beef quantity and total cost is updated.
         */
        private void btnAddBeef_Click(object sender, RoutedEventArgs e)
        {
            cart.SetBeef(1);
            qntBeef.Text = cart.GetBeef().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveBeef_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method for removing beef from the cart.
         *              Quantity and total cost is also updated.
         */
        private void btnRemoveBeef_Click(object sender, RoutedEventArgs e)
        {
            cart.SetBeef(-1);
            qntBeef.Text = cart.GetBeef().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddChicken_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method for adding chicken.
         *              Chicken quantity and total cost is also updated.
         */
        private void btnAddChicken_Click(object sender, RoutedEventArgs e)
        {
            cart.SetChicken(1);
            qntChicken.Text = cart.GetChicken().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveChicken_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing chicken from the cart.
         *              Quantity and total cost is updated.
         */
        private void btnRemoveChicken_Click(object sender, RoutedEventArgs e)
        {
            cart.SetChicken(-1);
            qntChicken.Text = cart.GetChicken().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddFish_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method for adding fish.
         *              Fish quantity and total cost is also updated.
         */
        private void btnAddFish_Click(object sender, RoutedEventArgs e)
        {
            cart.SetFish(1);
            qntFish.Text = cart.GetFish().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveFish_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method for removing fish from the cart.
         *              Quantity and total cost will be updated.
         */
        private void btnRemoveFish_Click(object sender, RoutedEventArgs e)
        {
            cart.SetFish(-1);
            qntFish.Text = cart.GetFish().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddMilk_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding milk to the cart.
         *              Milk quantity and total cost is updated.
         */
        private void btnAddMilk_Click(object sender, RoutedEventArgs e)
        {
            cart.SetMilk(1);
            qntMilk.Text = cart.GetMilk().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveMilk_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing milk from the cart.
         *              The quantity and total cost will also be updated.
         */
        private void btnRemoveMilk_Click(object sender, RoutedEventArgs e)
        {
            cart.SetMilk(-1);
            qntMilk.Text = cart.GetMilk().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddCheese_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding cheese.
         *              Cheese quantity and total cost is updated on the form.
         */
        private void btnAddCheese_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCheese(1);
            qntCheese.Text = cart.GetCheese().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveCheese_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing cheese from the cart.
         *              Quantity and total cost is also updated on the form.
         */
        private void btnRemoveCheese_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCheese(-1);
            qntCheese.Text = cart.GetCheese().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnAddCream_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for adding cream.
         *              Cream quantity and total cost is updated.
         */
        private void btnAddCream_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCream(1);
            qntCream.Text = cart.GetCream().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnRemoveCream_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for removing cream from the cart.
         *              The quantity and total cost will also be updated.
         */
        private void btnRemoveCream_Click(object sender, RoutedEventArgs e)
        {
            cart.SetCream(-1);
            qntCream.Text = cart.GetCream().ToString();
            cartTotal.Text = cart.GetTotal().ToString("C2");
        }

        /*
         * btnCheckout_Click()
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for checking out on the form.
         *              Uses validation to check if form is incomplete.
         *              If all is well, a receipt will be generated 
         *              according to the payment type selected.
         */
        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {
            if (cart.IsEmpty())
            {
                MessageBox.Show("Shopping cart is empty!", "John Abbott College Grocery Store Receipt");
            }
            else if (!(btnCredit.IsChecked.Value || btnCash.IsChecked.Value))
            {
                MessageBox.Show("Please select a payment type.", "Payment Type", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (btnCredit.IsChecked.Value && cart.GetTotal() < 5)
            {
                MessageBox.Show("Total cost must be >= $5.00 to use credit or debit.", "Credit/Debit", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (btnCash.IsChecked.Value && txtCash.Text == string.Empty)
            {
                MessageBox.Show("Please enter an amount for cash");
            }
            else if (btnCash.IsChecked.Value && (Double.Parse(txtCash.Text) < cart.GetTotal()))
            {
                MessageBox.Show("Not enough cash provided.", "Cash Input", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (btnCredit.IsChecked.Value)
            {
                MessageBox.Show(cart.Checkout(1, 0), "John Abbott College Grocery Store Receipt");
            }
            else if (btnCash.IsChecked.Value)
            {
                MessageBox.Show(cart.Checkout(2, Double.Parse(txtCash.Text)), "John Abbott College Grocery Store Receipt");
            }
        }

        /*
         * btnReset_Click
         * 
         * Input:   object sender
         *          RouterEventArgs e
         *          
         * Description: Click method used for resetting the form.
         *              The form quantities and buttons will be reset.
         *              The ShoppingCart class is updated, as well.
         */
        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            cart.ResetCart();

            qntApple.Text = "0";
            qntBanana.Text = "0";
            qntOrange.Text = "0";
            qntCarrot.Text = "0";
            qntPotato.Text = "0";
            qntSpinach.Text = "0";
            qntBeef.Text = "0";
            qntChicken.Text = "0";
            qntFish.Text = "0";
            qntMilk.Text = "0";
            qntCheese.Text = "0";
            qntCream.Text = "0";

            btnCredit.IsChecked = btnCash.IsChecked = false;

            cartTotal.Text = cart.GetTotal().ToString("C2");
        }
    }
}
