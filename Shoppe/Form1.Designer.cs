namespace Shoppe
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxShoppingList;
        private System.Windows.Forms.Button btnAddItems;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBoxShoppingList = new System.Windows.Forms.ListBox();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxShoppingList
            // 
            this.listBoxShoppingList.FormattingEnabled = true;
            this.listBoxShoppingList.Location = new System.Drawing.Point(12, 12);
            this.listBoxShoppingList.Name = "listBoxShoppingList";
            this.listBoxShoppingList.Size = new System.Drawing.Size(260, 186);
            this.listBoxShoppingList.TabIndex = 0;
            // 
            // btnAddItems
            // 
            this.btnAddItems.Location = new System.Drawing.Point(12, 204);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(260, 23);
            this.btnAddItems.TabIndex = 1;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = true;
            this.btnAddItems.Click += new System.EventHandler(this.btnAddItems_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.listBoxShoppingList);
            this.Name = "Form1";
            this.Text = "Shopping List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }
    }
}