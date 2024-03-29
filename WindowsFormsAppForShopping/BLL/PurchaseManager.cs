﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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

        public bool IsCodeExits(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.IsCodeExits(modelPurchase);
        }

        public string AvaiableQuantity(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.AvaiableQuantity(modelPurchase);
        }

        public string PreviousUnitPrice(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.PreviousUnitPrice(modelPurchase);
        }
        public string PreviousMRP(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.PreviousMRP(modelPurchase);
        }
        public DataTable PurchaseCategory()
        {
            return _purchaseRepository.PurchaseCategory();
        }
        public DataTable PurchaseProduct(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.PurchaseProduct(modelPurchase);
        }
        public string AvaiablePurchaseQuantity(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.AvaiablePurchaseQuantity(modelPurchase);
        }
        public string TotalMrp(ModelPurchase modelPurchase)
        {
            return _purchaseRepository.TotalMrp(modelPurchase);
        }
    }
}
