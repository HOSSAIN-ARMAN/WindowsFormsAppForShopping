using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsAppForShopping.Repository;
using WindowsFormsAppForShopping.Model;

namespace WindowsFormsAppForShopping.BLL
{
    public class PurchaseManager
    {
        PurchaseRepository _purchaseRepository = new PurchaseRepository();
        public bool SubmitPurchase(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.SubmitPurchase(modelPurchase);
        }
    }
}
