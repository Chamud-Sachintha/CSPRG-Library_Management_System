namespace ReadLifes_LibraryManagement
{
    partial class BookMgmt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMgmt));
            this.book_isbn_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.author_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bookname_txt = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.category_dropdown = new Bunifu.Framework.UI.BunifuDropdown();
            this.label1 = new System.Windows.Forms.Label();
            this.supid_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bookreg_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reset_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.searchbookNo_txt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.chkbook_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.deletebook_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // book_isbn_txt
            // 
            this.book_isbn_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.book_isbn_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.book_isbn_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.book_isbn_txt.HintForeColor = System.Drawing.Color.Empty;
            this.book_isbn_txt.HintText = "ISBN Number";
            this.book_isbn_txt.isPassword = false;
            this.book_isbn_txt.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.book_isbn_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.book_isbn_txt.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.book_isbn_txt.LineThickness = 3;
            this.book_isbn_txt.Location = new System.Drawing.Point(32, 176);
            this.book_isbn_txt.Margin = new System.Windows.Forms.Padding(4);
            this.book_isbn_txt.Name = "book_isbn_txt";
            this.book_isbn_txt.Size = new System.Drawing.Size(358, 33);
            this.book_isbn_txt.TabIndex = 0;
            this.book_isbn_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // author_txt
            // 
            this.author_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.author_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.author_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.author_txt.HintForeColor = System.Drawing.Color.Empty;
            this.author_txt.HintText = "Author Name";
            this.author_txt.isPassword = false;
            this.author_txt.LineFocusedColor = System.Drawing.Color.RoyalBlue;
            this.author_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.author_txt.LineMouseHoverColor = System.Drawing.Color.RoyalBlue;
            this.author_txt.LineThickness = 3;
            this.author_txt.Location = new System.Drawing.Point(32, 258);
            this.author_txt.Margin = new System.Windows.Forms.Padding(4);
            this.author_txt.Name = "author_txt";
            this.author_txt.Size = new System.Drawing.Size(358, 33);
            this.author_txt.TabIndex = 1;
            this.author_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bookname_txt
            // 
            this.bookname_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bookname_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bookname_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bookname_txt.HintForeColor = System.Drawing.Color.Empty;
            this.bookname_txt.HintText = "Book Name";
            this.bookname_txt.isPassword = false;
            this.bookname_txt.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.bookname_txt.LineIdleColor = System.Drawing.Color.Gray;
            this.bookname_txt.LineMouseHoverColor = System.Drawing.Color.CornflowerBlue;
            this.bookname_txt.LineThickness = 3;
            this.bookname_txt.Location = new System.Drawing.Point(32, 217);
            this.bookname_txt.Margin = new System.Windows.Forms.Padding(4);
            this.bookname_txt.Name = "bookname_txt";
            this.bookname_txt.Size = new System.Drawing.Size(358, 33);
            this.bookname_txt.TabIndex = 2;
            this.bookname_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // category_dropdown
            // 
            this.category_dropdown.BackColor = System.Drawing.Color.Transparent;
            this.category_dropdown.BorderRadius = 3;
            this.category_dropdown.DisabledColor = System.Drawing.Color.Gray;
            this.category_dropdown.ForeColor = System.Drawing.Color.White;
            this.category_dropdown.Items = new string[] {
        "",
        "Programming",
        "Cyber Security",
        "Web Develeopment",
        "Red Teaming",
        "Forensics"};
            this.category_dropdown.Location = new System.Drawing.Point(145, 43);
            this.category_dropdown.Name = "category_dropdown";
            this.category_dropdown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.category_dropdown.onHoverColor = System.Drawing.Color.SeaGreen;
            this.category_dropdown.selectedIndex = -1;
            this.category_dropdown.Size = new System.Drawing.Size(245, 35);
            this.category_dropdown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose Category";
            // 
            // supid_txt
            // 
            this.supid_txt.BorderColorFocused = System.Drawing.Color.Green;
            this.supid_txt.BorderColorIdle = System.Drawing.Color.DimGray;
            this.supid_txt.BorderColorMouseHover = System.Drawing.Color.Green;
            this.supid_txt.BorderThickness = 3;
            this.supid_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.supid_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.supid_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.supid_txt.isPassword = false;
            this.supid_txt.Location = new System.Drawing.Point(6, 113);
            this.supid_txt.Margin = new System.Windows.Forms.Padding(4);
            this.supid_txt.Name = "supid_txt";
            this.supid_txt.Size = new System.Drawing.Size(384, 44);
            this.supid_txt.TabIndex = 5;
            this.supid_txt.Text = "Supplier ID";
            this.supid_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.supid_txt.Enter += new System.EventHandler(this.supid_txt_Enter);
            this.supid_txt.Leave += new System.EventHandler(this.supid_txt_Leave);
            // 
            // bookreg_btn
            // 
            this.bookreg_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bookreg_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bookreg_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookreg_btn.BorderRadius = 0;
            this.bookreg_btn.ButtonText = "Confirm Register";
            this.bookreg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookreg_btn.DisabledColor = System.Drawing.Color.Gray;
            this.bookreg_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.bookreg_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("bookreg_btn.Iconimage")));
            this.bookreg_btn.Iconimage_right = null;
            this.bookreg_btn.Iconimage_right_Selected = null;
            this.bookreg_btn.Iconimage_Selected = null;
            this.bookreg_btn.IconMarginLeft = 0;
            this.bookreg_btn.IconMarginRight = 0;
            this.bookreg_btn.IconRightVisible = true;
            this.bookreg_btn.IconRightZoom = 0D;
            this.bookreg_btn.IconVisible = true;
            this.bookreg_btn.IconZoom = 90D;
            this.bookreg_btn.IsTab = false;
            this.bookreg_btn.Location = new System.Drawing.Point(6, 327);
            this.bookreg_btn.Name = "bookreg_btn";
            this.bookreg_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bookreg_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bookreg_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.bookreg_btn.selected = false;
            this.bookreg_btn.Size = new System.Drawing.Size(169, 48);
            this.bookreg_btn.TabIndex = 6;
            this.bookreg_btn.Text = "Confirm Register";
            this.bookreg_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookreg_btn.Textcolor = System.Drawing.Color.White;
            this.bookreg_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookreg_btn.Click += new System.EventHandler(this.bookreg_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reset_btn.BorderRadius = 0;
            this.reset_btn.ButtonText = "Reset Feilds";
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
            this.reset_btn.Location = new System.Drawing.Point(221, 327);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.reset_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.reset_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.reset_btn.selected = false;
            this.reset_btn.Size = new System.Drawing.Size(169, 48);
            this.reset_btn.TabIndex = 7;
            this.reset_btn.Text = "Reset Feilds";
            this.reset_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reset_btn.Textcolor = System.Drawing.Color.White;
            this.reset_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // searchbookNo_txt
            // 
            this.searchbookNo_txt.BorderColorFocused = System.Drawing.Color.Green;
            this.searchbookNo_txt.BorderColorIdle = System.Drawing.Color.DimGray;
            this.searchbookNo_txt.BorderColorMouseHover = System.Drawing.Color.Green;
            this.searchbookNo_txt.BorderThickness = 3;
            this.searchbookNo_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchbookNo_txt.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.searchbookNo_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.searchbookNo_txt.isPassword = false;
            this.searchbookNo_txt.Location = new System.Drawing.Point(420, 43);
            this.searchbookNo_txt.Margin = new System.Windows.Forms.Padding(4);
            this.searchbookNo_txt.Name = "searchbookNo_txt";
            this.searchbookNo_txt.Size = new System.Drawing.Size(356, 44);
            this.searchbookNo_txt.TabIndex = 8;
            this.searchbookNo_txt.Text = "Book ISBN Number";
            this.searchbookNo_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchbookNo_txt.Enter += new System.EventHandler(this.searchbookNo_txt_Enter);
            this.searchbookNo_txt.Leave += new System.EventHandler(this.searchbookNo_txt_Leave);
            // 
            // chkbook_btn
            // 
            this.chkbook_btn.Activecolor = System.Drawing.Color.SeaGreen;
            this.chkbook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chkbook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkbook_btn.BorderRadius = 0;
            this.chkbook_btn.ButtonText = "C H E C K   B O O K";
            this.chkbook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkbook_btn.DisabledColor = System.Drawing.Color.Gray;
            this.chkbook_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.chkbook_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("chkbook_btn.Iconimage")));
            this.chkbook_btn.Iconimage_right = null;
            this.chkbook_btn.Iconimage_right_Selected = null;
            this.chkbook_btn.Iconimage_Selected = null;
            this.chkbook_btn.IconMarginLeft = 0;
            this.chkbook_btn.IconMarginRight = 0;
            this.chkbook_btn.IconRightVisible = true;
            this.chkbook_btn.IconRightZoom = 0D;
            this.chkbook_btn.IconVisible = true;
            this.chkbook_btn.IconZoom = 60D;
            this.chkbook_btn.IsTab = false;
            this.chkbook_btn.Location = new System.Drawing.Point(420, 113);
            this.chkbook_btn.Name = "chkbook_btn";
            this.chkbook_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.chkbook_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.chkbook_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.chkbook_btn.selected = false;
            this.chkbook_btn.Size = new System.Drawing.Size(356, 48);
            this.chkbook_btn.TabIndex = 9;
            this.chkbook_btn.Text = "C H E C K   B O O K";
            this.chkbook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkbook_btn.Textcolor = System.Drawing.Color.White;
            this.chkbook_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbook_btn.Click += new System.EventHandler(this.chkbook_btn_Click);
            // 
            // deletebook_btn
            // 
            this.deletebook_btn.Activecolor = System.Drawing.Color.SeaGreen;
            this.deletebook_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebook_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletebook_btn.BorderRadius = 0;
            this.deletebook_btn.ButtonText = "D E L E T E   B O O K";
            this.deletebook_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deletebook_btn.DisabledColor = System.Drawing.Color.Gray;
            this.deletebook_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.deletebook_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("deletebook_btn.Iconimage")));
            this.deletebook_btn.Iconimage_right = null;
            this.deletebook_btn.Iconimage_right_Selected = null;
            this.deletebook_btn.Iconimage_Selected = null;
            this.deletebook_btn.IconMarginLeft = 0;
            this.deletebook_btn.IconMarginRight = 0;
            this.deletebook_btn.IconRightVisible = true;
            this.deletebook_btn.IconRightZoom = 0D;
            this.deletebook_btn.IconVisible = true;
            this.deletebook_btn.IconZoom = 45D;
            this.deletebook_btn.IsTab = false;
            this.deletebook_btn.Location = new System.Drawing.Point(420, 202);
            this.deletebook_btn.Name = "deletebook_btn";
            this.deletebook_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.deletebook_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.deletebook_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.deletebook_btn.selected = false;
            this.deletebook_btn.Size = new System.Drawing.Size(356, 48);
            this.deletebook_btn.TabIndex = 11;
            this.deletebook_btn.Text = "D E L E T E   B O O K";
            this.deletebook_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebook_btn.Textcolor = System.Drawing.Color.White;
            this.deletebook_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebook_btn.Click += new System.EventHandler(this.deletebook_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(6, 183);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(21, 26);
            this.panel2.TabIndex = 35;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(6, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 26);
            this.panel1.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(6, 265);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(21, 26);
            this.panel3.TabIndex = 35;
            // 
            // BookMgmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.deletebook_btn);
            this.Controls.Add(this.chkbook_btn);
            this.Controls.Add(this.searchbookNo_txt);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.bookreg_btn);
            this.Controls.Add(this.supid_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.category_dropdown);
            this.Controls.Add(this.bookname_txt);
            this.Controls.Add(this.author_txt);
            this.Controls.Add(this.book_isbn_txt);
            this.Name = "BookMgmt";
            this.Size = new System.Drawing.Size(817, 418);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox book_isbn_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox author_txt;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bookname_txt;
        private Bunifu.Framework.UI.BunifuDropdown category_dropdown;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMetroTextbox supid_txt;
        private Bunifu.Framework.UI.BunifuFlatButton bookreg_btn;
        private Bunifu.Framework.UI.BunifuFlatButton reset_btn;
        private Bunifu.Framework.UI.BunifuMetroTextbox searchbookNo_txt;
        private Bunifu.Framework.UI.BunifuFlatButton chkbook_btn;
        private Bunifu.Framework.UI.BunifuFlatButton deletebook_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;

    }
}
