using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Repository;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.BLL
{
    public class SupplierManager
    {
        SupplierRepository _supplierRepository = new SupplierRepository();
        public bool AddSupplier(SupplierModel supplierModel)
        {
            return _supplierRepository.AddSupplier(supplierModel);
        }
        public DataTable DisplaySaveSupplier()
        {
            return _supplierRepository.DisplaySaveSupplier();
        }
        public List<SupplierModel> UpdateSupplierInfo(SupplierModel supplierModel)
        {
            return _supplierRepository.UpdateSupplierInfo(supplierModel);
        }
        public DataTable DisplayComboSupplier()
        {
            return _supplierRepository.DisplayComboSupplier();
        }
    }
}
