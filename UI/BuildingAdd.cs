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
    public partial class BuildingAdd : Form
    {
        public BuildingAdd()
        {
            InitializeComponent();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            BuildingManager bm = new BuildingManager(new EfBuildingDal());
            Building b = new Building();
            b.B_NAME = txtname.Text;
            b.B_DESCRPITION = txtdesc.Text;
            bm.Add(b);
        }
    }
}
