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
    public partial class BuildingUpdate : Form
    {
        public BuildingUpdate()
        {
            InitializeComponent();
        }

        private void BuildingUpdate_Load(object sender, EventArgs e)
        {
            BuildingManager bm = new BuildingManager(new EfBuildingDal());
            dataGridView1.DataSource = bm.GetAll().Data;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            }
            else
            {
                ContextMenuStrip my_menu = new System.Windows.Forms.ContextMenuStrip();
                int position_xy_mouse_row = dataGridView1.HitTest(e.X, e.Y).RowIndex;

                if (position_xy_mouse_row >= 0)
                {
                    my_menu.Items.Add("Del").Name = "Del";
                    my_menu.Items.Add("Update").Name = "Update";
                }

                my_menu.Show(dataGridView1,new Point(e.X,e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_clicked);
            }
        }

        int id;
        private void my_menu_clicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Del":
                    BuildingManager bm = new BuildingManager(new EfBuildingDal());
                    Building b = new Building();
                    b.B_ID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    b.B_NAME = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    b.B_DESCRPITION = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    bm.Remove(b);
                    dataGridView1.DataSource = bm.GetAll().Data;
                    break;
                case "Update":
                    BuildingManager bmu = new BuildingManager(new EfBuildingDal());
                    id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    txtname.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    txtdesc.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    break;
            }
        }
    }
}
