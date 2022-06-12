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
    public partial class FaculitieAdd : Form
    {
        public FaculitieAdd()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            FaculitieManager mg = new FaculitieManager(new EfFaculitieDal());
            Faculitie f = new Faculitie();
            f.F_NAME = txtname.Text;
            f.F_DESCRIPTION = txtdesc.Text;
            mg.Add(f);
        }
    }
}
