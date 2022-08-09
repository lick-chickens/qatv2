namespace Quick_Access_Toolbar_v2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_categories = new System.Windows.Forms.ListBox();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.lbl_categories = new System.Windows.Forms.Label();
            this.lbl_items = new System.Windows.Forms.Label();
            this.btn_categories_remove = new System.Windows.Forms.Button();
            this.btn_categories_add = new System.Windows.Forms.Button();
            this.btn_items_remove = new System.Windows.Forms.Button();
            this.btn_items_add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_categories
            // 
            this.lb_categories.FormattingEnabled = true;
            this.lb_categories.ItemHeight = 15;
            this.lb_categories.Location = new System.Drawing.Point(12, 66);
            this.lb_categories.Name = "lb_categories";
            this.lb_categories.Size = new System.Drawing.Size(189, 229);
            this.lb_categories.TabIndex = 0;
            this.lb_categories.SelectedIndexChanged += new System.EventHandler(this.lb_categories_SelectedIndexChanged);
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.ItemHeight = 15;
            this.lb_items.Location = new System.Drawing.Point(207, 66);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(189, 229);
            this.lb_items.TabIndex = 1;
            // 
            // lbl_categories
            // 
            this.lbl_categories.AutoSize = true;
            this.lbl_categories.Location = new System.Drawing.Point(12, 48);
            this.lbl_categories.Name = "lbl_categories";
            this.lbl_categories.Size = new System.Drawing.Size(63, 15);
            this.lbl_categories.TabIndex = 2;
            this.lbl_categories.Text = "Categories";
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Location = new System.Drawing.Point(207, 48);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(36, 15);
            this.lbl_items.TabIndex = 3;
            this.lbl_items.Text = "Items";
            // 
            // btn_categories_remove
            // 
            this.btn_categories_remove.Location = new System.Drawing.Point(41, 301);
            this.btn_categories_remove.Name = "btn_categories_remove";
            this.btn_categories_remove.Size = new System.Drawing.Size(23, 23);
            this.btn_categories_remove.TabIndex = 7;
            this.btn_categories_remove.Text = "-";
            this.btn_categories_remove.UseVisualStyleBackColor = true;
            this.btn_categories_remove.Click += new System.EventHandler(this.btn_categories_remove_Click);
            // 
            // btn_categories_add
            // 
            this.btn_categories_add.Location = new System.Drawing.Point(12, 301);
            this.btn_categories_add.Name = "btn_categories_add";
            this.btn_categories_add.Size = new System.Drawing.Size(23, 23);
            this.btn_categories_add.TabIndex = 6;
            this.btn_categories_add.Text = "+";
            this.btn_categories_add.UseVisualStyleBackColor = true;
            this.btn_categories_add.Click += new System.EventHandler(this.btn_categories_add_Click);
            // 
            // btn_items_remove
            // 
            this.btn_items_remove.Location = new System.Drawing.Point(236, 301);
            this.btn_items_remove.Name = "btn_items_remove";
            this.btn_items_remove.Size = new System.Drawing.Size(23, 23);
            this.btn_items_remove.TabIndex = 9;
            this.btn_items_remove.Text = "-";
            this.btn_items_remove.UseVisualStyleBackColor = true;
            this.btn_items_remove.Click += new System.EventHandler(this.btn_items_remove_Click);
            // 
            // btn_items_add
            // 
            this.btn_items_add.Location = new System.Drawing.Point(207, 301);
            this.btn_items_add.Name = "btn_items_add";
            this.btn_items_add.Size = new System.Drawing.Size(23, 23);
            this.btn_items_add.TabIndex = 8;
            this.btn_items_add.Text = "+";
            this.btn_items_add.UseVisualStyleBackColor = true;
            this.btn_items_add.Click += new System.EventHandler(this.btn_items_add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Focus hotkey: F13";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 332);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_items_remove);
            this.Controls.Add(this.btn_items_add);
            this.Controls.Add(this.btn_categories_remove);
            this.Controls.Add(this.btn_categories_add);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.lbl_categories);
            this.Controls.Add(this.lb_items);
            this.Controls.Add(this.lb_categories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QATv2 Settings";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_categories;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.Label lbl_categories;
        private System.Windows.Forms.Label lbl_items;
        private System.Windows.Forms.Button btn_categories_remove;
        private System.Windows.Forms.Button btn_categories_add;
        private System.Windows.Forms.Button btn_items_remove;
        private System.Windows.Forms.Button btn_items_add;
        private System.Windows.Forms.Label label1;
    }
}