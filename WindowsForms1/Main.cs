using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Main : Form
    {
        public static bool W1, W2, W3, W4, W5;
//        public static Vehicle C1;

        public Main()
        {
            W1 = W2 = W3 = W4 = W5 = false;
            InitializeComponent();
        }
/*        protected override void OnPaint(PaintEventArgs e)
        {
            if (C1 != null)
            {
                C1.Refresh(e.Graphics);
                Invalidate();
            }
        }*/

        private void Main_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Authorization authorization = new Authorization();
            authorization.Show();

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.CornflowerBlue;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void PM_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Motorbike", "Petrol");
            parameters.Show();
            
        }

        private void PC_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Car", "Petrol");
            parameters.Show();
        }

        private void DC_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Car", "Diesel");
            parameters.Show();
        }

        private void GC_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Car", "Gas");
            parameters.Show();
        }

        private void EC_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Car", "Electricity");
            parameters.Show();
        }

        private void DB_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Bus", "Diesel");
            parameters.Show();
        }

        private void C_G_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
                timer1.Start();
            timer1.Tick += timer1_Tick;
            Type type = this.Controls[12].GetType();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
    //        this.Controls[12].Location.X += 3;
            this.Controls[12].Invalidate();
        }

        private void ET_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Trolly", "Electricity");
            parameters.Show();
        }

        private void ETram_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Tram", "Electricity");
            parameters.Show();
        }

        private void DTruck_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Truck", "Diesel");
            parameters.Show();
        }

        private void DT_Click(object sender, EventArgs e)
        {
            Parameters parameters = new Parameters(this, "Tractor", "Diesel");
            parameters.Show();
        }
    }
}
