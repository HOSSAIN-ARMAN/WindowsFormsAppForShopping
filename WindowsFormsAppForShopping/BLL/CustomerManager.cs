using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Repository;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.BLL
{
    public class CustomerManager
    {
        CustomerRepository _customerRepository = new CustomerRepository();
        public bool SaveCustomer(ModelCustomer modelCustomer)
        {
            return _customerRepository.SaveCustomer(modelCustomer);
        }
        public DataTable DisplayCustomerInfo()
        {
            return _customerRepository.DisplayCustomerInfo();
        }
    }
}
