
namespace Library_Management_System
{
    partial class FrmHome
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
            this.lblBook = new DevExpress.XtraEditors.LabelControl();
            this.lblMember = new DevExpress.XtraEditors.LabelControl();
            this.lblAuthor = new DevExpress.XtraEditors.LabelControl();
            this.lblPublisher = new DevExpress.XtraEditors.LabelControl();
            this.lblCategory = new DevExpress.XtraEditors.LabelControl();
            this.lblBorrow = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBook
            // 
            this.lblBook.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBook.Appearance.Options.UseFont = true;
            this.lblBook.Location = new System.Drawing.Point(15, 15);
            this.lblBook.Margin = new System.Windows.Forms.Padding(6);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(198, 29);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Kayıtlı Kitap Sayısı:";
            // 
            // lblMember
            // 
            this.lblMember.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMember.Appearance.Options.UseFont = true;
            this.lblMember.Location = new System.Drawing.Point(15, 56);
            this.lblMember.Margin = new System.Windows.Forms.Padding(6);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(186, 29);
            this.lblMember.TabIndex = 1;
            this.lblMember.Text = "Kayıtlı Üye Sayısı:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthor.Appearance.Options.UseFont = true;
            this.lblAuthor.Location = new System.Drawing.Point(15, 97);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(6);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(205, 29);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Kayıtlı Yazar Sayısı:";
            // 
            // lblPublisher
            // 
            this.lblPublisher.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPublisher.Appearance.Options.UseFont = true;
            this.lblPublisher.Location = new System.Drawing.Point(15, 138);
            this.lblPublisher.Margin = new System.Windows.Forms.Padding(6);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(232, 29);
            this.lblPublisher.TabIndex = 3;
            this.lblPublisher.Text = "Kayıtlı Yayınevi Sayısı:";
            // 
            // lblCategory
            // 
            this.lblCategory.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategory.Appearance.Options.UseFont = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 179);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(6);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(233, 29);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Kayıtlı Kategori Sayısı:";
            // 
            // lblBorrow
            // 
            this.lblBorrow.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBorrow.Appearance.Options.UseFont = true;
            this.lblBorrow.Location = new System.Drawing.Point(15, 220);
            this.lblBorrow.Margin = new System.Windows.Forms.Padding(6);
            this.lblBorrow.Name = "lblBorrow";
            this.lblBorrow.Size = new System.Drawing.Size(283, 29);
            this.lblBorrow.TabIndex = 5;
            this.lblBorrow.Text = "Ödünç Verilen Kitap Sayısı:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(494, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 426);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblBorrow);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblPublisher);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.lblBook);
            this.Name = "FrmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBook;
        private DevExpress.XtraEditors.LabelControl lblMember;
        private DevExpress.XtraEditors.LabelControl lblAuthor;
        private DevExpress.XtraEditors.LabelControl lblPublisher;
        private DevExpress.XtraEditors.LabelControl lblCategory;
        private DevExpress.XtraEditors.LabelControl lblBorrow;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}