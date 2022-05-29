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
            BuildingManager bm = new BuildingManager(new EfBuildingDal());
            dataGridView1.DataSource = bm.GetAll().Data;
        }
    }
}