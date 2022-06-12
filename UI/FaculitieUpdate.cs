﻿using Business.Concrete;
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
    public partial class FaculitieUpdate : Form
    {
        public FaculitieUpdate()
        {
            InitializeComponent();
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

                my_menu.Show(dataGridView1, new Point(e.X, e.Y));

                my_menu.ItemClicked += new ToolStripItemClickedEventHandler(my_menu_clicked);
            }
        }

        int id;
        private void my_menu_clicked(object? sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "Del":
                    FaculitieManager bm = new FaculitieManager(new EfFaculitieDal());
                    Faculitie b = new Faculitie();
                    b.F_ID= Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
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

        private void FaculitieUpdate_Load(object sender, EventArgs e)
        {
            FaculitieManager fm = new FaculitieManager(new EfFaculitieDal());
            dataGridView1.DataSource = fm.GetAll().Data;
        }


    }
}
