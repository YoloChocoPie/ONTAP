using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenu
{
    public partial class ListAllClass : Form
    {
        public ClassManagement Business;
        public ListAllClass()
        {
            InitializeComponent();

            this.Business = new ClassManagement();

            this.Load += ListAllClass_Load; // load

            this.btnAdd.Click += btnAdd_Click; // tao moi

            this.btnDelete.Click += btnDelete_Click; // xoa

            this.grdAllClass.DoubleClick += grdAllClass_DoubleClick;
        }

        void grdAllClass_DoubleClick(object sender, EventArgs e)
        {
            if (this.grdAllClass.SelectedRows.Count == 1)
            {
                var @class = (Class)this.grdAllClass.SelectedRows[0].DataBoundItem;

                //var UpdateForm = new Update_Class_Form(@class.ID);
              
            }
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void ListAllClass_Load(object sender, EventArgs e)
        {
            var classes = this.Business.Getclass();
            this.grdAllClass.DataSource = classes;

        }
    }
}
