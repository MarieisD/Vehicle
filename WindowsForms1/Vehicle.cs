using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public abstract class Vehicle
    {
        protected string TS;
        protected string typeFuel;
        protected double speedMin;
        protected double speedMax;
        protected double consumption;
        protected double capacity;
        protected int way;
        protected double speed;
        protected Image imgTS;
        protected PictureBox boxTS;
        protected bool start;
        protected int posX;
        protected int posY;
        protected int sizX;
        protected int sizY;
        protected Main m1;

        public Vehicle(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W)
        {
            m1 = M1;
            TS = pTS;
            typeFuel = TF;
            speedMin = Convert.ToDouble(sMin);
            speedMax = Convert.ToDouble(sMax);
            consumption = Convert.ToDouble(cons);
            capacity = Convert.ToDouble(cap);
            way = Convert.ToInt32(W);

        }
//        public int X { get; set; }
//        public int Y { get; set; }
        public void Draw(Graphics e)
        {
            e.DrawImage(imgTS, posX, posY, sizX, sizY);
        }
        protected abstract void Move();
        public abstract void StartTS();
        public abstract void StopTS();
        public void SaveTS()
        {

        }
        public void Refresh(Graphics gr)
        {
            Move();
            Draw(gr);
        }
    }
    public class Car : Vehicle
    {
        public Car(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base (M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            switch (way)
            {
                case 1:
                    posY = 350;
                    break;
                case 2:
                    posY = 400;
                    break;
                case 4:
                    posY = 510;
                    break;
                case 5:
                    posY = 570;
                    break;
            }

            switch (typeFuel)
            {
                case "Petrol":
                    boxTS = new PictureBox();
                    boxTS.BackgroundImage = m1.C_P.BackgroundImage;
                    boxTS.BackColor = m1.C_P.BackColor;
                    boxTS.BackgroundImageLayout = m1.C_P.BackgroundImageLayout;
                    boxTS.Visible = true;
                    boxTS.Location = new Point(0, posY);
                    boxTS.Size = new Size(55, 35);
                    m1.Controls.Add(boxTS);
                    break;
                case "Gas":
                    boxTS = new PictureBox();
                    boxTS.BackgroundImage = m1.C_G.BackgroundImage;
                    boxTS.BackColor = m1.C_G.BackColor;
                    boxTS.BackgroundImageLayout = m1.C_G.BackgroundImageLayout;
                    boxTS.Visible = true;
                    boxTS.Location = new Point(0, posY);
                    boxTS.Size = new Size(55, 35);
                    m1.Controls.Add(boxTS);
                    break;
                case "Electrisity":
                    boxTS = new PictureBox();
                    boxTS.BackgroundImage = m1.C_E.BackgroundImage;
                    boxTS.BackColor = m1.C_E.BackColor;
                    boxTS.BackgroundImageLayout = m1.C_E.BackgroundImageLayout;
                    boxTS.Visible = true;
                    boxTS.Location = new Point(0, posY);
                    boxTS.Size = new Size(55, 35);
                    m1.Controls.Add(boxTS);
                    break;
                case "Diesel":
                    boxTS = new PictureBox();
                    boxTS.BackgroundImage = m1.C_D.BackgroundImage;
                    boxTS.BackColor = m1.C_D.BackColor;
                    boxTS.BackgroundImageLayout = m1.C_D.BackgroundImageLayout;
                    boxTS.Visible = true;
                    boxTS.Location = new Point(0, posY);
                    boxTS.Size = new Size(55, 35);
                    m1.Controls.Add(boxTS);
                    break;
                default:
                    break;
            }

            posX = 0;
//            sizX = 55;
//            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Tram : Vehicle
    {
        public Tram(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            posY = 450;
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.Tram.BackgroundImage;
            boxTS.BackColor = m1.Tram.BackColor;
            boxTS.BackgroundImageLayout = m1.Tram.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Bike : Vehicle
    {
        public Bike(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            switch (way)
            {
                case 1:
                    posY = 350;
                    break;
                case 2:
                    posY = 400;
                    break;
                case 4:
                    posY = 510;
                    break;
                case 5:
                    posY = 570;
                    break;
            }
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.M_P.BackgroundImage;
            boxTS.BackColor = m1.M_P.BackColor;
            boxTS.BackgroundImageLayout = m1.M_P.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Troll : Vehicle
    {
        public Troll(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            posY = 350;
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.T_E.BackgroundImage;
            boxTS.BackColor = m1.T_E.BackColor;
            boxTS.BackgroundImageLayout = m1.T_E.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Truck : Vehicle
    {
        public Truck(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            switch (way)
            {
                case 1:
                    posY = 350;
                    break;
                case 2:
                    posY = 400;
                    break;
                case 4:
                    posY = 510;
                    break;
                case 5:
                    posY = 570;
                    break;
            }
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.Truck.BackgroundImage;
            boxTS.BackColor = m1.Truck.BackColor;
            boxTS.BackgroundImageLayout = m1.Truck.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Bus : Vehicle
    {
        public Bus(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            switch (way)
            {
                case 1:
                    posY = 350;
                    break;
                case 2:
                    posY = 400;
                    break;
                case 4:
                    posY = 510;
                    break;
                case 5:
                    posY = 570;
                    break;
            }
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.B_D.BackgroundImage;
            boxTS.BackColor = m1.B_D.BackColor;
            boxTS.BackgroundImageLayout = m1.B_D.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }
    public class Tractor : Vehicle
    {
        public Tractor(Main M1, string pTS, string TF, string sMin, string sMax, string cons, string cap, string W) :
                  base(M1, pTS, TF, sMin, sMax, cons, cap, W)
        {
            switch (way)
            {
                case 1:
                    posY = 350;
                    break;
                case 2:
                    posY = 400;
                    break;
                case 4:
                    posY = 510;
                    break;
                case 5:
                    posY = 570;
                    break;
            }
            boxTS = new PictureBox();
            boxTS.BackgroundImage = m1.Tractor.BackgroundImage;
            boxTS.BackColor = m1.Tractor.BackColor;
            boxTS.BackgroundImageLayout = m1.Tractor.BackgroundImageLayout;
            boxTS.Visible = true;
            boxTS.Location = new Point(0, posY);
            boxTS.Size = new Size(65, 35);
            m1.Controls.Add(boxTS);
            posX = 0;
            //            sizX = 55;
            //            sizY = 35;
            speed = speedMin;
        }
        protected override void Move()
        {
            int dP = (int)(3 + (speed - speedMin) / 10 * 2);
            posX += dP;
        }
        public override void StopTS()
        {
            throw new NotImplementedException();
        }
        public override void StartTS()
        {
            throw new NotImplementedException();
        }
    }

}
