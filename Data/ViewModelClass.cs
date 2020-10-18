/*
* Author: Haoran An
* Class name: Combo.cs
* Purpose: Middle class of Cash Payment logic
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using BleakwindBuffet.Data;
using RoundRegister;


namespace BleakwindBuffet.Data
{
    /// <summary>
    /// Middle class of Cash Payment logic
    /// </summary>
    public class ViewModelClass : INotifyPropertyChanged
    {
        /// <summary>
        /// current order
        /// </summary>
        Order order;
        public ViewModelClass(Order current)
        {
            order = current;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Total price from the Customer
        /// </summary>
        public double TotalPay
        {
            get
            {
                return (Ones + (Twos * 2) + (Fives * 5) + (Tens * 10) + (Twenties * 20) + (Fifties * 50) + (Hundreds * 100)
                + (Pennies * 0.01) + (Nickels * 0.05) + (Dimes * 0.1) + (Quarters * 0.25) + (HalfDollars * 0.5) + Dollars);
            }
        }
        /// <summary>
        /// current left to current order form Customer
        /// </summary>
        public double Total
        {
            get
            {
                double total = 0;
                total = order.Total-( Ones + (Twos * 2) + (Fives * 5) + (Tens * 10) + (Twenties * 20) + (Fifties * 50) + (Hundreds * 100)
                +(Pennies*0.01) +(Nickels*0.05)+(Dimes*0.1)+(Quarters*0.25)+(HalfDollars*0.5)+ Dollars);
                return total;
            }
        }
        /// <summary>
        /// Nomber of one dollars bills form Customer
        /// </summary>
        int ones =0;
        public int Ones
        {
            get { return ones; }
            set {
                ones  = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Ones"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of twos bills form Customer
        /// </summary>
        int twos = 0;
        public int Twos
        {
            get { return twos; }
            set {
                twos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of fives bills form Customer
        /// </summary>
        int fives = 0;
        public int Fives
        {
            get { return fives; }
            set {
                fives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of Tens bills form Customer
        /// </summary>
        int tens = 0;
        public int Tens
        {
            get { return tens; }
            set {
                tens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of twenties bills form Customer
        /// </summary>
        int twenties = 0;
        public int Twenties
        {
            get { return twenties; }
            set {
                twenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Twenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of fifties bills form Customer
        /// </summary>
        int fifties = 0;
        public int Fifties
        {
            get { return fifties; }
            set {
                fifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Fifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of hundreds bills form Customer
        /// </summary>
        int hundreds = 0;
        public int Hundreds
        {
            get { return hundreds; }
            set {
                hundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Hundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of pennies form Customer
        /// </summary>
        int pennies = 0;
        public int Pennies
        {
            get { return pennies; }
            set
            {
                pennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of nickels form Customer
        /// </summary>
        int nickels = 0;
        public int Nickels
        {
            get { return nickels; }
            set
            {
                nickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Nickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of dimes form Customer
        /// </summary>
        int dimes = 0;
        public int Dimes
        {
            get { return dimes; }
            set
            {
                dimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of quarters form Customer
        /// </summary>
        int quarters = 0;
        public int Quarters
        {
            get { return quarters; }
            set
            {
                quarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Quarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of halfDollars form Customer
        /// </summary>
        int halfDollars = 0;
        public int HalfDollars
        {
            get { return halfDollars; }
            set
            {
                halfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of dollars form Customer
        /// </summary>
        int dollars = 0;
        public int Dollars
        {
            get { return dollars; }
            set
            {
                dollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Dollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Total"));
                GetChanged();
            }
        }
        /// <summary>
        /// Nomber of dollars changed to Customer
        /// </summary>
        private int bdollars;
        public int Bdollars { 
            get
            {
                return bdollars;
            }
            set {
                bdollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bdollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of halfDollars changed to Customer
        /// </summary>
        private int bhalfDollars;
        public int BhalfDollars
        {
            get
            {
                return bhalfDollars;
            }
            set
            {
                bhalfDollars = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("BhalfDollars"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of quarters changed to Customer
        /// </summary>
        private int bquarters;
        public int Bquarters
        {
            get
            {
                return bquarters;
            }
            set
            {
                bquarters = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bquarters"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of dimes changed to Customer
        /// </summary>
        private int bdimes;
        public int Bdimes
        {
            get
            {
                return bdimes;
            }
            set
            {
                bdimes = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bdimes"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of nickel changed to Customer
        /// </summary>
        private int bnickels;
        public int Bnickels
        {
            get
            {
                return bnickels;
            }
            set
            {
                bnickels = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bnickels"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of pennies changed to Customer
        /// </summary>
        private int bpennies;
        public int Bpennies
        {
            get
            {
                return bpennies;
            }
            set
            {
                bpennies = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bpennies"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of hundreds bills changed to Customer
        /// </summary>
        private int bhundreds;
        public int Bhundreds
        {
            get
            {
                return bhundreds;
            }
            set
            {
                bhundreds = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bhundreds"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of fifties bills changed to Customer
        /// </summary>
        private int bfifties;
        public int Bfifties
        {
            get
            {
                return bfifties;
            }
            set
            {
                bfifties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bfifties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of twenties bills changed to Customer
        /// </summary>
        private int btwenties;
        public int Btwenties
        {
            get
            {
                return btwenties;
            }
            set
            {
                btwenties = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Btwenties"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }

        /// <summary>
        /// Nomber of tens bills changed to Customer
        /// </summary>
        private int btens;
        public int Btens
        {
            get
            {
                return btens;
            }
            set
            {
                btens = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Btens"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of fives bills changed to Customer
        /// </summary>
        private int bfives;
        public int Bfives
        {
            get
            {
                return bfives;
            }
            set
            {
                bfives = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bfives"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of twos bills changed to Customer
        /// </summary>
        private int btwos;
        public int Btwos
        {
            get
            {
                return btwos;
            }
            set
            {
                btwos = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Btwos"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// Nomber of ones bills changed to Customer
        /// </summary>
        private int bones;
        public int Bones
        {
            get
            {
                return bones;
            }
            set
            {
                bones = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bones"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalChange"));
            }
        }
        /// <summary>
        /// The Total Number in drawer
        /// </summary>
        public double Totalleft { get; set; }
        public double TotalChange
        {
            get {
                return (Bones + (Btwos * 2) + (Bfives * 5) + (Btens * 10) + (Btwenties * 20) + (Bfifties * 50) + (Bhundreds * 100)
                + (Bpennies * 0.01) + (Bnickels * 0.05) + (Bdimes * 0.1) + (Bquarters * 0.25) + (BhalfDollars * 0.5) + Bdollars);
            }
        }
        /// <summary>
        ///  Finish Order Adds the quantity of currency the customer paid to the CashDrawer's fields
        /// </summary>
        public void CheckOut()
        {
            CashDrawer.OpenDrawer();
            CashDrawer.Ones = CashDrawer.Ones + Ones - Bones;
            CashDrawer.Fives = CashDrawer.Fives + Fives - Bfives;
            CashDrawer.Tens = CashDrawer.Tens + Tens - Btens;
            CashDrawer.Twenties = CashDrawer.Twenties + Twenties - Btwenties;
            CashDrawer.Fifties = CashDrawer.Fifties + Fifties - Bfifties;
            CashDrawer.Hundreds = CashDrawer.Hundreds + Hundreds - Bhundreds;
            CashDrawer.Pennies = CashDrawer.Pennies + Pennies - Bpennies;
            CashDrawer.Nickels = CashDrawer.Nickels + Nickels - Bnickels;
            CashDrawer.Dimes = CashDrawer.Dimes + Dimes - Bdimes;
            CashDrawer.Quarters = CashDrawer.Quarters + Quarters - Bquarters;
            CashDrawer.HalfDollars = CashDrawer.HalfDollars + HalfDollars - BhalfDollars;
            CashDrawer.Dollars = CashDrawer.Dollars + Dollars - Bdollars;
        }
        /// <summary>
        /// calculate changed to Customer
        /// </summary>
        public void GetChanged()
        {
            Totalleft = CashDrawer.Total - (Bones + (Btwos * 2) + (Bfives * 5) + (Btens * 10) + (Btwenties * 20) + (Bfifties * 50) + (Bhundreds * 100)
            + (Bpennies * 0.01) + (Bnickels * 0.05) + (Bdimes * 0.1) + (Bquarters * 0.25) + (BhalfDollars * 0.5) + Bdollars);
            Bdollars = 0;
            BhalfDollars = 0;
            Bquarters = 0;
            Bdimes  = 0;
            Bnickels  = 0;
            Bpennies = 0;
            Bhundreds = 0;
            Bfifties = 0;
            Btwenties = 0;
            Btens= 0;
            Bfives  = 0;
            Btwos = 0;
            Bones= 0;
            if (Total > 0) return;
            double ChangeTotal = Math.Round(Total * (-1), 2);
            while(ChangeTotal != 0)
            {
                if (Totalleft<=0)
                {
                    break;
                }
                if (Math.Floor(ChangeTotal / 100) >= 1 &&  Bhundreds< CashDrawer.Hundreds)
                {
                    ChangeTotal= Math.Round(ChangeTotal -= 100, 2);
                    Bhundreds += 1;
                    Totalleft= Math.Round(Totalleft -= 100, 2);
                }
                else if (Math.Floor(ChangeTotal / 50) >= 1 && Bfifties < CashDrawer.Fifties)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 50, 2);
                    Bfifties += 1;
                    Totalleft = Math.Round(Totalleft -= 50, 2);
                }
                else if (Math.Floor(ChangeTotal / 20) >= 1 && Btwenties < CashDrawer.Twenties)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 20, 2);
                    Btwenties += 1;
                    Totalleft = Math.Round(Totalleft -= 20, 2);
                }
                else if (Math.Floor(ChangeTotal / 10) >= 1 && Btens < CashDrawer.Tens )
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 10, 2);
                    Btens += 1;
                    Totalleft = Math.Round(Totalleft -= 10, 2);
                }
                else if (Math.Floor(ChangeTotal / 5) >= 1 && Bfives < CashDrawer.Fives )
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 5, 2);
                    Bfives += 1;
                    Totalleft = Math.Round(Totalleft -= 5, 2);
                }
                else if (Math.Floor(ChangeTotal / 1) >= 1 && Bones < CashDrawer.Ones )
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 1, 2);
                    Bones += 1;
                    Totalleft = Math.Round(Totalleft -= 1, 2);
                }
                else if (Math.Floor(ChangeTotal / 1) >= 1 && Bdollars < CashDrawer.Dollars)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 1, 2);
                    Bdollars += 1;
                    Totalleft = Math.Round(Totalleft -= 1, 2);
                }
                else if (Math.Floor(ChangeTotal / 0.5) >= 1 && BhalfDollars < CashDrawer.HalfDollars)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 0.5, 2);
                    BhalfDollars += 1;
                    Totalleft = Math.Round(Totalleft -= 0.5, 2);
                }
                else if (Math.Floor(ChangeTotal / 0.25) >= 1 && Bquarters < CashDrawer.Quarters)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 0.25, 2);
                    Bquarters += 1;
                    Totalleft = Math.Round(Totalleft -= 0.25, 2);
                }
                else if (Math.Floor(ChangeTotal / 0.1) >= 1 && Bdimes < CashDrawer.Dimes)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 0.1, 2);
                    Bdimes += 1;
                    Totalleft = Math.Round(Totalleft -= 0.1, 2);
                }
                else if (Math.Floor(ChangeTotal / 0.05) >= 1 && Bnickels < CashDrawer.Nickels)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 0.05, 2);
                    Bnickels += 1;
                    Totalleft = Math.Round(Totalleft -= 0.05, 2);
                }
                else if (Math.Floor(ChangeTotal / 0.01) >= 1 && Bpennies < CashDrawer.Pennies)
                {
                    ChangeTotal = Math.Round(ChangeTotal -= 0.01, 2);
                    Bpennies += 1;
                    Totalleft = Math.Round(Totalleft -= 0.01, 2);
                }
            }
        }
    }
}
