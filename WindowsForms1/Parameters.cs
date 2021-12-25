using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Parameters : Form
    {
        protected Main m1;
        protected int posY;
        public Vehicle C1;
        public Vehicle C2;
        public Vehicle C3;
        public Vehicle C4;
        public Vehicle C5;
        private void Enter_Click(object sender, EventArgs e)
        {
 /*           if (w1.Checked)
            {
                posY = 350;
                Main.W1 = true;
            }
            if (w2.Checked)
            {
                posY = 400;
                Main.W2 = true;
            }
            if (w3.Checked)
            {
                posY = 450;
                Main.W3 = true;
            }
            if (w4.Checked)
            {
                posY = 510;
                Main.W4 = true;
            }
            if (w5.Checked)
            {
                posY = 570;
                Main.W5 = true;
            }*/

            switch (TypTS.Text)
            {
                case "Car":
                    if (w1.Checked)
                    {
                        C1 = new Car(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                        Main.W1 = true;
                    }
                    if (w2.Checked)
                    {
                        C2 = new Car(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w2.Text);
                        Main.W2 = true;
                    }
                    if (w4.Checked)
                    {
                        C4 = new Car(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w4.Text);
                        Main.W4 = true;
                    }
                    if (w5.Checked)
                    {
                        C5 = new Car(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w5.Text);
                        Main.W5 = true;
                    }
                    /*                   switch (TypF.Text)
                                        {
                                            case "Petrol":
                                                m1.C_P.Visible = true;
                                                m1.C_P.Location = new Point(0, posY);
                                                break;
                                            case "Gas":
                                                m1.C_G.Visible = true;
                                                m1.C_G.Location = new Point(0, posY);
                                                break;
                                            case "Electricity":
                                                m1.C_E.Visible = true;
                                                m1.C_E.Location = new Point(0, posY);
                                                break;
                                            case "Diesel":
                                                m1.C_D.Visible = true;
                                                m1.C_D.Location = new Point(0, posY);
                                                break;
                                            default:
                                                break;
                                        }*/
                    break;
                case "Bus":
                    if (w1.Checked)
                    {
                        C1 = new Bus(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                        Main.W1 = true;
                    }
                    if (w2.Checked)
                    {
                        C2 = new Bus(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w2.Text);
                        Main.W2 = true;
                    }
                    if (w4.Checked)
                    {
                        C4 = new Bus(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w4.Text);
                        Main.W4 = true;
                    }
                    if (w5.Checked)
                    {
                        C5 = new Bus(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w5.Text);
                        Main.W5 = true;
                    }
                    /*                    m1.B_D.Visible = true;
                                        m1.B_D.Location = new Point(0, posY);*/
                    break;
                case "Motorbike":
                    if (w1.Checked)
                    {
                        C1 = new Bike(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                        Main.W1 = true;
                    }
                    if (w2.Checked)
                    {
                        C2 = new Bike(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w2.Text);
                        Main.W2 = true;
                    }
                    if (w4.Checked)
                    {
                        C4 = new Bike(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w4.Text);
                        Main.W4 = true;
                    }
                    if (w5.Checked)
                    {
                        C5 = new Bike(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w5.Text);
                        Main.W5 = true;
                    }
                    /*                   m1.M_P.Visible = true;
                                        m1.M_P.Location = new Point(0, posY);*/
                    break;
                case "Trolly":
                    C1 = new Troll(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                    Main.W1 = true;
/*                    m1.T_E.Visible = true;
                    m1.T_E.Location = new Point(0, posY);*/
                    break;
                case "Truck":
                    if (w1.Checked)
                    {
                        C1 = new Truck(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                        Main.W1 = true;
                    }
                    if (w2.Checked)
                    {
                        C2 = new Truck(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w2.Text);
                        Main.W2 = true;
                    }
                    if (w4.Checked)
                    {
                        C4 = new Truck(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w4.Text);
                        Main.W4 = true;
                    }
                    if (w5.Checked)
                    {
                        C5 = new Truck(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w5.Text);
                        Main.W5 = true;
                    }
                    /*                   m1.Truck.Visible = true;
                                        m1.Truck.Location = new Point(0, posY);*/
                    break;
                case "Tram":
                    C3 = new Tram(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w3.Text);
                    Main.W3 = true;
                    /*                    m1.Tram.Visible = true;
                                        m1.Tram.Location = new Point(0, posY);*/
                    break;
                case "Tractor":
                    if (w1.Checked)
                    {
                        C1 = new Tractor(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w1.Text);
                        Main.W1 = true;
                    }
                    if (w2.Checked)
                    {
                        C2 = new Tractor(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w2.Text);
                        Main.W2 = true;
                    }
                    if (w4.Checked)
                    {
                        C4 = new Tractor(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w4.Text);
                        Main.W4 = true;
                    }
                    if (w5.Checked)
                    {
                        C5 = new Tractor(m1, TypTS.Text, TypF.Text, min_speed.Text, max_speed.Text, consumption.Text, capacity.Text, w5.Text);
                        Main.W5 = true;
                    }
                    /*                    m1.Tractor.Visible = true;
                                        m1.Tractor.Location = new Point(0, posY);*/
                    break;
                default:
                    break;
            }
            this.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        public Parameters(Main M1, string TS, string TF)
        {
            InitializeComponent();

            m1 = M1;
            TypTS.Text = TS;
            TypF.Text = TF;
            if (TypF.Text == "Electricity")
            {
                Val.Text = "kWh";
                ConsumL.Text = "kWh/100 km";
            }
            else
            {
                Val.Text = "l";
                ConsumL.Text = "l/100 km";
            }
            switch (TypTS.Text)
            {
                case "Tram":
//                    if (TypTS.Text == "Tram")
//                    {
                    w3.Checked = true;
                    w1.Enabled = false;
                    w2.Enabled = false;
                    w4.Enabled = false;
                    w5.Enabled = false;

                    if (Main.W3)
                    {
                        w3.Checked = false;
                        w3.Enabled = false;
                    }
                    break;
 //                   }
                case "Trolly":
 //                   if (TypTS.Text == "Trolly")
 //                   {
                        w1.Checked = true;
                        w2.Enabled = false;
                        w3.Enabled = false;
                        w4.Enabled = false;
                        w5.Enabled = false;
                    if (Main.W1)
                    {
                        w1.Checked = false;
                        w1.Enabled = false;
                    }
                    break;
//                    }
                default:
                    w3.Enabled = false;
                    if (Main.W1)
                    {
                        w1.Checked = false;
                        w1.Enabled = false;
                    }
                    if (Main.W2)
                    {
                        w2.Checked = false;
                        w2.Enabled = false;
                    }
                    if (Main.W4)
                    {
                        w4.Checked = false;
                        w4.Enabled = false;
                    }
                    if (Main.W5)
                    {
                        w5.Checked = false;
                        w5.Enabled = false;
                    }

                    break;
            }
        }

    }
}
