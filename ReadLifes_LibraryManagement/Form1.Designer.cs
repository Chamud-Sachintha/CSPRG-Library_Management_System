namespace ReadLifes_LibraryManagement
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.side_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bookrent_btn = new System.Windows.Forms.Button();
            this.memreg_btn = new System.Windows.Forms.Button();
            this.bookmgmt_btn = new System.Windows.Forms.Button();
            this.suplierreg_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exit_btn = new System.Windows.Forms.Button();
            this.minimize_btn = new System.Windows.Forms.Button();
            this.suppliermgmt_form1 = new ReadLifes_LibraryManagement.Suppliermgmt_form();
            this.bookMgmt1 = new ReadLifes_LibraryManagement.BookMgmt();
            this.bookRent_Form1 = new ReadLifes_LibraryManagement.BookRent_Form();
            this.memberMgmt_Form1 = new ReadLifes_LibraryManagement.MemberMgmt_Form();
            this.dashboardForm1 = new ReadLifes_LibraryManagement.DashboardForm();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.side_panel);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.bookrent_btn);
            this.panel1.Controls.Add(this.memreg_btn);
            this.panel1.Controls.Add(this.bookmgmt_btn);
            this.panel1.Controls.Add(this.suplierreg_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 599);
            this.panel1.TabIndex = 0;
            // 
            // side_panel
            // 
            this.side_panel.BackColor = System.Drawing.Color.Gold;
            this.side_panel.Location = new System.Drawing.Point(3, 124);
            this.side_panel.Name = "side_panel";
            this.side_panel.Size = new System.Drawing.Size(10, 44);
            this.side_panel.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(59, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(119, 99);
            this.panel3.TabIndex = 5;
            // 
            // bookrent_btn
            // 
            this.bookrent_btn.FlatAppearance.BorderSize = 0;
            this.bookrent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookrent_btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookrent_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookrent_btn.Image")));
            this.bookrent_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookrent_btn.Location = new System.Drawing.Point(13, 227);
            this.bookrent_btn.Name = "bookrent_btn";
            this.bookrent_btn.Size = new System.Drawing.Size(231, 46);
            this.bookrent_btn.TabIndex = 4;
            this.bookrent_btn.Text = "             Book Rent Mgmt.";
            this.bookrent_btn.UseVisualStyleBackColor = true;
            this.bookrent_btn.Click += new System.EventHandler(this.bookrent_btn_Click);
            // 
            // memreg_btn
            // 
            this.memreg_btn.FlatAppearance.BorderSize = 0;
            this.memreg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memreg_btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memreg_btn.Image = ((System.Drawing.Image)(resources.GetObject("memreg_btn.Image")));
            this.memreg_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.memreg_btn.Location = new System.Drawing.Point(13, 175);
            this.memreg_btn.Name = "memreg_btn";
            this.memreg_btn.Size = new System.Drawing.Size(231, 46);
            this.memreg_btn.TabIndex = 3;
            this.memreg_btn.Text = "         Member Mgmt.";
            this.memreg_btn.UseVisualStyleBackColor = true;
            this.memreg_btn.Click += new System.EventHandler(this.memreg_btn_Click);
            // 
            // bookmgmt_btn
            // 
            this.bookmgmt_btn.FlatAppearance.BorderSize = 0;
            this.bookmgmt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookmgmt_btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookmgmt_btn.Image = ((System.Drawing.Image)(resources.GetObject("bookmgmt_btn.Image")));
            this.bookmgmt_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookmgmt_btn.Location = new System.Drawing.Point(13, 275);
            this.bookmgmt_btn.Name = "bookmgmt_btn";
            this.bookmgmt_btn.Size = new System.Drawing.Size(229, 46);
            this.bookmgmt_btn.TabIndex = 2;
            this.bookmgmt_btn.Text = "   Book Mgmt.";
            this.bookmgmt_btn.UseVisualStyleBackColor = true;
            this.bookmgmt_btn.Click += new System.EventHandler(this.bookmgmt_btn_Click);
            // 
            // suplierreg_btn
            // 
            this.suplierreg_btn.FlatAppearance.BorderSize = 0;
            this.suplierreg_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suplierreg_btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suplierreg_btn.Image = ((System.Drawing.Image)(resources.GetObject("suplierreg_btn.Image")));
            this.suplierreg_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.suplierreg_btn.Location = new System.Drawing.Point(13, 327);
            this.suplierreg_btn.Name = "suplierreg_btn";
            this.suplierreg_btn.Size = new System.Drawing.Size(234, 46);
            this.suplierreg_btn.TabIndex = 1;
            this.suplierreg_btn.Text = "      Suplier Mgmt.";
            this.suplierreg_btn.UseVisualStyleBackColor = true;
            this.suplierreg_btn.Click += new System.EventHandler(this.suplierreg_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.FlatAppearance.BorderSize = 0;
            this.dashboard_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Uighur", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Image = ((System.Drawing.Image)(resources.GetObject("dashboard_btn.Image")));
            this.dashboard_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboard_btn.Location = new System.Drawing.Point(13, 123);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(234, 46);
            this.dashboard_btn.TabIndex = 0;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Location = new System.Drawing.Point(246, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 23);
            this.panel2.TabIndex = 1;
            // 
            // exit_btn
            // 
            this.exit_btn.FlatAppearance.BorderSize = 0;
            this.exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_btn.Image = ((System.Drawing.Image)(resources.GetObject("exit_btn.Image")));
            this.exit_btn.Location = new System.Drawing.Point(1023, 23);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(31, 30);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // minimize_btn
            // 
            this.minimize_btn.FlatAppearance.BorderSize = 0;
            this.minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_btn.Image")));
            this.minimize_btn.Location = new System.Drawing.Point(986, 23);
            this.minimize_btn.Name = "minimize_btn";
            this.minimize_btn.Size = new System.Drawing.Size(31, 30);
            this.minimize_btn.TabIndex = 3;
            this.minimize_btn.UseVisualStyleBackColor = true;
            this.minimize_btn.Click += new System.EventHandler(this.minimize_btn_Click);
            // 
            // suppliermgmt_form1
            // 
            this.suppliermgmt_form1.BackColor = System.Drawing.Color.LemonChiffon;
            this.suppliermgmt_form1.Location = new System.Drawing.Point(246, 76);
            this.suppliermgmt_form1.Name = "suppliermgmt_form1";
            this.suppliermgmt_form1.Size = new System.Drawing.Size(802, 434);
            this.suppliermgmt_form1.TabIndex = 8;
            // 
            // bookMgmt1
            // 
            this.bookMgmt1.BackColor = System.Drawing.Color.Honeydew;
            this.bookMgmt1.Location = new System.Drawing.Point(246, 76);
            this.bookMgmt1.Name = "bookMgmt1";
            this.bookMgmt1.Size = new System.Drawing.Size(817, 434);
            this.bookMgmt1.TabIndex = 7;
            // 
            // bookRent_Form1
            // 
            this.bookRent_Form1.BackColor = System.Drawing.Color.MintCream;
            this.bookRent_Form1.Location = new System.Drawing.Point(246, 76);
            this.bookRent_Form1.Name = "bookRent_Form1";
            this.bookRent_Form1.Size = new System.Drawing.Size(815, 434);
            this.bookRent_Form1.TabIndex = 6;
            // 
            // memberMgmt_Form1
            // 
            this.memberMgmt_Form1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.memberMgmt_Form1.Location = new System.Drawing.Point(246, 76);
            this.memberMgmt_Form1.Name = "memberMgmt_Form1";
            this.memberMgmt_Form1.Size = new System.Drawing.Size(797, 434);
            this.memberMgmt_Form1.TabIndex = 5;
            // 
            // dashboardForm1
            // 
            this.dashboardForm1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dashboardForm1.Location = new System.Drawing.Point(247, 76);
            this.dashboardForm1.Name = "dashboardForm1";
            this.dashboardForm1.Size = new System.Drawing.Size(814, 434);
            this.dashboardForm1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 598);
            this.Controls.Add(this.suppliermgmt_form1);
            this.Controls.Add(this.bookMgmt1);
            this.Controls.Add(this.bookRent_Form1);
            this.Controls.Add(this.memberMgmt_Form1);
            this.Controls.Add(this.dashboardForm1);
            this.Controls.Add(this.minimize_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReadLifes Libraries";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button suplierreg_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button memreg_btn;
        private System.Windows.Forms.Button bookmgmt_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button bookrent_btn;
        private System.Windows.Forms.Button minimize_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel side_panel;
        private DashboardForm dashboardForm1;
        private MemberMgmt_Form memberMgmt_Form1;
        private BookRent_Form bookRent_Form1;
        private BookMgmt bookMgmt1;
        private Suppliermgmt_form suppliermgmt_form1;
    }
}

