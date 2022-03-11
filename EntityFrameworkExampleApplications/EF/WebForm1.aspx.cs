using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EF
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CategoryDBContext ctx = new CategoryDBContext();
            Category category = new Category();
            category.CategoryName = "Elma";
            ctx.Categories.Add(category);
            ctx.SaveChanges();
        }
    }
}