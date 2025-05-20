using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class OrderRepository
    {
        public bool Validate()
        {
            bool isValid = true;

            isValid = (this.Id > 0);

            return isValid;
        }

        public Order Retrieve()
        {
            return new Order();
        }

        public void Save(Order order)
        {
        }
    }
}
