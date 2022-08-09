namespace Quick_Access_Toolbar_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pb_expand = new System.Windows.Forms.PictureBox();
            this.lb_category = new System.Windows.Forms.ListBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.lb_items = new System.Windows.Forms.ListBox();
            this.lbl_items = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_expand)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_expand
            // 
            this.pb_expand.BackgroundImage = global::Quick_Access_Toolbar_v2.Properties.Resources.cursor;
            this.pb_expand.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_expand.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.pb_expand.ErrorImage = null;
            this.pb_expand.InitialImage = null;
            this.pb_expand.Location = new System.Drawing.Point(0, 0);
            this.pb_expand.Name = "pb_expand";
            this.pb_expand.Size = new System.Drawing.Size(32, 32);
            this.pb_expand.TabIndex = 0;
            this.pb_expand.TabStop = false;
            this.pb_expand.Click += new System.EventHandler(this.pb_expand_Click);
            // 
            // lb_category
            // 
            this.lb_category.FormattingEnabled = true;
            this.lb_category.ItemHeight = 15;
            this.lb_category.Location = new System.Drawing.Point(0, 38);
            this.lb_category.Name = "lb_category";
            this.lb_category.Size = new System.Drawing.Size(157, 244);
            this.lb_category.TabIndex = 1;
            this.lb_category.SelectedIndexChanged += new System.EventHandler(this.lb_category_SelectedIndexChanged);
            this.lb_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_category_KeyDown);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(38, 5);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(119, 23);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.TabStop = false;
            this.btn_settings.Text = "Settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // lb_items
            // 
            this.lb_items.FormattingEnabled = true;
            this.lb_items.ItemHeight = 15;
            this.lb_items.Location = new System.Drawing.Point(163, 38);
            this.lb_items.Name = "lb_items";
            this.lb_items.Size = new System.Drawing.Size(214, 244);
            this.lb_items.TabIndex = 3;
            this.lb_items.DoubleClick += new System.EventHandler(this.lb_items_DoubleClick);
            this.lb_items.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb_items_KeyDown);
            // 
            // lbl_items
            // 
            this.lbl_items.AutoSize = true;
            this.lbl_items.Location = new System.Drawing.Point(254, 20);
            this.lbl_items.Name = "lbl_items";
            this.lbl_items.Size = new System.Drawing.Size(36, 15);
            this.lbl_items.TabIndex = 4;
            this.lbl_items.Text = "Items";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(378, 284);
            this.Controls.Add(this.lbl_items);
            this.Controls.Add(this.lb_items);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.lb_category);
            this.Controls.Add(this.pb_expand);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pb_expand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_expand;
        private System.Windows.Forms.ListBox lb_category;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.ListBox lb_items;
        private System.Windows.Forms.Label lbl_items;
    }
}
