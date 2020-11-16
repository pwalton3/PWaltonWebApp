using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



#region Additional NameSpace
using Intuit.Ipp.Data;
using Xamarin.Forms;

#endregion
namespace WebAppPWalton
{
    public partial class EmployeeForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void clear_Click(object sender, EventArgs e)
        {
            ForEmployeeID.Text = "";
            ForName.Text = "";
            ForVacaDays.Text = "";
            ForEmergNum.Text = "";




        }

        protected void submit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                List<Entry> AddNew = new List<Entry>();
                Entry theEmp = new Entry();

                theEmp.Name = EmpName.Text;
            }
        }
    }
}