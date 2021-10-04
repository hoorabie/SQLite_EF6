namespace BibliothèqueSqlite.Forms
{
    partial class Frmbooks
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdateClassBook = new System.Windows.Forms.Button();
            this.btnNewClassBook = new System.Windows.Forms.Button();
            this.btnUpdatePublishing = new System.Windows.Forms.Button();
            this.btnNewPublishing = new System.Windows.Forms.Button();
            this.cmbBookStatus = new System.Windows.Forms.ComboBox();
            this.cmbClassBook = new System.Windows.Forms.ComboBox();
            this.cmbPublishing = new System.Windows.Forms.ComboBox();
            this.nmPriceBook = new System.Windows.Forms.NumericUpDown();
            this.nmQteBook = new System.Windows.Forms.NumericUpDown();
            this.nmNmbCopieBook = new System.Windows.Forms.NumericUpDown();
            this.txtSiteBook = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtTitalBook = new System.Windows.Forms.TextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQteBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNmbCopieBook)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Location = new System.Drawing.Point(337, 0);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Location = new System.Drawing.Point(186, 0);
            // 
            // btnNew
            // 
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.Location = new System.Drawing.Point(261, 0);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdateClassBook);
            this.panel2.Controls.Add(this.btnNewClassBook);
            this.panel2.Controls.Add(this.btnUpdatePublishing);
            this.panel2.Controls.Add(this.btnNewPublishing);
            this.panel2.Controls.Add(this.cmbBookStatus);
            this.panel2.Controls.Add(this.cmbClassBook);
            this.panel2.Controls.Add(this.cmbPublishing);
            this.panel2.Controls.Add(this.nmPriceBook);
            this.panel2.Controls.Add(this.nmQteBook);
            this.panel2.Controls.Add(this.nmNmbCopieBook);
            this.panel2.Controls.Add(this.txtSiteBook);
            this.panel2.Controls.Add(this.txtAuthorName);
            this.panel2.Controls.Add(this.txtTitalBook);
            this.panel2.Controls.Add(this.dtp);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 303);
            this.panel2.TabIndex = 1;
            // 
            // btnUpdateClassBook
            // 
            this.btnUpdateClassBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClassBook.FlatAppearance.BorderSize = 0;
            this.btnUpdateClassBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateClassBook.Image = global::BibliothèqueSqlite.Properties.Resources.update_left_rotation_24px;
            this.btnUpdateClassBook.Location = new System.Drawing.Point(40, 201);
            this.btnUpdateClassBook.Name = "btnUpdateClassBook";
            this.btnUpdateClassBook.Size = new System.Drawing.Size(24, 23);
            this.btnUpdateClassBook.TabIndex = 35;
            this.btnUpdateClassBook.UseVisualStyleBackColor = true;
            this.btnUpdateClassBook.Click += new System.EventHandler(this.btnUpdateClassBook_Click);
            // 
            // btnNewClassBook
            // 
            this.btnNewClassBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewClassBook.FlatAppearance.BorderSize = 0;
            this.btnNewClassBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewClassBook.Image = global::BibliothèqueSqlite.Properties.Resources.add_24px;
            this.btnNewClassBook.Location = new System.Drawing.Point(13, 201);
            this.btnNewClassBook.Name = "btnNewClassBook";
            this.btnNewClassBook.Size = new System.Drawing.Size(24, 23);
            this.btnNewClassBook.TabIndex = 35;
            this.btnNewClassBook.UseVisualStyleBackColor = true;
            this.btnNewClassBook.Click += new System.EventHandler(this.btnNewClassBook_Click);
            // 
            // btnUpdatePublishing
            // 
            this.btnUpdatePublishing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdatePublishing.FlatAppearance.BorderSize = 0;
            this.btnUpdatePublishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdatePublishing.Image = global::BibliothèqueSqlite.Properties.Resources.update_left_rotation_24px;
            this.btnUpdatePublishing.Location = new System.Drawing.Point(40, 174);
            this.btnUpdatePublishing.Name = "btnUpdatePublishing";
            this.btnUpdatePublishing.Size = new System.Drawing.Size(24, 23);
            this.btnUpdatePublishing.TabIndex = 35;
            this.btnUpdatePublishing.UseVisualStyleBackColor = true;
            this.btnUpdatePublishing.Click += new System.EventHandler(this.btnUpdatePublishing_Click);
            // 
            // btnNewPublishing
            // 
            this.btnNewPublishing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPublishing.FlatAppearance.BorderSize = 0;
            this.btnNewPublishing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPublishing.Image = global::BibliothèqueSqlite.Properties.Resources.add_24px;
            this.btnNewPublishing.Location = new System.Drawing.Point(13, 174);
            this.btnNewPublishing.Name = "btnNewPublishing";
            this.btnNewPublishing.Size = new System.Drawing.Size(24, 23);
            this.btnNewPublishing.TabIndex = 35;
            this.btnNewPublishing.UseVisualStyleBackColor = true;
            this.btnNewPublishing.Click += new System.EventHandler(this.btnNewPublishing_Click);
            // 
            // cmbBookStatus
            // 
            this.cmbBookStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBookStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBookStatus.FormattingEnabled = true;
            this.cmbBookStatus.Items.AddRange(new object[] {
            "ممتاز",
            "جيد جدا",
            "جيد",
            "متوسط",
            "سيئ ",
            "سيئ جدا"});
            this.cmbBookStatus.Location = new System.Drawing.Point(12, 256);
            this.cmbBookStatus.Name = "cmbBookStatus";
            this.cmbBookStatus.Size = new System.Drawing.Size(223, 24);
            this.cmbBookStatus.TabIndex = 9;
            // 
            // cmbClassBook
            // 
            this.cmbClassBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbClassBook.FormattingEnabled = true;
            this.cmbClassBook.Location = new System.Drawing.Point(70, 201);
            this.cmbClassBook.Name = "cmbClassBook";
            this.cmbClassBook.Size = new System.Drawing.Size(165, 24);
            this.cmbClassBook.TabIndex = 7;
            // 
            // cmbPublishing
            // 
            this.cmbPublishing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPublishing.FormattingEnabled = true;
            this.cmbPublishing.Location = new System.Drawing.Point(70, 174);
            this.cmbPublishing.Name = "cmbPublishing";
            this.cmbPublishing.Size = new System.Drawing.Size(165, 24);
            this.cmbPublishing.TabIndex = 36;
            // 
            // nmPriceBook
            // 
            this.nmPriceBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmPriceBook.Location = new System.Drawing.Point(12, 146);
            this.nmPriceBook.Name = "nmPriceBook";
            this.nmPriceBook.Size = new System.Drawing.Size(223, 25);
            this.nmPriceBook.TabIndex = 5;
            // 
            // nmQteBook
            // 
            this.nmQteBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmQteBook.Location = new System.Drawing.Point(12, 118);
            this.nmQteBook.Name = "nmQteBook";
            this.nmQteBook.Size = new System.Drawing.Size(223, 25);
            this.nmQteBook.TabIndex = 4;
            // 
            // nmNmbCopieBook
            // 
            this.nmNmbCopieBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nmNmbCopieBook.Location = new System.Drawing.Point(12, 90);
            this.nmNmbCopieBook.Name = "nmNmbCopieBook";
            this.nmNmbCopieBook.Size = new System.Drawing.Size(223, 25);
            this.nmNmbCopieBook.TabIndex = 3;
            // 
            // txtSiteBook
            // 
            this.txtSiteBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSiteBook.Location = new System.Drawing.Point(12, 228);
            this.txtSiteBook.Name = "txtSiteBook";
            this.txtSiteBook.Size = new System.Drawing.Size(223, 25);
            this.txtSiteBook.TabIndex = 8;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAuthorName.Location = new System.Drawing.Point(12, 62);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(223, 25);
            this.txtAuthorName.TabIndex = 2;
            // 
            // txtTitalBook
            // 
            this.txtTitalBook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTitalBook.Location = new System.Drawing.Point(12, 34);
            this.txtTitalBook.Name = "txtTitalBook";
            this.txtTitalBook.Size = new System.Drawing.Size(223, 25);
            this.txtTitalBook.TabIndex = 1;
            // 
            // dtp
            // 
            this.dtp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtp.Location = new System.Drawing.Point(12, 6);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(223, 25);
            this.dtp.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(241, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "تاريخ الاقتناء الكتاب";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(241, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 21);
            this.label10.TabIndex = 29;
            this.label10.Text = "موقع الكتاب في المكتبة";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(241, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "عدد نسخ الكتاب";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(241, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "حالة الكتاب";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(241, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 21);
            this.label7.TabIndex = 33;
            this.label7.Text = "سعر الكتاب";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(241, 206);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 21);
            this.label11.TabIndex = 34;
            this.label11.Text = "تصنيف الكتاب";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(241, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "عدد مجلدات الكتاب";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(241, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 26;
            this.label4.Text = "دار النشر";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(241, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "اسم المؤلف";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(241, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "عنوان الكتاب";
            // 
            // Frmbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 330);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frmbooks";
            this.Text = "Frmbooks";
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmPriceBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmQteBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmNmbCopieBook)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbBookStatus;
        private System.Windows.Forms.ComboBox cmbClassBook;
        private System.Windows.Forms.ComboBox cmbPublishing;
        private System.Windows.Forms.NumericUpDown nmPriceBook;
        private System.Windows.Forms.NumericUpDown nmQteBook;
        private System.Windows.Forms.NumericUpDown nmNmbCopieBook;
        private System.Windows.Forms.TextBox txtSiteBook;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtTitalBook;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnNewClassBook;
        private System.Windows.Forms.Button btnNewPublishing;
        private System.Windows.Forms.Button btnUpdateClassBook;
        private System.Windows.Forms.Button btnUpdatePublishing;
    }
}