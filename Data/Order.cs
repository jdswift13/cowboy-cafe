using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order
    {
        private List<IOrderItem> items = new List<IOrderItem>();
        private double subtotal = 0;
        private static uint lastOrderNumber;
        public uint OrderNumber
        {
            get
            {
                lastOrderNumber++;
                return lastOrderNumber + 1;

            }
        }
        public double Subtotal
        {
            get
            {
                return subtotal;
            }
        }
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();
        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal += item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            subtotal -= item.Price;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        
    }
}