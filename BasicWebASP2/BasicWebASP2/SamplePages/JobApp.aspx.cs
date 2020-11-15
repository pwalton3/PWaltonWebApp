﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebASP2.SamplePages
{
    public partial class JobApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string msg = "";
            msg += "Name: " + FullName.Text;
            msg += "Email: " + EmailAddress.Text;
            msg += "Phone: " + Phone.Text;
            msg += "Full time or Part Time: " + (FullOrPartTime.SelectedValue == "1" ? "Full Time " :
                                                 FullOrPartTime.SelectedValue == "2" ?  "Part Time " : "Either ");

            //handle the CheckBoxList
            //Traverses the  checkbox list, and review one item at a time and add those items selected to the message
            //if no items were chosen, then add an approopriate message stating that no items were chosen 

            msg += "Jobs: ";
            //set my found flag to "nothing found" (false)
            bool found = false;

            //loop processing, if something is found then set the found flag to true 
            foreach(ListItem jobrow in Jobs.Items)
            {
                //for each item in the collection 
                if(jobrow.Selected)
                {
                    msg += jobrow.Text + " ";
                    found = true;
                }
            }
            // check if something was found
            if(!found)
            {
                msg += "You did not select a job. Application rejected";
            }
            MessageLabel.Text = msg;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FullName.Text = "";
            EmailAddress.Text = "";
            Phone.Text = "";
            //for Lists there are a couple of ways to reset
            //A) manually reset the control selectIndex to -1
            FullOrPartTime.SelectedIndex = -1;
            //B) use a control method to reset
            Jobs.ClearSelection();
        }
    }
}