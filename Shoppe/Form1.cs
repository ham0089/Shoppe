using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoppe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadShoppingList();
        }

        private void LoadShoppingList()
        {
            string filePath = "shoppinglist.json";

            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                List<string> shoppingList = JsonConvert.DeserializeObject<List<string>>(json); // Use JsonConvert

                listBoxShoppingList.Items.Clear();
                foreach (var item in shoppingList)
                {
                    listBoxShoppingList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("No shopping list found. Please add items using the Add Items form.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            Form2 addItemsForm = new Form2();
            addItemsForm.ShowDialog();
            LoadShoppingList(); // Reload the list after adding items
        }
    }
}
