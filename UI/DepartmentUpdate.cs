using Business.Concrete;
using DataAccess.Concrete;
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
    public partial class DepartmentUpdate : Form
    {
        public DepartmentUpdate()
        {
            InitializeComponent();
        }

        private void DepartmentUpdate_Load(object sender, EventArgs e)
        {
            DepartmentManager dm = new DepartmentManager(new EfDepartmentDal());
            dataGridView1.DataSource = dm.GetAll().Data;
        }
    }
}
