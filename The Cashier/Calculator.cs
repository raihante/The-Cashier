using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cashier
{
    class Calculator
    {
        private List<Item> ListItem;
        private double total = 0;

        public Calculator()
        {
            this.ListItem = new List<Item>();
        }
        public void AddItem(Item item)
        {
            this.ListItem.Add(item);
            this.total += item.getSubTotal();
        }
        public double getTotal()
        {
            return total;
        }
        public List<Item> getListItem()
        {
            return ListItem;
        }
    }
}