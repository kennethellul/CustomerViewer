using CustomerViewer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerViewer
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Customer c = new Customer
            {
                Name = "Tom",
                Gender = "M",
                PhoneNumber = 123456,
                Age = 2,
                Address = "Nuremberg"      
            };

            TableRow row = new TableRow();
       
            TableCell cell1 = new TableCell();
            TableCell cell2 = new TableCell();
            TableCell cell3 = new TableCell();
            TableCell cell4 = new TableCell();
            TableCell cell5 = new TableCell();

            cell1.Text = c.Name;
            cell2.Text = c.Address;
            cell3.Text = c.Age.ToString();
            cell4.Text = c.Gender;
            cell5.Text = c.PhoneNumber.ToString();

            row.Cells.Add(cell1);
            row.Cells.Add(cell2);
            row.Cells.Add(cell3);
            row.Cells.Add(cell4);
            row.Cells.Add(cell5);
            

            Table1.Rows.Add(row);
            
        }
    }
}