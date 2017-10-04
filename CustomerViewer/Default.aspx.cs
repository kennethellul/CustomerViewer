using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    public CustomerViewModel vm;

    protected void Page_Load(object sender, EventArgs e)
    {
        vm = new CustomerViewModel
        {
            Age = 2,
            Name = "Alan"
        };

    }
}