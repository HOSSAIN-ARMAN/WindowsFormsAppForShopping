using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForShopping.Model
{
    public class ModelPurchase
    {
        public int Id { set; get; }
        public string ProductCode { set; get; }
        public string ManufactureDate { set; get; }
        public string ExpireDate { set; get; }
        public int Quantity { set; get; }
        public int UnitePrice { set; get; }
        public int TotalPrice { set; get; }
        //public int PreviousUnitPrice { set; get; }
        //public int PreviousMRP { set; get; }
        public int MRP { set; get; }
        public string Remarks { set; get; }
        //public string SupplierDate { set; get; }
        //public string supplierInvoice { set; get; }
        //public string SupplierName { set; get; }


    }
}
