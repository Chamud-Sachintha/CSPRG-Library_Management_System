namespace ReadLifes_LibraryManagement
{
    partial class BookRent_Form
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRent_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchrent_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.memid_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.no_of_books_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bookid1_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bookid2_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rentconfirm_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reset_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bookid3_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chkrent_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deleterent_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(468, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Searching";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Renting";
            // 
            // searchrent_txt
            // 
            this.searchrent_txt.BorderColorFocused = System.Drawing.Color.Green;
            this.searchrent_txt.BorderColorIdle = System.Drawing.Color.Orange;
            this.searchrent_txt.BorderColorMouseHover = System.Drawing.Color.Green;
            this.searchrent_txt.BorderThickness = 3;
            this.searchrent_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchrent_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchrent_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchrent_txt.isPassword = false;
            this.searchrent_txt.Location = new System.Drawing.Point(455, 112);
            this.searchrent_txt.Margin = new System.Windows.Forms.Padding(4);
            this.searchrent_txt.Name = "searchrent_txt";
            this.searchrent_txt.Size = new System.Drawing.Size(337, 44);
            this.searchrent_txt.TabIndex = 3;
            this.searchrent_txt.Text = "Search ID";
            this.searchrent_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchrent_txt.Enter += new System.EventHandler(this.searchrent_txt_Enter);
            this.searchrent_txt.Leave += new System.EventHandler(this.searchrent_txt_Leave);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 15;
            this.bunifuSeparator1.Location = new System.Drawing.Point(408, 58);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(50, 323);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Transparency = 50;
            this.bunifuSeparator1.Vertical = true;
            // 
            // memid_txt
            // 
            this.memid_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.memid_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.memid_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.memid_txt.HintForeColor = System.Drawing.Color.Empty;
            this.memid_txt.HintText = "Member ID";
            this.memid_txt.isPassword = false;
            this.memid_txt.LineFocusedColor = System.Drawing.Color.Green;
            this.memid_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.memid_txt.LineMouseHoverColor = System.Drawing.Color.Green;
            this.memid_txt.LineThickness = 3;
            this.memid_txt.Location = new System.Drawing.Point(38, 112);
            this.memid_txt.Margin = new System.Windows.Forms.Padding(4);
            this.memid_txt.Name = "memid_txt";
            this.memid_txt.Size = new System.Drawing.Size(379, 33);
            this.memid_txt.TabIndex = 6;
            this.memid_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // no_of_books_txt
            // 
            this.no_of_books_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.no_of_books_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.no_of_books_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.no_of_books_txt.HintForeColor = System.Drawing.Color.Empty;
            this.no_of_books_txt.HintText = "No.Of Books";
            this.no_of_books_txt.isPassword = false;
            this.no_of_books_txt.LineFocusedColor = System.Drawing.Color.Green;
            this.no_of_books_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.no_of_books_txt.LineMouseHoverColor = System.Drawing.Color.Green;
            this.no_of_books_txt.LineThickness = 3;
            this.no_of_books_txt.Location = new System.Drawing.Point(38, 153);
            this.no_of_books_txt.Margin = new System.Windows.Forms.Padding(4);
            this.no_of_books_txt.Name = "no_of_books_txt";
            this.no_of_books_txt.Size = new System.Drawing.Size(379, 33);
            this.no_of_books_txt.TabIndex = 7;
            this.no_of_books_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.no_of_books_txt.OnValueChanged += new System.EventHandler(this.no_of_books_txt_OnValueChanged);
            // 
            // bookid1_txt
            // 
            this.bookid1_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookid1_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookid1_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookid1_txt.HintForeColor = System.Drawing.Color.Empty;
            this.bookid1_txt.HintText = "Book ID";
            this.bookid1_txt.isPassword = false;
            this.bookid1_txt.LineFocusedColor = System.Drawing.Color.Green;
            this.bookid1_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.bookid1_txt.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bookid1_txt.LineThickness = 3;
            this.bookid1_txt.Location = new System.Drawing.Point(38, 194);
            this.bookid1_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bookid1_txt.Name = "bookid1_txt";
            this.bookid1_txt.Size = new System.Drawing.Size(379, 33);
            this.bookid1_txt.TabIndex = 8;
            this.bookid1_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bookid2_txt
            // 
            this.bookid2_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookid2_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookid2_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookid2_txt.HintForeColor = System.Drawing.Color.Empty;
            this.bookid2_txt.HintText = "Book ID";
            this.bookid2_txt.isPassword = false;
            this.bookid2_txt.LineFocusedColor = System.Drawing.Color.Green;
            this.bookid2_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.bookid2_txt.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bookid2_txt.LineThickness = 3;
            this.bookid2_txt.Location = new System.Drawing.Point(38, 235);
            this.bookid2_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bookid2_txt.Name = "bookid2_txt";
            this.bookid2_txt.Size = new System.Drawing.Size(379, 33);
            this.bookid2_txt.TabIndex = 9;
            this.bookid2_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rentconfirm_btn
            // 
            this.rentconfirm_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rentconfirm_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rentconfirm_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rentconfirm_btn.BorderRadius = 0;
            this.rentconfirm_btn.ButtonText = "Confirm Rent";
            this.rentconfirm_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rentconfirm_btn.DisabledColor = System.Drawing.Color.Gray;
            this.rentconfirm_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.rentconfirm_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("rentconfirm_btn.Iconimage")));
            this.rentconfirm_btn.Iconimage_right = null;
            this.rentconfirm_btn.Iconimage_right_Selected = null;
            this.rentconfirm_btn.Iconimage_Selected = null;
            this.rentconfirm_btn.IconMarginLeft = 0;
            this.rentconfirm_btn.IconMarginRight = 0;
            this.rentconfirm_btn.IconRightVisible = true;
            this.rentconfirm_btn.IconRightZoom = 0D;
            this.rentconfirm_btn.IconVisible = true;
            this.rentconfirm_btn.IconZoom = 90D;
            this.rentconfirm_btn.IsTab = false;
            this.rentconfirm_btn.Location = new System.Drawing.Point(4, 350);
            this.rentconfirm_btn.Name = "rentconfirm_btn";
            this.rentconfirm_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.rentconfirm_btn.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.rentconfirm_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.rentconfirm_btn.selected = false;
            this.rentconfirm_btn.Size = new System.Drawing.Size(169, 48);
            this.rentconfirm_btn.TabIndex = 10;
            this.rentconfirm_btn.Text = "Confirm Rent";
            this.rentconfirm_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rentconfirm_btn.Textcolor = System.Drawing.Color.White;
            this.rentconfirm_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentconfirm_btn.Click += new System.EventHandler(this.rentconfirm_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_btn.BorderRadius = 0;
            this.reset_btn.ButtonText = "   Reset Fields";
            this.reset_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reset_btn.DisabledColor = System.Drawing.Color.Gray;
            this.reset_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.reset_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("reset_btn.Iconimage")));
            this.reset_btn.Iconimage_right = null;
            this.reset_btn.Iconimage_right_Selected = null;
            this.reset_btn.Iconimage_Selected = null;
            this.reset_btn.IconMarginLeft = 0;
            this.reset_btn.IconMarginRight = 0;
            this.reset_btn.IconRightVisible = true;
            this.reset_btn.IconRightZoom = 0D;
            this.reset_btn.IconVisible = true;
            this.reset_btn.IconZoom = 45D;
            this.reset_btn.IsTab = false;
            this.reset_btn.Location = new System.Drawing.Point(223, 350);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.reset_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reset_btn.selected = false;
            this.reset_btn.Size = new System.Drawing.Size(169, 48);
            this.reset_btn.TabIndex = 11;
            this.reset_btn.Text = "   Reset Fields";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Textcolor = System.Drawing.Color.White;
            this.reset_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // bookid3_txt
            // 
            this.bookid3_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookid3_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookid3_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookid3_txt.HintForeColor = System.Drawing.Color.Empty;
            this.bookid3_txt.HintText = "Book ID";
            this.bookid3_txt.isPassword = false;
            this.bookid3_txt.LineFocusedColor = System.Drawing.Color.Green;
            this.bookid3_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.bookid3_txt.LineMouseHoverColor = System.Drawing.Color.Green;
            this.bookid3_txt.LineThickness = 3;
            this.bookid3_txt.Location = new System.Drawing.Point(38, 276);
            this.bookid3_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bookid3_txt.Name = "bookid3_txt";
            this.bookid3_txt.Size = new System.Drawing.Size(379, 33);
            this.bookid3_txt.TabIndex = 12;
            this.bookid3_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // chkrent_btn
            // 
            this.chkrent_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chkrent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chkrent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkrent_btn.BorderRadius = 0;
            this.chkrent_btn.ButtonText = "      C H E C K   R E N T";
            this.chkrent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkrent_btn.DisabledColor = System.Drawing.Color.Gray;
            this.chkrent_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.chkrent_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("chkrent_btn.Iconimage")));
            this.chkrent_btn.Iconimage_right = null;
            this.chkrent_btn.Iconimage_right_Selected = null;
            this.chkrent_btn.Iconimage_Selected = null;
            this.chkrent_btn.IconMarginLeft = 0;
            this.chkrent_btn.IconMarginRight = 0;
            this.chkrent_btn.IconRightVisible = true;
            this.chkrent_btn.IconRightZoom = 0D;
            this.chkrent_btn.IconVisible = true;
            this.chkrent_btn.IconZoom = 45D;
            this.chkrent_btn.IsTab = false;
            this.chkrent_btn.Location = new System.Drawing.Point(455, 194);
            this.chkrent_btn.Name = "chkrent_btn";
            this.chkrent_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chkrent_btn.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.chkrent_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.chkrent_btn.selected = false;
            this.chkrent_btn.Size = new System.Drawing.Size(337, 48);
            this.chkrent_btn.TabIndex = 13;
            this.chkrent_btn.Text = "      C H E C K   R E N T";
            this.chkrent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkrent_btn.Textcolor = System.Drawing.Color.White;
            this.chkrent_btn.TextFont = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkrent_btn.Click += new System.EventHandler(this.chkrent_btn_Click);
            // 
            // deleterent_btn
            // 
            this.deleterent_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleterent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleterent_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deleterent_btn.BorderRadius = 0;
            this.deleterent_btn.ButtonText = " D E L E T E   R E N T   Q U E R Y";
            this.deleterent_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleterent_btn.DisabledColor = System.Drawing.Color.Gray;
            this.deleterent_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.deleterent_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deleterent_btn.Iconimage")));
            this.deleterent_btn.Iconimage_right = null;
            this.deleterent_btn.Iconimage_right_Selected = null;
            this.deleterent_btn.Iconimage_Selected = null;
            this.deleterent_btn.IconMarginLeft = 0;
            this.deleterent_btn.IconMarginRight = 0;
            this.deleterent_btn.IconRightVisible = true;
            this.deleterent_btn.IconRightZoom = 0D;
            this.deleterent_btn.IconVisible = true;
            this.deleterent_btn.IconZoom = 45D;
            this.deleterent_btn.IsTab = false;
            this.deleterent_btn.Location = new System.Drawing.Point(455, 276);
            this.deleterent_btn.Name = "deleterent_btn";
            this.deleterent_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deleterent_btn.OnHovercolor = System.Drawing.Color.Goldenrod;
            this.deleterent_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.deleterent_btn.selected = false;
            this.deleterent_btn.Size = new System.Drawing.Size(337, 48);
            this.deleterent_btn.TabIndex = 14;
            this.deleterent_btn.Text = " D E L E T E   R E N T   Q U E R Y";
            this.deleterent_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleterent_btn.Textcolor = System.Drawing.Color.White;
            this.deleterent_btn.TextFont = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Bold);
            this.deleterent_btn.Click += new System.EventHandler(this.deleterent_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(12, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 26);
            this.panel2.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(12, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 26);
            this.panel1.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 201);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 26);
            this.panel3.TabIndex = 35;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 242);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(21, 26);
            this.panel4.TabIndex = 35;
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Location = new System.Drawing.Point(12, 283);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(21, 26);
            this.panel5.TabIndex = 35;
            // 
            // BookRent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deleterent_btn);
            this.Controls.Add(this.chkrent_btn);
            this.Controls.Add(this.bookid3_txt);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.rentconfirm_btn);
            this.Controls.Add(this.bookid2_txt);
            this.Controls.Add(this.bookid1_txt);
            this.Controls.Add(this.no_of_books_txt);
            this.Controls.Add(this.memid_txt);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchrent_txt);
            this.Controls.Add(this.label1);
            this.Name = "BookRent_Form";
            this.Size = new System.Drawing.Size(808, 417);
            this.Load += new System.EventHandler(this.BookRent_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchrent_txt;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox memid_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox no_of_books_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bookid1_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bookid2_txt;
        private Bunifu.Framework.UI.BunifuFlatButton rentconfirm_btn;
        private Bunifu.Framework.UI.BunifuFlatButton reset_btn;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bookid3_txt;
        private Bunifu.Framework.UI.BunifuFlatButton chkrent_btn;
        private Bunifu.Framework.UI.BunifuFlatButton deleterent_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}
