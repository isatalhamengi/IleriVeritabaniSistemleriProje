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
    public partial class TeacherAdd : Form
    {
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void TeacherAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            TeacherManager tm = new TeacherManager(new EfTeacherDal());
            Teacher t = new Teacher();
            t.T_NAME = txtname.Text;
            t.T_SURNAME = txtsurname.Text;
            tm.Add(t);
            this.Close();
        }
    }
}
