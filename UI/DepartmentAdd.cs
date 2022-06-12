using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class DepartmentAdd : Form
    {
        public DepartmentAdd()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            DepartmentManager dm = new DepartmentManager(new EfDepartmentDal());
            Department d = new Department();
            d.F_ID = Convert.ToInt32(txtfid.Text);
            d.D_NAME = txtname.Text;
            d.D_DESCRIPTION = txtdesc.Text;
            dm.Add(d);
            this.Close();
        }
    }
}
