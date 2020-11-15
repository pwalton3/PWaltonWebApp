﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebASP2
{
    public partial class HelloWorld : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this method executes BEFORE any event method on
            //EACH proccessing of this web page
            OutputArea.ForeColor = System.Drawing.Color.Black;
            OutputArea.Text = "";
            OutputArea.Font.Size = 20;
        }

        protected void PressMe_Click(object sender, EventArgs e)
        {
            //this method stub for the button was generated by double clicking the button conntrol on your web form while in design view
            //when the press me button is pressed this code will be executed
            //this is called event driven logic
            //the event was the pressing of the button
            //see the on click property oof your control on the web page
            //the id name of a control acts as the variable name in your code
            //since each control is a class instance, access to the contents of a class is by the class properties
            //JUST like razor , 95% of all data content is returned as a string 

            if (string.IsNullOrEmpty(NameArg.Text))
            {
                OutputArea.Text = "Enter your name";
                
            }
            else
            {
                OutputArea.Text = "Hello " + NameArg.Text;
                OutputArea.ForeColor = System.Drawing.Color.Teal;
                
            }
        }
    }
}