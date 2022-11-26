using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Assignment5
{
    /*
     * Name: Joshua Ostromogilski
     * ID: 0972010
     * Assignment # 5
     */

    /*
     * ShoppingCart Class
     * 
     * This class is used for creating a shopping cart.
     * It is used by the WPF app to add and remove grocery items.
     * It also features methods and properties to finalize a grocery list and details during checkout.
     */
    class ShoppingCart
    {
        private const double COST_APPLE = 0.50;
        private const double COST_BANANA = 0.75;
        private const double COST_ORANGE = 1.00;
        private const double COST_CARROT = 0.70;
        private const double COST_POTATO = 1.25;
        private const double COST_SPINACH = 0.95;
        private const double COST_BEEF = 2.75;
        private const double COST_CHICKEN = 4.00;
        private const double COST_FISH = 3.50;
        private const double COST_MILK = 1.75;
        private const double COST_CHEESE = 5.40;
        private const double COST_CREAM = 2.50;

        private int apples = 0;
        private int bananas = 0;
        private int oranges = 0;
        private int carrots = 0;
        private int potatoes = 0;
        private int spinach = 0;
        private int beef = 0;
        private int chicken = 0;
        private int fish = 0;
        private int milk = 0;
        private int cheese = 0;
        private int cream = 0;

        private double totalCost = 0;

        private const double TWENTY_AMOUNT = 20;
        private const double TEN_AMOUNT = 10;
        private const double FIVE_AMOUNT = 5;
        private const double TOONIE_AMOUNT = 2;
        private const double LOONIE_AMOUNT = 1;
        private const double QUARTER_AMOUNT = 0.25;
        private const double DIME_AMOUNT = 0.10;
        private const double NICKEL_AMOUNT = 0.05;

        /*
         * SetApples()
         * 
         * Input:   int q
         * 
         * Description: Setter for the apples field.
         *              Adds a given amount of apples, after validation.
         *              Total cost is updated to include new added apples.
         */
        public void SetApples(int q)
        {
            if ((apples + q) < 0)
            {
                apples = 0;
            }
            else
            {
                apples += q;
                totalCost += COST_APPLE * q;
            }
        }

        /*
         * GetApples()
         * 
         * Description: Getter for the apples field.
         *              Returns the current amount of apples.
         */
        public int GetApples()
        {
            return apples;
        }

        /*
         * SetBananas()
         * 
         * Input:   int q
         * 
         * Description: Setter for the bananas field.
         *              Adds the given amount of bananas to the field.
         *              Total cost will be updated for the new banana count.
         */
        public void SetBananas(int q)
        {
            if ((bananas + q) < 0)
            {
                bananas = 0;
            }
            else
            {
                bananas += q;
                totalCost += COST_BANANA * q;
            }
        }

        /*
         * GetBananas()
         * 
         * Description: Getter for the bananas.
         *              Returns the current amount of bananas.
         */
        public int GetBananas()
        {
            return bananas;
        }

        /*
         * SetOranges()
         * 
         * Input:   int q
         * 
         * Description: Setter for oranges.
         *              After validation, adds the q amount of oranges to the field.
         *              Total cost is updated to reflect new amount of oranges.
         */
        public void SetOranges(int q)
        {
            if ((oranges + q) < 0)
            {
                oranges = 0;
            }
            else
            {
                oranges += q;
                totalCost += COST_ORANGE * q;
            }
        }

        /*
         * GetOranges()
         * 
         * Description: Getter for the oranges.
         *              Returns the current amount of oranges.
         */
        public int GetOranges()
        {
            return oranges;
        }

        /*
         * SetCarrots()
         * 
         * Input:   int q
         * 
         * Description: Setter for the carrots field.
         *              Adds the given input q to the field.
         *              Total cost is updated to reflect new amount of carrots.
         */
        public void SetCarrots(int q)
        {
            if ((carrots + q) < 0)
            {
                carrots = 0;
            }
            else
            {
                carrots += q;
                totalCost += COST_CARROT * q;
            }
        }

        /*
         * GetCarrots()
         * 
         * Input:   int q
         * 
         * Description: Getter for the carrots field.
         *              Returns the current amount of carrots.
         */
        public int GetCarrots()
        {
            return carrots;
        }

        /*
         * SetPotatoes()
         * 
         * Input:   int q
         * 
         * Description: Setter for the potato field.
         *              After validation, adds the q number of potatoes to the field.
         *              Total cost is updated to reflect new amount.
         */
        public void SetPotatoes(int q)
        {
            if ((potatoes + q) < 0)
            {
                potatoes = 0;
            }
            else
            {
                potatoes += q;
                totalCost += COST_POTATO * q;
            }
        }

        /*
         * GetPotatoes()
         * 
         * Description: Getter for the potatoes
         *              Returns the current value of the potato field.
         */
        public int GetPotatoes()
        {
            return potatoes;
        }

        /*
         * SetSpinach()
         * 
         * Input:   int q
         * 
         * Description: Setter for the spinach.
         *              Adds a q amount of spinach to the field.
         *              Total cost is updated to reflect new amount.
         */
        public void SetSpinach(int q)
        {
            if ((spinach + q) < 0)
            {
                spinach = 0;
            }
            else
            {
                spinach += q;
                totalCost += COST_SPINACH * q;
            }
        }

        /*
         * GetSpinach()
         * 
         * Description: Getter for the spinach field.
         *              Returns the current amount of spinach.
         */
        public int GetSpinach()
        {
            return spinach;
        }

        /*
         * SetBeef()
         * 
         * Input:   int q
         * 
         * Description: Setter for the beef.
         *              Adds the given amount to the field, after validation.
         *              Total cost is updated to reflect new amount.
         */
        public void SetBeef(int q)
        {
            if ((beef + q) < 0)
            {
                beef = 0;
            }
            else
            {
                beef += q;
                totalCost += COST_BEEF * q;
            }
        }

        /*
         * GetBeef()
         * 
         * Description: Getter for the beef field.
         *              Returns the current amount of beef.
         */
        public int GetBeef()
        {
            return beef;
        }

        /*
         * SetChicken()
         * 
         * Input:   int q
         * 
         * Description: Setter for the chicken field.
         *              After validation, adds q amount of chicken to the field.
         *              The total cost is updated to reflect new amount.
         */
        public void SetChicken(int q)
        {
            if ((chicken + q) < 0)
            {
                chicken = 0;
            }
            else
            {
                chicken += q;
                totalCost += COST_CHICKEN * q;
            }
        }

        /*
         * GetChicken()
         * 
         * Description: Getter for chicken.
         *              Returns the current amount in the chicken field.
         */
        public int GetChicken()
        {
            return chicken;
        }

        /*
         * SetFish()
         * 
         * Input:   int q
         * 
         * Description: Setter for the fish.
         *              After validation, adds q amount of fish to the field.
         *              Total cost will be updated to account for fish.
         */
        public void SetFish(int q)
        {
            if ((fish + q) < 0)
            {
                fish = 0;
            }
            else
            {
                fish += q;
                totalCost += COST_FISH * q;
            }
        }

        /*
         * GetFish()
         * 
         * Description: Getter for the fish.
         *              Returns the current amount in the fish field.
         */
        public int GetFish()
        {
            return fish;
        }

        /*
         * SetMilk()
         * 
         * Input:   int q
         * 
         * Description: Setter for the milk field.
         *              Adds a q amount of milk to the field.
         *              Total cost is updated to reflect new amount of milk.
         */
        public void SetMilk(int q)
        {
            if ((milk + q) < 0)
            {
                milk = 0;
            }
            else
            {
                milk += q;
                totalCost += COST_MILK * q;
            }
        }

        /*
         * GetMilk()
         * 
         * Description: Getter for the milk.
         *              Returns the current amount in the milk field.
         */
        public int GetMilk()
        {
            return milk;
        }

        /*
         * SetCheese()
         * 
         * Input:   int q
         * 
         * Description: Setter for the cheese.
         *              After validation, adds a q amount of cheese.
         *              Total cost is updated to reflect new amount.
         */
        public void SetCheese(int q)
        {
            if ((cheese + q) < 0)
            {
                cheese = 0;
            }
            else
            {
                cheese += q;
                totalCost += COST_CHEESE * q;
            }
        }

        /*
         * GetCheese()
         * 
         * Description: Getter for the cheese.
         *              Returns the current amount of cheese.
         */
        public int GetCheese()
        {
            return cheese;
        }

        /*
         * SetCream()
         * 
         * Input:   int q
         * 
         * Description: Setter for the cream field.
         *              Adds q amount of cream to the field, after validation.
         *              Total cost is updated to reflect the addition.
         */
        public void SetCream(int q)
        {
            if ((cream + q) < 0)
            {
                cream = 0;
            }
            else
            {
                cream += q;
                totalCost += COST_CREAM * q;
            }
        }

        /*
         * GetCream()
         * 
         * Description: Getter for the cream field.
         *              Returns the current amount in the cream field.
         */
        public int GetCream()
        {
            return cream;
        }
        
        /*
         * GetTotal()
         * 
         * Description: Getter for the totalCost field.
         *              Returns the total price of all the cart items.
         */
        public double GetTotal()
        {
            return totalCost;
        }

        /*
         * ResertCart()
         * 
         * Description: This method is used for resetting the cart values.
         *              The fields and total cost is reset to zero.
         */
        public void ResetCart()
        {
            apples = 0;
            bananas = 0;
            oranges = 0;
            carrots = 0;
            potatoes = 0;
            spinach = 0;
            beef = 0;
            chicken = 0;
            fish = 0;
            milk = 0;
            cheese = 0;
            cream = 0;

            totalCost = 0;
        }

        /*
         * IsEmpty()
         * 
         * Description: Method that checks if there are no items in the list.
         *              Returns false if there is items in the cart.
         *              Otherwise returns false.
         */
        public bool IsEmpty()
        {
            if (apples > 0 || bananas > 0 || oranges > 0 || carrots > 0 || potatoes > 0 || spinach > 0 || beef > 0 || chicken > 0 || fish > 0 || milk > 0 || cheese > 0 || cream > 0)
            {
                return false;
            }

            return true;
        }

        /*
         * Checkout()
         * 
         * Input:   int paymentType
         *          double amount
         *          
         * Description: Used for checking out once the user is done shopping.
         *              The int payment type of 1 or 2 indicates credit/debit or cash.
         *              Amount is the cash given by the user.
         *              Depending on type of payment, will generate a string using StringBuilder 
         *              that returns to the form the grocery receipt.
         */
        public string Checkout(int paymentType, double amount)
        {
            if (paymentType < 1 || paymentType > 2)
            {
                throw new ArgumentException("Error: paymentType must be either 1 or 2.");
            }

            StringBuilder sb = new StringBuilder();
            
            if (paymentType == 1) // 1 is for credit/debit
            {
                sb.AppendLine(GenerateItemList());
                sb.AppendLine("Payment Type: Credit/Debit\n");
                sb.AppendLine(string.Format("Total cost: {0}\n", totalCost.ToString("C2")));
                sb.AppendLine("Thanks for shopping at the John Abbott College Grocery Store!");
            }
            else if (paymentType == 2) // 2 is for cash
            {
                double change = amount - totalCost;

                sb.AppendLine(GenerateItemList());
                sb.AppendLine("Payment Type: Cash\n");
                sb.AppendLine(string.Format("Total cost: {0}", totalCost.ToString("C2")));
                sb.AppendLine(string.Format("Amount received: {0}", amount.ToString("C2")));
                sb.AppendLine(string.Format("Change: {0}\n", change.ToString("C2")));
                sb.AppendLine("Breakdown: \n");
                sb.AppendLine(GenerateChange(change));
                sb.AppendLine("Thanks for shopping at the John Abbott College Grocery Store!");
            }

            return sb.ToString();
        }

        /*
         * GenerateItemList()
         * 
         * Description: This method is used for listing specific items 
         *              in the receipt (apples, milk, etc.)
         *              If the field values are greater than 0, 
         *              will display the amount and cost using StringBuilder.
         */
        private string GenerateItemList()
        {
            StringBuilder sb = new StringBuilder();

            if (apples > 0)
            {
                sb.AppendLine(string.Format("{0} apple(s) ... {1}", apples, (apples * COST_APPLE).ToString("C2")));
            }

            if (bananas > 0)
            {
                sb.AppendLine(string.Format("{0} banana(s) ... {1}", apples, (bananas * COST_BANANA).ToString("C2")));
            }

            if (oranges > 0)
            {
                sb.AppendLine(string.Format("{0} orange(s) ... {1}", oranges, (oranges * COST_ORANGE).ToString("C2")));
            }

            if (carrots > 0)
            {
                sb.AppendLine(string.Format("{0} carrot(s) ... {1}", carrots, (carrots * COST_CARROT).ToString("C2")));
            }

            if (potatoes > 0)
            {
                sb.AppendLine(string.Format("{0} potato(s) ... {1}", potatoes, (potatoes * COST_POTATO).ToString("C2")));
            }

            if (spinach > 0)
            {
                sb.AppendLine(string.Format("{0} spinach ... {1}", spinach, (spinach * COST_SPINACH).ToString("C2")));
            }

            if (beef > 0)
            {
                sb.AppendLine(string.Format("{0} beef ... {1}", beef, (beef * COST_BEEF).ToString("C2")));
            }

            if (chicken > 0)
            {
                sb.AppendLine(string.Format("{0} chicken ... {1}", chicken, (chicken * COST_CHICKEN).ToString("C2")));
            }

            if (fish > 0)
            {
                sb.AppendLine(string.Format("{0} fish ... {1}", fish, (fish * COST_FISH).ToString("C2")));
            }

            if (milk > 0)
            {
                sb.AppendLine(string.Format("{0} milk ... {1}", milk, (milk * COST_MILK).ToString("C2")));
            }

            if (cheese > 0)
            {
                sb.AppendLine(string.Format("{0} cheese ... {1}", cheese, (cheese * COST_CHEESE).ToString("C2")));
            }

            if (cream > 0)
            {
                sb.AppendLine(string.Format("{0} cream ... {1}", cream, (cream * COST_CREAM).ToString("C2")));
            }

            return sb.ToString();
        }

        /*
         * GenerateChange()
         * 
         * Input:   double change
         * 
         * Description: Method used for calculating the amount of change returned.
         *              Uses modulo and truncate operations to count how many 
         *              types of currency there are ($20 bills, toonies, etc.)
         *              Returns a string containing all the change.
         */
        private string GenerateChange(double change)
        {
            StringBuilder sb = new StringBuilder();

            if (change >= TWENTY_AMOUNT)
            {
                double twenties = Math.Truncate(change / TWENTY_AMOUNT);
                sb.AppendLine(string.Format("{0} $20 bill(s)", twenties.ToString()));
                change %= TWENTY_AMOUNT;
            }

            if (change >= TEN_AMOUNT)
            {
                double tens = Math.Truncate(change / TEN_AMOUNT);
                sb.AppendLine(string.Format("{0} $10 bill(s)", tens.ToString()));
                change %= TEN_AMOUNT;
            }

            if (change >= FIVE_AMOUNT)
            {
                double fives = Math.Truncate(change / FIVE_AMOUNT);
                sb.AppendLine(string.Format("{0} $5 bill(s)", fives.ToString()));
                change %= FIVE_AMOUNT;
            }

            if (change >= TOONIE_AMOUNT)
            {
                double toonies = Math.Truncate(change / TOONIE_AMOUNT);
                sb.AppendLine(string.Format("{0} $2 coin(s)", toonies.ToString()));
                change %= TOONIE_AMOUNT;
            }

            if (change >= LOONIE_AMOUNT)
            {
                double loonies = Math.Truncate(change / LOONIE_AMOUNT);
                sb.AppendLine(string.Format("{0} $1 coin(s)", loonies.ToString()));
                change %= LOONIE_AMOUNT;
            }

            if (change >= QUARTER_AMOUNT)
            {
                double quarters = Math.Truncate(change / QUARTER_AMOUNT);
                sb.AppendLine(string.Format("{0} quarter(s)", quarters.ToString()));
                change %= QUARTER_AMOUNT;
            }

            if (change >= DIME_AMOUNT)
            {
                double dimes = Math.Truncate(change / DIME_AMOUNT);
                sb.AppendLine(string.Format("{0} dime(s)", dimes.ToString()));
                change %= DIME_AMOUNT;
            }

            if (change >= NICKEL_AMOUNT)
            {
                double nickels = Math.Truncate(change / NICKEL_AMOUNT);
                sb.AppendLine(string.Format("{0} nickel(s)", nickels.ToString()));
                change %= NICKEL_AMOUNT;
            }   

            return sb.ToString();
        }
    }
}
