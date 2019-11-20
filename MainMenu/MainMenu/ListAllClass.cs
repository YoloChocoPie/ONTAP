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

                var UpdateForm = new UpdateClass(@class.ID);
                UpdateForm.ShowDialog();
                this.ListAllClass_Load();
              
            }
        }

        private void ListAllClass_Load()
        {
            var classes = this.Business.Getclass();
            this.grdAllClass.DataSource = classes;

        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if(this.grdAllClass.SelectedRows.Count == 1)
            {
                if (MessageBox.Show("delete?", "confirm",MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    var @class = (Class)this.grdAllClass.SelectedRows[0].DataBoundItem;
                    this.Business.DeleteClass(@class.ID);
                    MessageBox.Show("delete");
                    this.ListAllClass_Load();
                }
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            var createForm = new IndexClass();
            createForm.ShowDialog();
            this.ListAllClass_Load();
        }

        void ListAllClass_Load(object sender, EventArgs e)
        {
            var classes = this.Business.Getclass();
            this.grdAllClass.DataSource = classes;

        }
    }
}
