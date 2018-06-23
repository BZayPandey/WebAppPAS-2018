using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLLCategory
    {
        BroadwayDBBEntities bdb = new BroadwayDBBEntities();
        public List<CategoryViewModel> GetAllCategories()
        {

            List<CategoryViewModel> lstc = new List<CategoryViewModel>();
            var categories = bdb.tblCategories.ToList();
            foreach (tblCategory tb in categories)
            {
                lstc.Add(new CategoryViewModel() { Categoryid = tb.Categoryid, CategoryName = tb.CategoryName });
            }
            return lstc;
        }
    }
}
