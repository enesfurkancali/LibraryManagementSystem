using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;

namespace Library_Management_System
{
    public partial class FrmBook : Form
    {
        BinaryImage img = new BinaryImage();
        DataSet dataSet = new DataSet();
        Database db = new Database();
        public FrmBook()
        {
            InitializeComponent();
            gridBook.UseEmbeddedNavigator = true;
        }

        private void FrmBook_Load(object sender, EventArgs e)
        {
            //fill grid
            gridBook.DataSource = db.GetData("Book", "*", dataSet);

            //create lookups
            var lookUpEditAuthor = new RepositoryItemLookUpEdit();
            var lookUpEditPublisher = new RepositoryItemLookUpEdit();
            var lookUpEditCategory = new RepositoryItemLookUpEdit();

            //adding data to lookups
            gridView1.Columns[3].ColumnEdit = lookUpEditAuthor;
            lookUpEditAuthor.ValueMember = "authorId";
            lookUpEditAuthor.DisplayMember = "authorName";
            lookUpEditAuthor.DataSource = db.GetData("Author", "*", dataSet);

            gridView1.Columns[4].ColumnEdit = lookUpEditPublisher;
            lookUpEditPublisher.ValueMember = "publisherId";
            lookUpEditPublisher.DisplayMember = "publisherName";
            lookUpEditPublisher.DataSource = db.GetData("Publisher", "*", dataSet);

            gridView1.Columns[5].ColumnEdit = lookUpEditCategory;
            lookUpEditCategory.ValueMember = "categoryId";
            lookUpEditCategory.DisplayMember = "categoryName";
            lookUpEditCategory.DataSource = db.GetData("Category", "*", dataSet);

            //add image button
            var btnAddImg = new RepositoryItemButtonEdit();
            btnAddImg.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            btnAddImg.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph;
            btnAddImg.Buttons[0].Image = Properties.Resources.MyResourceImageHere;
            btnAddImg.Buttons[0].Kind = ButtonPredefines.Glyph;
            btnAddImg.ButtonsStyle = BorderStyles.Flat;
            gridView1.Columns[7].ColumnEdit = btnAddImg;
            btnAddImg.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
        }
        int selectedIndex=0;
        private void gridView1_CustomRowCellEdit(object sender, CustomRowCellEditEventArgs e)
        {
            selectedIndex = e.RowHandle;
            DataTable editDatatable = dataSet.Tables[0].GetChanges();
            if (editDatatable != null)
            {
                db.UpdateDataTable(editDatatable);
                dataSet.AcceptChanges();
            }
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";
            file.ShowDialog();
            DialogResult dr = new DialogResult();

            if (dr == DialogResult.Cancel)
            {
                //Flyout ff = new Flyout();
                //FlyoutAction f = new FlyoutAction();
                //f.Caption = "Uyarı";
                //f.Description = "Dosya seçilmedi!";
                //f.Commands= ff.FlyoutButtons;
                //WindowsUIView.ShowFlyoutDialog(ff);

                MessageBox.Show("Dosya seçilmedi!");
                return;
            }
                string fileName = file.FileName;
                Image image = Image.FromFile(fileName);
                dataSet.Tables[0].Rows[selectedIndex][7] = img.imageToByteArray(image);

                DataTable editDatatable = dataSet.Tables[0].GetChanges();
                if (editDatatable != null)
                {
                    db.UpdateDataTable(editDatatable);
                    dataSet.AcceptChanges();
                }
        }    
    }
}
