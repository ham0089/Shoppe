using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Shoppe
{
    public partial class Form2 : Form
    {
        private List<string> groceryList = new List<string>();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (groceryList.Count >= 5)
            {
                MessageBox.Show("You can only add up to 5 items.", "Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string item = txtItem.Text.Trim();
            if (!string.IsNullOrEmpty(item))
            {
                groceryList.Add(item);
                listBoxGroceryList.Items.Add(item);
                txtItem.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid item.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string filePath = "shoppinglist.json";
            string json = JsonConvert.SerializeObject(groceryList); // Use JsonConvert.SerializeObject from Newtonsoft.Json
            File.WriteAllText(filePath, json);

            MessageBox.Show("Shopping list saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}