using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatthewJacome_CE06
{
    public partial class Form1 : Form
    {
        // Matthew Jacome
      
        static decimal hours;
        static decimal miles;

        public Form1()
        {
            InitializeComponent();
            // Setting the names of the first and second oage
            tabPage1.Text = "Leg";
            tabPage2.Text = "Totals";
            comboBoxDirection.SelectedIndex = 0;
        }
        // Exit application
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Add button
        private void buttonAdd_Click(object sender, EventArgs e)
        {

            // New Object for custom class and setting each property value
            UserInput userInput = new UserInput();
            userInput.Hours = numericUpDownHours.Value;
            userInput.Miles = numericUpDownMiles.Value;
            userInput.Direction = comboBoxDirection.Text;
            userInput.Mode = textBoxMode.Text;


            // If statment to check if an item is selected in the comboBox
            if (comboBoxDirection.SelectedIndex != 0)
            {
                // New tree node to set properties
                TreeNode node = new TreeNode();
                // Set selectednode to image 7 
                node.Text = userInput.Direction;
                node.SelectedImageIndex = 7;
                // If statement to check the text inside the combo box and set 
                // and image to the new node
                if (comboBoxDirection.Text == "North")
                {
                    node.ImageIndex = 0;
                }
                else if (comboBoxDirection.Text == "East")
                {
                    node.ImageIndex = 1;
                }
                else if (comboBoxDirection.Text == "South")
                {
                    node.ImageIndex = 2;
                }
                else if (comboBoxDirection.Text == "West")
                {
                    node.ImageIndex = 3;
                }
                // New node for miles information
                TreeNode secondNode = new TreeNode();
                secondNode.ImageIndex = 4;
                secondNode.Text = ($"Miles {userInput.Miles}");
                secondNode.SelectedImageIndex = 7;
                // New node for hours
                TreeNode thirdNode = new TreeNode();
                thirdNode.ImageIndex = 5;
                thirdNode.Text = ($"Hours {userInput.Hours}");
                thirdNode.SelectedImageIndex = 7;
                // new node for Mode
                TreeNode fourthNode = new TreeNode();
                fourthNode.ImageIndex = 6;
                fourthNode.Text = ($"Mode {userInput.Mode}");
                fourthNode.SelectedImageIndex = 7;
                // Setting nodes to our first node created
                node.Nodes.Add(secondNode);
                node.Nodes.Add(thirdNode);
                node.Nodes.Add(fourthNode);
                // Adding our parent node to our treeView
                treeView1.Nodes.Add(node);
                // Getting and setting the count of treeView1 nodes and displaying it 
                textBoxLegs.Text = Convert.ToString(treeView1.Nodes.Count);
                // Getting and setting hours. Also displaying it.
                hours += numericUpDownHours.Value;
                textBoxHours.Text = Convert.ToString(hours);
                // Getting and setting Miles. Also displaying it.
                miles += numericUpDownMiles.Value;
                textBoxMiles.Text = Convert.ToString(miles);
                clear();
            }
        }
        // Clearing values when clicked new
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxDirection.SelectedIndex = 0;
            numericUpDownMiles.Value = 0;
            numericUpDownHours.Value = 0;
            treeView1.Nodes.Clear();
            textBoxHours.Clear();
            textBoxLegs.Clear();
            textBoxMode.Clear();
            textBoxMiles.Clear();
            miles = 0;
            hours = 0;
        }

        private void clear()
        {
            numericUpDownHours.Value = 0;
            numericUpDownMiles.Value = 0;
            comboBoxDirection.SelectedIndex = 0;
        }
    }
}