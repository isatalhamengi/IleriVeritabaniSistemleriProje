using Business.Concrete;
using DataAccess.Concrete;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {  

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingAdd b = new BuildingAdd();
            b.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuildingUpdate b = new BuildingUpdate();
            b.Show();
        }

        private void addToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FaculitieAdd f = new FaculitieAdd();
            f.Show();
        }

        private void addToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DepartmentAdd d = new DepartmentAdd();
            d.Show();
        }

        private void updateToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FaculitieUpdate fu = new FaculitieUpdate();
            fu.Show();
        }

        private void updateToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DepartmentUpdate du = new DepartmentUpdate();
            du.Show();
        }

        private void addToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            TeacherAdd t = new TeacherAdd();
            t.Show();
        }
    }
}