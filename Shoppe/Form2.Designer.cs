namespace Shoppe
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxGroceryList;

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
            this.txtItem = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxGroceryList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(12, 12);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(260, 20);
            this.txtItem.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(260, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 204);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(260, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save List";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxGroceryList
            // 
            this.listBoxGroceryList.FormattingEnabled = true;
            this.listBoxGroceryList.Location = new System.Drawing.Point(12, 67);
            this.listBoxGroceryList.Name = "listBoxGroceryList";
            this.listBoxGroceryList.Size = new System.Drawing.Size(260, 121);
            this.listBoxGroceryList.TabIndex = 3;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(284, 241);
            this.Controls.Add(this.listBoxGroceryList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtItem);
            this.Name = "Form2";
            this.Text = "Add Grocery Items";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}