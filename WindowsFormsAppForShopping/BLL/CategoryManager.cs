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
    public class CategoryManager
    {
        CategoryRepository _category = new CategoryRepository();
        public bool SaveCategory(ModelCategory modelCategory)
        {
            return _category.SaveCategory(modelCategory);
        }
        public DataTable DisplaySaveCategories()
        {
            return _category.DisplaySaveCategories();
        }
        public List<ModelCategory> UpdateCategory(ModelCategory modelCategory)
        {
            return _category.UpdateCategory(modelCategory);
        }
        public DataTable DisplayComboCategories()
        {
            return _category.DisplayComboCategories();
        }
        public bool IsCategoryCodeExits(ModelCategory modelCategory)
        {
            return _category.IsCategoryCodeExits(modelCategory);
        }
    }
}
