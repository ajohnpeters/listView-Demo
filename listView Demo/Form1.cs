using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listView_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // demolistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            // demolistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            homefolderlabel.Text = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); ;
            demolistView.View = View.Details;
             demolistView.Width =400;
            List<string> name = new List<string> { "Joe", "Jill", "aaron","Steven" };
            List<string> phone = new List<string> { "555-555-5555", "666-666-6666", "777-777-7777","888-888-888" };
            List<string> email = new List<string> { "Joe@a.com", "Jill@b.com", "aaron@c.com","Steven@d.com" };
            List<string> program = new List<string> { "Programming", "Networking", "Specialist","astro physisi" };
            for (int i=0;i<name.Count(); i++)
            {
                ListViewItem item = new ListViewItem(name[i]);
                item.SubItems.Add(phone[i]);
                item.SubItems.Add(email[i]);
                item.SubItems.Add(program[i]);
                demolistView.Items.Add(item); 
            }
           /* ListViewItem item1 = new ListViewItem("Joe");

             item1.SubItems.Add("555-555-5678");
             item1.SubItems.Add("a@b.com");
             item1.SubItems.Add("programming");

             ListViewItem item2 = new ListViewItem("Jill");
             item2.SubItems.Add("555-678-2345");
             item2.SubItems.Add("c@d.com");
             item2.SubItems.Add("networking");

             ListViewItem item3 = new ListViewItem("Aaron");
             item3.SubItems.Add("555-543-6666");
             item3.SubItems.Add("e@f.com");
             item3.SubItems.Add("other");*/
             // Create columns for the items and subitems.
             // Width of -2 indicates auto-size.
             demolistView.Columns.Add("Name           ", -2, HorizontalAlignment.Left);
             demolistView.Columns.Add("Phone   ", -2, HorizontalAlignment.Left);
             demolistView.Columns.Add("email            ", -2, HorizontalAlignment.Left);
             demolistView.Columns.Add("Program     ", -2, HorizontalAlignment.Left);

             

            demolistView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            demolistView.Width = 270;
            demolistView.Location = new System.Drawing.Point(250, 10);

            // Declare and construct the ColumnHeader objects.
            ColumnHeader header1, header2;
            header1 = new ColumnHeader();
            header2 = new ColumnHeader();

            // Set the text, alignment and width for each column header.
            header1.Text = "File name";
            header1.TextAlign = HorizontalAlignment.Left;
            header1.Width = 70;

            header2.TextAlign = HorizontalAlignment.Left;
            header2.Text = "Location";
            header2.Width = 200;

            // Add the headers to the ListView control.
            demolistView.Columns.Add(header1);
            demolistView.Columns.Add(header2);

            // Specify that each item appears on a separate line.
            demolistView.View = View.Details;

            // Populate the ListView.Items property.
            // Set the directory to the sample picture directory.
            System.IO.DirectoryInfo dirInfo =
                new System.IO.DirectoryInfo(
                "C:\\Documents and Settings\\ajpeters" +
                "\\Pictures");


            // Get the .jpg files from the directory
            System.IO.FileInfo[] files = dirInfo.GetFiles("*.jpg");

            // Add each file name and full name including path
            // to the ListView.
            if (files != null)
            {
                foreach (System.IO.FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem(file.Name);
                    item.SubItems.Add(file.FullName);
                    demolistView.Items.Add(item);
                }
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            if (demolistView.SelectedItems.Count > 0)
            {
                ListViewItem item = demolistView.SelectedItems[0];
                outputLabel.Text = item.SubItems[0].Text;
                outputLabel.Text += "\n"+item.SubItems[1].Text;
                outputLabel.Text += "\n" + item.SubItems[2].Text;
                outputLabel.Text += "\n" + item.SubItems[3].Text;
            }
            else
            {
               outputLabel.Text = string.Empty;
                
            }
        }
    }
    }

