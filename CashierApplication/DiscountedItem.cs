using System;

namespace ItemNamespace
{
    public class DiscountedItem : Item
    {
        private double item_discount;
        private double discounted_price;
        private double payment_amount;
        private double change;

        public DiscountedItem(string name,
                              double price,
                              int quantity,
                              double discount)
            : base(name, price, quantity)
        {
            item_discount = discount * 0.01;
        }

        public override double getTotalPrice()
        {
            double discountAmount = item_discount * item_price;

            discounted_price = item_price - discountAmount;

            total_price = discounted_price * item_quantity;

            return total_price;
        }

        public override void setPayment(double amount)
        {
            payment_amount = amount;
            change = payment_amount - total_price;
        }

        public double getChange()
        {
            return change;
        }
    }
}