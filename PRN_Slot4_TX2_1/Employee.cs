using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRN_Slot4_TX2_1
{
    abstract class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;

        public Employee(string name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName() {  return name; }

        public void SetPaymentPerHour(int paymentPerHour)
        {
            this.paymentPerHour = paymentPerHour;
        }

        public int GetPaymentPerHour()
        {
            return paymentPerHour;
        }
        public abstract int CalculateSalary();
        public override string ToString()
        {
            return $"Name: {name}, Payment Per Hour: {paymentPerHour}";
        }
    }
}
