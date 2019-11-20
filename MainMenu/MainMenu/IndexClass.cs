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
    public partial class IndexClass : Form
    {
        private ClassManagement business;
        public IndexClass()
        {
            InitializeComponent();
            this.business = new ClassManagement();
            this.btnSave.Click += btnSave_Click;
            this.btnCancel.Click += btnCancel_Click;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            var name = this.txtClassName.Text;
            var description = this.txtDescription.Text;

            this.business.AddClass(name, description);
            MessageBox.Show("ok");
            this.Close();
        }



        
    }
}
