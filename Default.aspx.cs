using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var categoryValue = GetSelectedCategory().ToInteger();
                PopulateList(categoryValue);
            }
            catch
            {
                throw new ApplicationException("Error");
            }

        }

        private void PopulateList(int categoryValue)
        {
            var items = new List<ListItem>();
            switch (categoryValue)
            {
                case 1:
                    items.Add(new ListItem("Cat1:Item1", "1"));
                    items.Add(new ListItem("Cat1:Item2", "2"));
                    break;
                case 2:
                    items.Add(new ListItem("Cat2:Item1", "1"));
                    items.Add(new ListItem("Cat2:Item2", "2"));
                    items.Add(new ListItem("Cat2:Item3", "3"));
                    break;
                default:
                    throw new ApplicationException("Kaboom");
            }
            lstStuff.Items.Clear();
            lstStuff.Items.AddRange(items.ToArray());
        }


        private string GetSelectedCategory()
        {
            var result = string.Empty;
            var selectedItem = selCategory.SelectedItem;
            if (selectedItem != null)
            {
                result = selectedItem.Value;
            }
            return result;
        }

 
 
    }


    public static class Helpers
    {

        public static int ToInteger(this string value)
        {
            return Convert.ToInt32(value);
        }     
    }
}