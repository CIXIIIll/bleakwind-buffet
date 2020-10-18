using BleakwindBuffet.Data;
using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    public class Recieptprinter
    {
        string Payment;
        Order Current;
        ViewModelClass Vmc;
        public Recieptprinter(Order order,string payment, ViewModelClass vmc)
        {
            Current = order;
            Payment = payment;
            Vmc = vmc;
        }
        public void PrintRecipet()
        {
            RecieptPrinter.PrintLine("Order number " + (Current.NextOrderNumber - 1) + " ");
            RecieptPrinter.PrintLine("Time : " + DateTime.Now + " ");
            foreach(IOrderItem item in Current.OrderItems)
            {
                RecieptPrinter.PrintLine(item.ToString());
                RecieptPrinter.PrintLine("Price : $"+item.Price.ToString());
                foreach(string str in item.SpecialInstructions)
                {
                    RecieptPrinter.PrintLine(str);
                }
            }
            RecieptPrinter.PrintLine("Subtotal : $" + Math.Round(Current.Subtotal,2) + " ");
            RecieptPrinter.PrintLine("Tax : $" + Math.Round(Current.Tax, 2) + " ");
            RecieptPrinter.PrintLine("Total : $" + Math.Round(Current.Total, 2) + " ");
            switch (Payment)
            {
                case "Cash":
                    RecieptPrinter.PrintLine("Paid by Cash");
                    RecieptPrinter.PrintLine("Total Paid: $"+ Math.Round(Vmc.TotalPay,2));
                    RecieptPrinter.PrintLine("Change : $" + Math.Round(Vmc.TotalChange, 2));
                    break;
                case "Card":
                    RecieptPrinter.PrintLine("Paid by Card");
                    break;
            }
            RecieptPrinter.CutTape();
        }
    }
}
