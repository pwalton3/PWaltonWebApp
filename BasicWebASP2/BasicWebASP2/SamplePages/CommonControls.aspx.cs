using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BasicWebASP2.SamplePages
{
    public partial class CommonControls : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //this method executes BEFORE any event method on EACH processing of this web page
            //this is a great place to do common code that is required on EACH process of the page 
            //Example: empty out old messages
            Messagelabel.Text = "";

            //this is an excellent place to do page initilization of controls for the first time 
            //checking the first time  for the page uses the post back flag 
            //IsPostBack is a boolean value (true or false)
            if(!Page.IsPostBack)
            {
                //if the page if not PostBack, it meanss that this if the first time the page has been displayed
                //you can do page initalization

                //create a collection of  instances (class objects) that will be used to load the dropdownlist
                //this will simulate the loading control as if the data can from a databases table
                //each instance would represent a record on the database dataset
                //to acomplish this simulation
                List<DDLData> DDLCollection = new List<DDLData>();
                DDLCollection.Add(new DDLData(1, "COMP1008"));
                DDLCollection.Add(new DDLData(3, "DMIT1508"));
                DDLCollection.Add(new DDLData(4, "DMIT2018"));
                DDLCollection.Add(new DDLData(2, "CPSC1517"));

                //place the data into the dropdownlist control
                //4 steps to this process

                //1) assign the data collection to the contorl
                CollectionList.DataSource = DDLCollection;

                //2) in this step, you will assign the value that will be displayed to the user and the value that will be associated 
                //and return from the control when the user picks a particular selection
                //in the <select> control, this data was setup using the <option>
                //      <option value = "xxx"> display string </option>

                //2 styles in setting up the control values
                //A) a physical string of the field name
                CollectionList.DataValueField = "ValueID";
                //B) OOP style coding
                CollectionList.DataTextField = nameof(DDLData.DisplayText);

                //3) bind your data source to your control 
                CollectionList.DataBind();

                //4) optional is to add a prompt list to your dropdownlist
                CollectionList.Items.Insert(0, new ListItem("select...","0"));

                //sorting a List<T>
                //(x,y) are place holder representing any 2 records at any given time druing the sort
                //=> (lamda symbol) is part of the delegate syntax, I suggest that you read this symbol as "do the following"
                //comparing x to y is ascending
                //comparing y to x is descending

                DDLCollection.Sort((x,y) => x.DisplayText.CompareTo(y.DisplayText));
            }

        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            int numberchoice = 0;
            //validation checking that i have good data for my choicee
            if(string.IsNullOrEmpty(NumberChoice.Text))
            {
                Messagelabel.Text = "Enter a number from 1 to 4";
            }
            else if(!int.TryParse(NumberChoice.Text, out numberchoice))
            {
                Messagelabel.Text = "invalid number. Enter a number from 1 to 4";
            }
            else if (numberchoice < 1 || numberchoice > 4)
            {
                Messagelabel.Text = "number is out of range. enter a number from 1 to 4";
            }
            else
            {
                //good input data
                //RadioButtonList
                //assign a value to the RadioButtonList to indicate the item choice
                //  based on the inpt data value 
                //this can be done using either: .SelectedValue or .SelectIndex
                //.SelectedValue will match the control item value tothe argument (BEST  TO USE)
                //.SelectedIndex selects the control item to show based on the numerical index value (for PHYSICAL POSITIONING ONLY)
                RadioButtonListChoice.SelectedValue = numberchoice.ToString();
                //RadioButtonListChoice.SelectedValue = numberchoice.ToString();

                //set the checkbox
                if (numberchoice == 2 || numberchoice ==  4)
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }

                //position in CollectionList on the selected item row
                //this can be done using either: .SelectedValue or .SelectIndex
                //.SelectedValue will match the control item value tothe argument (BEST  TO USE)
                //.SelectedIndex selects the control item to show based on the numerical index value (for PHYSICAL POSITIONING ONLY)
                CollectionList.SelectedValue = numberchoice.ToString();

                //access data from the CollectionList and display in the ReadOnly label
                //this can be done using either: .SelectedValue or .SelectIndex or .SelectedItem
                //.SelectedValue will return the value associated with the select item from the dropdownlist (is a value)
                //.SelectedIndex will return the index of the row selected in the dropdownlist (is the physical index position of the row)
                //.SeectedItem will return the display text associated with the selected item from the dropdownlist (is the dispplay text)

                DisplayReadOnly.Text = CollectionList.SelectedItem.Text + "at index" + CollectionList.SelectedIndex + "having a value of" + CollectionList.SelectedValue
                    + ". this matches the radio button choice item value" + RadioButtonListChoice.SelectedValue ;
            }
        }

        protected void LinkButtonChoice_Click(object sender, EventArgs e)
        {
            int numberchoice = 0;
            if(CollectionList.SelectedIndex == 0)
            {
                Messagelabel.Text = "Select a choice from the list; then press the button";
            }
            else
            {
                numberchoice = int.Parse(CollectionList.SelectedValue);
                RadioButtonListChoice.SelectedValue = numberchoice.ToString();
                if (numberchoice == 2 || numberchoice == 4)
                {
                    CheckBoxChoice.Checked = true;
                }
                else
                {
                    CheckBoxChoice.Checked = false;
                }
                NumberChoice.Text = numberchoice.ToString();
                DisplayReadOnly.Text = CollectionList.SelectedItem.Text + "at index" + CollectionList.SelectedIndex + "having a value of" + CollectionList.SelectedValue
                    + ". this matches the radio button choice item value" + RadioButtonListChoice.SelectedValue;
            }
        }
    }
}