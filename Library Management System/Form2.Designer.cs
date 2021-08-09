
namespace Library_Management_System
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnMember = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnHomePage = new DevExpress.XtraBars.BarButtonItem();
            this.btnBorrow = new DevExpress.XtraBars.BarButtonItem();
            this.btnBook = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategory = new DevExpress.XtraBars.BarButtonItem();
            this.btnAuthor = new DevExpress.XtraBars.BarButtonItem();
            this.btnPublisher = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.EmptyAreaImageOptions.ImagePadding = new System.Windows.Forms.Padding(150, 144, 150, 144);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnMember,
            this.barButtonItem1,
            this.btnHomePage,
            this.btnBorrow,
            this.btnBook,
            this.btnCategory,
            this.btnAuthor,
            this.btnPublisher,
            this.btnLogout,
            this.barButtonItem2});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(14);
            this.ribbonControl1.MaxItemId = 12;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.OptionsMenuMinWidth = 1669;
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1224, 231);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // btnMember
            // 
            this.btnMember.Caption = "Üye";
            this.btnMember.Id = 2;
            this.btnMember.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMember.ImageOptions.Image")));
            this.btnMember.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMember.ImageOptions.LargeImage")));
            this.btnMember.Name = "btnMember";
            this.btnMember.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMember_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 3;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnHomePage
            // 
            this.btnHomePage.Caption = "Anasayfa";
            this.btnHomePage.Id = 4;
            this.btnHomePage.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHomePage.ImageOptions.Image")));
            this.btnHomePage.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnHomePage.ImageOptions.LargeImage")));
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Caption = "Ödünç";
            this.btnBorrow.Id = 5;
            this.btnBorrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrow.ImageOptions.Image")));
            this.btnBorrow.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBorrow.ImageOptions.LargeImage")));
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBorrow_ItemClick);
            // 
            // btnBook
            // 
            this.btnBook.Caption = "Kitap";
            this.btnBook.Id = 6;
            this.btnBook.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBook.ImageOptions.Image")));
            this.btnBook.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBook.ImageOptions.LargeImage")));
            this.btnBook.Name = "btnBook";
            this.btnBook.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_1);
            // 
            // btnCategory
            // 
            this.btnCategory.Caption = "Kategori";
            this.btnCategory.Id = 7;
            this.btnCategory.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.Image")));
            this.btnCategory.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnCategory.ImageOptions.LargeImage")));
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCategory_ItemClick);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Caption = "Yazar";
            this.btnAuthor.Id = 8;
            this.btnAuthor.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAuthor.ImageOptions.Image")));
            this.btnAuthor.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAuthor.ImageOptions.LargeImage")));
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAuthor_ItemClick);
            // 
            // btnPublisher
            // 
            this.btnPublisher.Caption = "Yayınevi";
            this.btnPublisher.Id = 9;
            this.btnPublisher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPublisher.ImageOptions.Image")));
            this.btnPublisher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPublisher.ImageOptions.LargeImage")));
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPublisher_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Çıkış Yap";
            this.btnLogout.Id = 10;
            this.btnLogout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.Image")));
            this.btnLogout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.ImageOptions.LargeImage")));
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Kütüphane";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnHomePage);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMember);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBorrow);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnBook);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCategory);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnAuthor);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPublisher);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup2.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 700);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(14);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1224, 36);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Takvim";
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick_2);
            // 
            // Form2
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 736);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "Form2";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Library Management System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnMember;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnHomePage;
        private DevExpress.XtraBars.BarButtonItem btnBorrow;
        private DevExpress.XtraBars.BarButtonItem btnBook;
        private DevExpress.XtraBars.BarButtonItem btnCategory;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnAuthor;
        private DevExpress.XtraBars.BarButtonItem btnPublisher;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    }
}