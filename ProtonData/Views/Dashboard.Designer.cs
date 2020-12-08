namespace ProtonData.Views
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.import = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblfilesize = new MetroFramework.Controls.MetroLabel();
            this.lblfilename = new MetroFramework.Controls.MetroLabel();
            this.lblrows = new MetroFramework.Controls.MetroLabel();
            this.lblcolumns = new MetroFramework.Controls.MetroLabel();
            this.exceldata = new System.Windows.Forms.DataGridView();
            this.export = new MetroFramework.Controls.MetroTabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sqleditor = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metroButton6 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblformat = new MetroFramework.Controls.MetroLabel();
            this.lbllines = new MetroFramework.Controls.MetroLabel();
            this.setings = new MetroFramework.Controls.MetroTabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtport = new System.Windows.Forms.TextBox();
            this.txtserver = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.import.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exceldata)).BeginInit();
            this.export.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.setings.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 94);
            this.panel1.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(170, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Convert Excel to MySQL ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proton Data Manager";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.import);
            this.metroTabControl1.Controls.Add(this.export);
            this.metroTabControl1.Controls.Add(this.setings);
            this.metroTabControl1.Location = new System.Drawing.Point(7, 103);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(827, 432);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTabControl1.UseSelectable = true;
            // 
            // import
            // 
            this.import.Controls.Add(this.panel2);
            this.import.HorizontalScrollbarBarColor = true;
            this.import.HorizontalScrollbarHighlightOnWheel = false;
            this.import.HorizontalScrollbarSize = 10;
            this.import.Location = new System.Drawing.Point(4, 38);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(819, 390);
            this.import.TabIndex = 0;
            this.import.Text = "Import From Excel";
            this.import.VerticalScrollbarBarColor = true;
            this.import.VerticalScrollbarHighlightOnWheel = false;
            this.import.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.exceldata);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(819, 390);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.metroButton2);
            this.panel3.Controls.Add(this.metroButton1);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(217, 390);
            this.panel3.TabIndex = 3;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(23, 72);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(181, 47);
            this.metroButton2.TabIndex = 2;
            this.metroButton2.Text = "Clear/Reset";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(23, 25);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(181, 41);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Browse ...";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblfilesize);
            this.groupBox1.Controls.Add(this.lblfilename);
            this.groupBox1.Controls.Add(this.lblrows);
            this.groupBox1.Controls.Add(this.lblcolumns);
            this.groupBox1.Location = new System.Drawing.Point(23, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lblfilesize
            // 
            this.lblfilesize.AutoSize = true;
            this.lblfilesize.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblfilesize.ForeColor = System.Drawing.Color.Black;
            this.lblfilesize.Location = new System.Drawing.Point(21, 73);
            this.lblfilesize.Name = "lblfilesize";
            this.lblfilesize.Size = new System.Drawing.Size(61, 19);
            this.lblfilesize.TabIndex = 3;
            this.lblfilesize.Text = "File size";
            // 
            // lblfilename
            // 
            this.lblfilename.AutoSize = true;
            this.lblfilename.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblfilename.ForeColor = System.Drawing.Color.Black;
            this.lblfilename.Location = new System.Drawing.Point(21, 45);
            this.lblfilename.Name = "lblfilename";
            this.lblfilename.Size = new System.Drawing.Size(73, 19);
            this.lblfilename.TabIndex = 2;
            this.lblfilename.Text = "File name";
            // 
            // lblrows
            // 
            this.lblrows.AutoSize = true;
            this.lblrows.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblrows.ForeColor = System.Drawing.Color.Black;
            this.lblrows.Location = new System.Drawing.Point(21, 131);
            this.lblrows.Name = "lblrows";
            this.lblrows.Size = new System.Drawing.Size(44, 19);
            this.lblrows.TabIndex = 1;
            this.lblrows.Text = "Rows";
            // 
            // lblcolumns
            // 
            this.lblcolumns.AutoSize = true;
            this.lblcolumns.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblcolumns.ForeColor = System.Drawing.Color.Black;
            this.lblcolumns.Location = new System.Drawing.Point(21, 103);
            this.lblcolumns.Name = "lblcolumns";
            this.lblcolumns.Size = new System.Drawing.Size(66, 19);
            this.lblcolumns.TabIndex = 0;
            this.lblcolumns.Text = "Columns";
            // 
            // exceldata
            // 
            this.exceldata.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.exceldata.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.exceldata.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.exceldata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.exceldata.BackgroundColor = System.Drawing.Color.White;
            this.exceldata.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.exceldata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.exceldata.Location = new System.Drawing.Point(223, 15);
            this.exceldata.Name = "exceldata";
            this.exceldata.ReadOnly = true;
            this.exceldata.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.exceldata.Size = new System.Drawing.Size(593, 372);
            this.exceldata.TabIndex = 2;
            this.exceldata.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.exceldata_RowsAdded);
            // 
            // export
            // 
            this.export.Controls.Add(this.panel4);
            this.export.HorizontalScrollbarBarColor = true;
            this.export.HorizontalScrollbarHighlightOnWheel = false;
            this.export.HorizontalScrollbarSize = 10;
            this.export.Location = new System.Drawing.Point(4, 38);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(819, 390);
            this.export.TabIndex = 1;
            this.export.Text = "Convert to SQL";
            this.export.VerticalScrollbarBarColor = true;
            this.export.VerticalScrollbarHighlightOnWheel = false;
            this.export.VerticalScrollbarSize = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.sqleditor);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(819, 390);
            this.panel4.TabIndex = 2;
            // 
            // sqleditor
            // 
            this.sqleditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqleditor.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqleditor.Location = new System.Drawing.Point(227, 11);
            this.sqleditor.Multiline = true;
            this.sqleditor.Name = "sqleditor";
            this.sqleditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.sqleditor.Size = new System.Drawing.Size(575, 360);
            this.sqleditor.TabIndex = 5;
            this.sqleditor.Text = "SQL QUERY HERE";
            this.sqleditor.TextChanged += new System.EventHandler(this.sqleditor_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.metroButton6);
            this.panel5.Controls.Add(this.metroButton5);
            this.panel5.Controls.Add(this.metroButton3);
            this.panel5.Controls.Add(this.metroButton4);
            this.panel5.Controls.Add(this.groupBox2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(217, 390);
            this.panel5.TabIndex = 4;
            // 
            // metroButton6
            // 
            this.metroButton6.Location = new System.Drawing.Point(21, 129);
            this.metroButton6.Name = "metroButton6";
            this.metroButton6.Size = new System.Drawing.Size(183, 47);
            this.metroButton6.TabIndex = 4;
            this.metroButton6.Text = "Run Query";
            this.metroButton6.UseSelectable = true;
            this.metroButton6.Click += new System.EventHandler(this.metroButton6_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(21, 190);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(183, 47);
            this.metroButton5.TabIndex = 3;
            this.metroButton5.Text = "Clear/Reset";
            this.metroButton5.UseSelectable = true;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(21, 72);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(183, 47);
            this.metroButton3.TabIndex = 2;
            this.metroButton3.Text = "Save SQL";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.Color.White;
            this.metroButton4.Location = new System.Drawing.Point(21, 25);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(183, 41);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.TabIndex = 1;
            this.metroButton4.Text = "Generate SQL";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lblformat);
            this.groupBox2.Controls.Add(this.lbllines);
            this.groupBox2.Location = new System.Drawing.Point(21, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 144);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // lblformat
            // 
            this.lblformat.AutoSize = true;
            this.lblformat.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblformat.ForeColor = System.Drawing.Color.Black;
            this.lblformat.Location = new System.Drawing.Point(21, 73);
            this.lblformat.Name = "lblformat";
            this.lblformat.Size = new System.Drawing.Size(91, 19);
            this.lblformat.TabIndex = 3;
            this.lblformat.Text = "Format .SQL";
            // 
            // lbllines
            // 
            this.lbllines.AutoSize = true;
            this.lbllines.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbllines.ForeColor = System.Drawing.Color.Black;
            this.lbllines.Location = new System.Drawing.Point(21, 45);
            this.lbllines.Name = "lbllines";
            this.lbllines.Size = new System.Drawing.Size(46, 19);
            this.lbllines.TabIndex = 2;
            this.lbllines.Text = "Chars";
            // 
            // setings
            // 
            this.setings.Controls.Add(this.panel6);
            this.setings.HorizontalScrollbarBarColor = true;
            this.setings.HorizontalScrollbarHighlightOnWheel = false;
            this.setings.HorizontalScrollbarSize = 10;
            this.setings.Location = new System.Drawing.Point(4, 38);
            this.setings.Name = "setings";
            this.setings.Size = new System.Drawing.Size(819, 390);
            this.setings.TabIndex = 3;
            this.setings.Text = "Database Settings";
            this.setings.VerticalScrollbarBarColor = true;
            this.setings.VerticalScrollbarHighlightOnWheel = false;
            this.setings.VerticalScrollbarSize = 10;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Controls.Add(this.groupBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(819, 390);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel7.Controls.Add(this.button3);
            this.panel7.Controls.Add(this.button1);
            this.panel7.Controls.Add(this.button2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 344);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(819, 46);
            this.panel7.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(15, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 39);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 39);
            this.button2.TabIndex = 9;
            this.button2.Text = "Default";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtdatabase);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtpassword);
            this.groupBox3.Controls.Add(this.txtusername);
            this.groupBox3.Controls.Add(this.txtport);
            this.groupBox3.Controls.Add(this.txtserver);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(379, 295);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "MySQL Server Credentials";
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(105, 200);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(238, 25);
            this.txtdatabase.TabIndex = 9;
            this.txtdatabase.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Database";
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(105, 160);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(238, 25);
            this.txtpassword.TabIndex = 7;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(105, 120);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(238, 25);
            this.txtusername.TabIndex = 6;
            this.txtusername.Text = "root";
            // 
            // txtport
            // 
            this.txtport.Location = new System.Drawing.Point(105, 81);
            this.txtport.Name = "txtport";
            this.txtport.Size = new System.Drawing.Size(238, 25);
            this.txtport.TabIndex = 5;
            this.txtport.Text = "3306";
            // 
            // txtserver
            // 
            this.txtserver.Location = new System.Drawing.Point(105, 42);
            this.txtserver.Name = "txtserver";
            this.txtserver.Size = new System.Drawing.Size(238, 25);
            this.txtserver.TabIndex = 4;
            this.txtserver.Text = "localhost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 3;
            this.label5.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Server";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(846, 547);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Dashboard_FormClosed);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.import.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exceldata)).EndInit();
            this.export.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.setings.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage import;
        private MetroFramework.Controls.MetroTabPage export;
        private MetroFramework.Controls.MetroTabPage setings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView exceldata;
        private System.Windows.Forms.Panel panel3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lblfilesize;
        private MetroFramework.Controls.MetroLabel lblfilename;
        private MetroFramework.Controls.MetroLabel lblrows;
        private MetroFramework.Controls.MetroLabel lblcolumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private MetroFramework.Controls.MetroButton metroButton5;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton4;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel lblformat;
        private MetroFramework.Controls.MetroLabel lbllines;
        private System.Windows.Forms.TextBox sqleditor;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtport;
        private System.Windows.Forms.TextBox txtserver;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private MetroFramework.Controls.MetroButton metroButton6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}