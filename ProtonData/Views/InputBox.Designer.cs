namespace ProtonData.Views
{
    partial class InputBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputBox));
            this.column = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.chktable = new System.Windows.Forms.CheckBox();
            this.btnadd = new MetroFramework.Controls.MetroButton();
            this.cbocolumns = new System.Windows.Forms.CheckBox();
            this.columnname = new System.Windows.Forms.TextBox();
            this.lblcolname = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txttablename = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // column
            // 
            this.column.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.column.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.column.Enabled = false;
            this.column.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.column.Location = new System.Drawing.Point(7, 100);
            this.column.Multiline = true;
            this.column.Name = "column";
            this.column.Size = new System.Drawing.Size(637, 273);
            this.column.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Table Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.metroButton5);
            this.panel2.Controls.Add(this.column);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(658, 444);
            this.panel2.TabIndex = 6;
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(451, 385);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(193, 47);
            this.metroButton5.TabIndex = 10;
            this.metroButton5.Text = "Complete";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel5.Controls.Add(this.chktable);
            this.panel5.Controls.Add(this.btnadd);
            this.panel5.Controls.Add(this.cbocolumns);
            this.panel5.Controls.Add(this.columnname);
            this.panel5.Controls.Add(this.lblcolname);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(658, 42);
            this.panel5.TabIndex = 8;
            // 
            // chktable
            // 
            this.chktable.AutoSize = true;
            this.chktable.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chktable.Location = new System.Drawing.Point(12, 10);
            this.chktable.Name = "chktable";
            this.chktable.Size = new System.Drawing.Size(100, 21);
            this.chktable.TabIndex = 5;
            this.chktable.Text = "Create Table";
            this.chktable.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(566, 8);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(78, 23);
            this.btnadd.TabIndex = 4;
            this.btnadd.Text = "Add";
            this.btnadd.UseSelectable = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbocolumns
            // 
            this.cbocolumns.AutoSize = true;
            this.cbocolumns.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocolumns.Location = new System.Drawing.Point(118, 10);
            this.cbocolumns.Name = "cbocolumns";
            this.cbocolumns.Size = new System.Drawing.Size(110, 21);
            this.cbocolumns.TabIndex = 3;
            this.cbocolumns.Text = "Excel Columns";
            this.cbocolumns.UseVisualStyleBackColor = true;
            this.cbocolumns.CheckedChanged += new System.EventHandler(this.cbocolumns_CheckedChanged);
            // 
            // columnname
            // 
            this.columnname.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnname.Location = new System.Drawing.Point(363, 9);
            this.columnname.Name = "columnname";
            this.columnname.Size = new System.Drawing.Size(197, 22);
            this.columnname.TabIndex = 2;
            // 
            // lblcolname
            // 
            this.lblcolname.AutoSize = true;
            this.lblcolname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcolname.Location = new System.Drawing.Point(232, 11);
            this.lblcolname.Name = "lblcolname";
            this.lblcolname.Size = new System.Drawing.Size(129, 17);
            this.lblcolname.TabIndex = 1;
            this.lblcolname.Text = "Enter Column  Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.txttablename);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 52);
            this.panel3.TabIndex = 6;
            // 
            // txttablename
            // 
            this.txttablename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttablename.Location = new System.Drawing.Point(96, 21);
            this.txttablename.Name = "txttablename";
            this.txttablename.Size = new System.Drawing.Size(548, 22);
            this.txttablename.TabIndex = 3;
            // 
            // InputBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 444);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InputBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Table Settings";
            this.Load += new System.EventHandler(this.InputBox_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox column;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.CheckBox chktable;
        private MetroFramework.Controls.MetroButton btnadd;
        private System.Windows.Forms.CheckBox cbocolumns;
        private System.Windows.Forms.TextBox columnname;
        private System.Windows.Forms.Label lblcolname;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txttablename;
        private MetroFramework.Controls.MetroButton metroButton5;
    }
}