using BasicWebASP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class ContestEntry : System.Web.UI.Page
    {
        //due to the fact, that this example is NOT using a database to retain data, the following 
        //List<T> will serve as the page collection data set 
        //the List<T> is declared as static 
        //the List<T> will remain active as long as the web application is running 
        //The List<T> is created on the first presentation of this web page
        //WARNING: all users would have access to this List<T> 
        static List<Entry> entries = new List<Entry>();
        protected void Page_Load(object sender, EventArgs e)
        {
            Message.Text = "";
            if (!Page.IsPostBack)
            {
                //on the first presentation of the page 
                if (entries.Count > 0)
                {
                    EntryList.DataSource = entries;
                    EntryList.DataBind();
                }
            }
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            //re--execute the validation controls on the server side
            if (Page.IsValid)
            {
                if (Terms.Checked)
                {
                    List<Entry> entries = new List<Entry>();
                    //create an instance of the data class 
                    Entry theEntry = new Entry();

                    //load the instance with data from the form 
                    theEntry.FirstName = FirstName.Text;
                    theEntry.LastName = LastName.Text;
                    theEntry.StreetAddress1 = StreetAddress1.Text;
                    theEntry.StreetAddress2 = string.IsNullOrEmpty(StreetAddress2.Text) ? null : StreetAddress2.Text;
                    theEntry.City = City.Text;
                    theEntry.Province = Province.Text;
                    theEntry.PostalCode = PostalCode.Text;
                    theEntry.EmailAddress = EmailAddress.Text;

                    //add the new instance to a  collection of entries
                    entries.Add(theEntry);

                    //display the collection 
                    //use a collection display control that displays multiple seperate columns: GridView
                    //requirements:
                    //A) data source (collection)
                    //B) bind the data to the controls 

                    EntryList.DataSource = entries;
                    EntryList.DataBind();

                }
                else
                {
                    Message.Text = "You did not agree to the contest terms. Entry rejected.";
                }
            }
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            StreetAddress1.Text = "";
            StreetAddress2.Text = "";
            City.Text = "";
            PostalCode.Text = "";
            EmailAddress.Text = "";
            CheckAnswer.Text = "";
            Province.SelectedIndex = 0; //DDL (drop down list)
            Terms.Checked = false;

        }
    }
}