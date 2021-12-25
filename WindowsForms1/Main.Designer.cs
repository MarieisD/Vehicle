
namespace WindowsForms1
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chooseAVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorbikeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PM = new System.Windows.Forms.ToolStripMenuItem();
            this.carToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PC = new System.Windows.Forms.ToolStripMenuItem();
            this.DC = new System.Windows.Forms.ToolStripMenuItem();
            this.GC = new System.Windows.Forms.ToolStripMenuItem();
            this.EC = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DB = new System.Windows.Forms.ToolStripMenuItem();
            this.trolleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ET = new System.Windows.Forms.ToolStripMenuItem();
            this.tramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ETram = new System.Windows.Forms.ToolStripMenuItem();
            this.truckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DTruck = new System.Windows.Forms.ToolStripMenuItem();
            this.tractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DT = new System.Windows.Forms.ToolStripMenuItem();
            this.checkResaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.C_D = new System.Windows.Forms.PictureBox();
            this.B_D = new System.Windows.Forms.PictureBox();
            this.C_P = new System.Windows.Forms.PictureBox();
            this.C_G = new System.Windows.Forms.PictureBox();
            this.C_E = new System.Windows.Forms.PictureBox();
            this.Truck = new System.Windows.Forms.PictureBox();
            this.Tram = new System.Windows.Forms.PictureBox();
            this.Tractor = new System.Windows.Forms.PictureBox();
            this.M_P = new System.Windows.Forms.PictureBox();
            this.T_E = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_D)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_G)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_E)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_P)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_E)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chooseAVehicleToolStripMenuItem,
            this.checkResaltToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1154, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chooseAVehicleToolStripMenuItem
            // 
            this.chooseAVehicleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorbikeToolStripMenuItem,
            this.carToolStripMenuItem,
            this.busToolStripMenuItem,
            this.trolleyToolStripMenuItem,
            this.tramToolStripMenuItem,
            this.truckToolStripMenuItem,
            this.tractorToolStripMenuItem});
            this.chooseAVehicleToolStripMenuItem.Name = "chooseAVehicleToolStripMenuItem";
            this.chooseAVehicleToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.chooseAVehicleToolStripMenuItem.Text = "Choose a vehicle";
            // 
            // motorbikeToolStripMenuItem
            // 
            this.motorbikeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PM});
            this.motorbikeToolStripMenuItem.Name = "motorbikeToolStripMenuItem";
            this.motorbikeToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.motorbikeToolStripMenuItem.Text = "Motorbike";
            // 
            // PM
            // 
            this.PM.Name = "PM";
            this.PM.Size = new System.Drawing.Size(211, 44);
            this.PM.Text = "patrol";
            this.PM.Click += new System.EventHandler(this.PM_Click);
            // 
            // carToolStripMenuItem
            // 
            this.carToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PC,
            this.DC,
            this.GC,
            this.EC});
            this.carToolStripMenuItem.Name = "carToolStripMenuItem";
            this.carToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.carToolStripMenuItem.Text = "Car";
            // 
            // PC
            // 
            this.PC.Name = "PC";
            this.PC.Size = new System.Drawing.Size(251, 44);
            this.PC.Text = "patrol";
            this.PC.Click += new System.EventHandler(this.PC_Click);
            // 
            // DC
            // 
            this.DC.Name = "DC";
            this.DC.Size = new System.Drawing.Size(251, 44);
            this.DC.Text = "diesel";
            this.DC.Click += new System.EventHandler(this.DC_Click);
            // 
            // GC
            // 
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(251, 44);
            this.GC.Text = "gas";
            this.GC.Click += new System.EventHandler(this.GC_Click);
            // 
            // EC
            // 
            this.EC.Name = "EC";
            this.EC.Size = new System.Drawing.Size(251, 44);
            this.EC.Text = "electricity";
            this.EC.Click += new System.EventHandler(this.EC_Click);
            // 
            // busToolStripMenuItem
            // 
            this.busToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DB});
            this.busToolStripMenuItem.Name = "busToolStripMenuItem";
            this.busToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.busToolStripMenuItem.Text = "Bus";
            // 
            // DB
            // 
            this.DB.Name = "DB";
            this.DB.Size = new System.Drawing.Size(211, 44);
            this.DB.Text = "diesel";
            this.DB.Click += new System.EventHandler(this.DB_Click);
            // 
            // trolleyToolStripMenuItem
            // 
            this.trolleyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ET});
            this.trolleyToolStripMenuItem.Name = "trolleyToolStripMenuItem";
            this.trolleyToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.trolleyToolStripMenuItem.Text = "Trolley";
            // 
            // ET
            // 
            this.ET.Name = "ET";
            this.ET.Size = new System.Drawing.Size(251, 44);
            this.ET.Text = "electricity";
            this.ET.Click += new System.EventHandler(this.ET_Click);
            // 
            // tramToolStripMenuItem
            // 
            this.tramToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ETram});
            this.tramToolStripMenuItem.Name = "tramToolStripMenuItem";
            this.tramToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.tramToolStripMenuItem.Text = "Tram";
            // 
            // ETram
            // 
            this.ETram.Name = "ETram";
            this.ETram.Size = new System.Drawing.Size(251, 44);
            this.ETram.Text = "electricity";
            this.ETram.Click += new System.EventHandler(this.ETram_Click);
            // 
            // truckToolStripMenuItem
            // 
            this.truckToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DTruck});
            this.truckToolStripMenuItem.Name = "truckToolStripMenuItem";
            this.truckToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.truckToolStripMenuItem.Text = "Truck";
            // 
            // DTruck
            // 
            this.DTruck.Name = "DTruck";
            this.DTruck.Size = new System.Drawing.Size(211, 44);
            this.DTruck.Text = "diesel";
            this.DTruck.Click += new System.EventHandler(this.DTruck_Click);
            // 
            // tractorToolStripMenuItem
            // 
            this.tractorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DT});
            this.tractorToolStripMenuItem.Name = "tractorToolStripMenuItem";
            this.tractorToolStripMenuItem.Size = new System.Drawing.Size(260, 44);
            this.tractorToolStripMenuItem.Text = "Tractor";
            // 
            // DT
            // 
            this.DT.Name = "DT";
            this.DT.Size = new System.Drawing.Size(211, 44);
            this.DT.Text = "diesel";
            this.DT.Click += new System.EventHandler(this.DT_Click);
            // 
            // checkResaltToolStripMenuItem
            // 
            this.checkResaltToolStripMenuItem.Name = "checkResaltToolStripMenuItem";
            this.checkResaltToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.checkResaltToolStripMenuItem.Text = "Check result";
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.LimeGreen;
            this.Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.Start.FlatAppearance.BorderSize = 0;
            this.Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.Start.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleGreen;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Start.Location = new System.Drawing.Point(137, 7);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(73, 38);
            this.Start.TabIndex = 12;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.Red;
            this.Stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Stop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.Stop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Stop.Location = new System.Drawing.Point(264, 6);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(73, 38);
            this.Stop.TabIndex = 13;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(26, -10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 138);
            this.label2.TabIndex = 26;
            this.label2.Text = "<";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 632);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 50);
            this.panel1.TabIndex = 0;
            // 
            // C_D
            // 
            this.C_D.BackColor = System.Drawing.Color.Transparent;
            this.C_D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C_D.BackgroundImage")));
            this.C_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C_D.Location = new System.Drawing.Point(0, 400);
            this.C_D.Name = "C_D";
            this.C_D.Size = new System.Drawing.Size(55, 35);
            this.C_D.TabIndex = 22;
            this.C_D.TabStop = false;
            this.C_D.Visible = false;
            // 
            // B_D
            // 
            this.B_D.BackColor = System.Drawing.Color.Transparent;
            this.B_D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("B_D.BackgroundImage")));
            this.B_D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.B_D.Location = new System.Drawing.Point(0, 570);
            this.B_D.Name = "B_D";
            this.B_D.Size = new System.Drawing.Size(65, 35);
            this.B_D.TabIndex = 23;
            this.B_D.TabStop = false;
            this.B_D.Visible = false;
            // 
            // C_P
            // 
            this.C_P.BackColor = System.Drawing.Color.Transparent;
            this.C_P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C_P.BackgroundImage")));
            this.C_P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C_P.Location = new System.Drawing.Point(0, 510);
            this.C_P.Name = "C_P";
            this.C_P.Size = new System.Drawing.Size(55, 35);
            this.C_P.TabIndex = 24;
            this.C_P.TabStop = false;
            this.C_P.Visible = false;
            // 
            // C_G
            // 
            this.C_G.BackColor = System.Drawing.Color.Transparent;
            this.C_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C_G.BackgroundImage")));
            this.C_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C_G.Location = new System.Drawing.Point(0, 350);
            this.C_G.Name = "C_G";
            this.C_G.Size = new System.Drawing.Size(55, 35);
            this.C_G.TabIndex = 25;
            this.C_G.TabStop = false;
            this.C_G.Visible = false;
            this.C_G.Click += new System.EventHandler(this.C_G_Click);
            // 
            // C_E
            // 
            this.C_E.BackColor = System.Drawing.Color.Transparent;
            this.C_E.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("C_E.BackgroundImage")));
            this.C_E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.C_E.Location = new System.Drawing.Point(84, 578);
            this.C_E.Name = "C_E";
            this.C_E.Size = new System.Drawing.Size(55, 35);
            this.C_E.TabIndex = 26;
            this.C_E.TabStop = false;
            this.C_E.Visible = false;
            // 
            // Truck
            // 
            this.Truck.BackColor = System.Drawing.Color.Transparent;
            this.Truck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Truck.BackgroundImage")));
            this.Truck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Truck.Location = new System.Drawing.Point(74, 396);
            this.Truck.Name = "Truck";
            this.Truck.Size = new System.Drawing.Size(65, 35);
            this.Truck.TabIndex = 27;
            this.Truck.TabStop = false;
            this.Truck.Visible = false;
            // 
            // Tram
            // 
            this.Tram.BackColor = System.Drawing.Color.Transparent;
            this.Tram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tram.BackgroundImage")));
            this.Tram.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tram.Location = new System.Drawing.Point(0, 450);
            this.Tram.Name = "Tram";
            this.Tram.Size = new System.Drawing.Size(65, 35);
            this.Tram.TabIndex = 28;
            this.Tram.TabStop = false;
            this.Tram.Visible = false;
            // 
            // Tractor
            // 
            this.Tractor.BackColor = System.Drawing.Color.Transparent;
            this.Tractor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Tractor.BackgroundImage")));
            this.Tractor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Tractor.Location = new System.Drawing.Point(74, 514);
            this.Tractor.Name = "Tractor";
            this.Tractor.Size = new System.Drawing.Size(65, 35);
            this.Tractor.TabIndex = 29;
            this.Tractor.TabStop = false;
            this.Tractor.Visible = false;
            // 
            // M_P
            // 
            this.M_P.BackColor = System.Drawing.Color.Transparent;
            this.M_P.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("M_P.BackgroundImage")));
            this.M_P.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.M_P.Location = new System.Drawing.Point(145, 514);
            this.M_P.Name = "M_P";
            this.M_P.Size = new System.Drawing.Size(65, 35);
            this.M_P.TabIndex = 30;
            this.M_P.TabStop = false;
            this.M_P.Visible = false;
            // 
            // T_E
            // 
            this.T_E.BackColor = System.Drawing.Color.Transparent;
            this.T_E.BackgroundImage = global::WindowsForms1.Properties.Resources.T_E;
            this.T_E.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.T_E.Location = new System.Drawing.Point(74, 349);
            this.T_E.Name = "T_E";
            this.T_E.Size = new System.Drawing.Size(65, 35);
            this.T_E.TabIndex = 31;
            this.T_E.TabStop = false;
            this.T_E.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1154, 682);
            this.Controls.Add(this.T_E);
            this.Controls.Add(this.M_P);
            this.Controls.Add(this.Tractor);
            this.Controls.Add(this.Tram);
            this.Controls.Add(this.Truck);
            this.Controls.Add(this.C_E);
            this.Controls.Add(this.C_G);
            this.Controls.Add(this.C_P);
            this.Controls.Add(this.B_D);
            this.Controls.Add(this.C_D);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.C_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.B_D)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_G)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.C_E)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Truck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.M_P)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.T_E)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chooseAVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorbikeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trolleyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem truckToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkResaltToolStripMenuItem;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem PM;
        private System.Windows.Forms.ToolStripMenuItem PC;
        private System.Windows.Forms.ToolStripMenuItem DC;
        private System.Windows.Forms.ToolStripMenuItem GC;
        private System.Windows.Forms.ToolStripMenuItem EC;
        private System.Windows.Forms.ToolStripMenuItem DB;
        private System.Windows.Forms.ToolStripMenuItem ET;
        private System.Windows.Forms.ToolStripMenuItem ETram;
        private System.Windows.Forms.ToolStripMenuItem DTruck;
        private System.Windows.Forms.ToolStripMenuItem DT;
        public System.Windows.Forms.PictureBox C_D;
        public System.Windows.Forms.PictureBox B_D;
        public System.Windows.Forms.PictureBox C_P;
        public System.Windows.Forms.PictureBox C_G;
        public System.Windows.Forms.PictureBox C_E;
        public System.Windows.Forms.PictureBox Truck;
        public System.Windows.Forms.PictureBox Tram;
        public System.Windows.Forms.PictureBox Tractor;
        public System.Windows.Forms.PictureBox M_P;
        public System.Windows.Forms.PictureBox T_E;
        private System.Windows.Forms.Timer timer1;
    }
}