using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class FrmHomee : Form
    {
        BinaryImage img = new BinaryImage();
        DataSet ds = new DataSet();
        Database db = new Database();
        
        public FrmHomee()
        {
            InitializeComponent();
        }

        private void FrmHomee_Load(object sender, EventArgs e)
        {
            layoutView1.OptionsBehavior.AutoPopulateColumns = false;
            gridControl1.DataSource=db.GetData("Book", "*", ds);

            layoutView1.OptionsView.ShowHeaderPanel = false;

            layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Carousel;

            LayoutViewColumn colImg = layoutView1.Columns.AddVisible("img") as LayoutViewColumn;
            LayoutViewColumn colBookName = layoutView1.Columns.AddVisible("bookName") as LayoutViewColumn;
            LayoutViewColumn colPageCount =layoutView1.Columns.AddVisible("pageCount") as LayoutViewColumn;
            LayoutViewColumn colAuthor = layoutView1.Columns.AddVisible("authorId") as LayoutViewColumn;
            LayoutViewColumn colPublisher = layoutView1.Columns.AddVisible("publisherId") as LayoutViewColumn;
            LayoutViewColumn colCategory = layoutView1.Columns.AddVisible("categoryId") as LayoutViewColumn;
            
            LayoutViewField fieldPhoto = colImg.LayoutViewField;
            LayoutViewField fieldFirstName = colBookName.LayoutViewField;
            LayoutViewField fieldLastName = colPageCount.LayoutViewField;
            LayoutViewField fieldAddress = colAuthor.LayoutViewField;
            LayoutViewField fieldCity = colPublisher.LayoutViewField;
            LayoutViewField fieldCountry = colCategory.LayoutViewField;

            // Position the FirstName field to the right of the Photo field.
            fieldFirstName.Move(new LayoutItemDragController(fieldFirstName, fieldPhoto,
                InsertLocation.After, LayoutType.Horizontal));

            // Position the LastName field below the FirstName field.
            fieldLastName.Move(new LayoutItemDragController(fieldLastName, fieldFirstName,
                InsertLocation.After, LayoutType.Vertical));

            fieldAddress.Move(new LayoutItemDragController(fieldAddress, fieldLastName,
                InsertLocation.After, LayoutType.Vertical));

            fieldCity.Move(new LayoutItemDragController(fieldCity, fieldAddress,
                InsertLocation.After, LayoutType.Vertical));

            fieldCountry.Move(new LayoutItemDragController(fieldCountry, fieldCity,
                InsertLocation.After, LayoutType.Vertical));


            // Assign editors to card fields.
            RepositoryItemPictureEdit riPictureEdit = gridControl1.RepositoryItems.Add("PictureEdit") as RepositoryItemPictureEdit;
            riPictureEdit.SizeMode = PictureSizeMode.Zoom;
            colImg.ColumnEdit = riPictureEdit;

            // Customize card field options.
            colBookName.Caption = "Book Name";
            colPageCount.Caption = "Page";
            // Set the card's minimum size.
            layoutView1.CardMinSize = new Size(400, 250);

            fieldPhoto.TextVisible = false;
            fieldPhoto.SizeConstraintsType = SizeConstraintsType.Custom;
            fieldPhoto.MaxSize = fieldPhoto.MinSize = new Size(150, 150);


            //layoutView1.Images = ds.Tables[0].Columns[7];
            //img.byteArrayToImage(Convert.ToByte( ds.Tables[0].Rows[0][7]));

        }
    }
}
