using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppForShopping.Model
{
    public class ModelProduct
    {
        public int Id { set; get; }
        public string CategoryName { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ReOrder { set; get; }
        public string Description { set; get; }
    }
}
