﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


#region Additional NameSpace
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;
#endregion
namespace WebApp.SamplePages
{
    public partial class SimpleQuery : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "";
        }

        protected void RegionSearch_Click(object sender, EventArgs e)
        {
            //standard look up
            //verify that you have input
            if(string.IsNullOrEmpty(RegionArg.Text))
            {
                MessageLabel.Text = "Enter a region ID";
            }
            else
            {
                //I am assuming that a number has been entered, this should really be validated
                //standard lookup
                //connect to controller CLASS by creating an instance
                RegionController sysmgr = new RegionController();
                //issue your call to the class instance
                Region info = sysmgr.Region_FindByID(int.Parse(RegionArg.Text));
                //test results and either display record or appropriate message
                if (info == null)
                {
                    MessageLabel.Text = "No region for supplied value";
                }
                else
                {
                    RegionID.Text = info.RegionID.ToString();
                    RegionDescription.Text = info.RegionDescription;
                }
            }
        }
    }
}