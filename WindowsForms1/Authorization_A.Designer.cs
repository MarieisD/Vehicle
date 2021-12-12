
namespace WindowsForms1
{
    partial class Authorization_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Authorization_A));
            this.logButton = new System.Windows.Forms.Button();
            this.passA = new System.Windows.Forms.TextBox();
            this.logBoxA = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.logButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logButton.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.logButton.FlatAppearance.BorderSize = 0;
            this.logButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.logButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.logButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logButton.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.logButton.Location = new System.Drawing.Point(204, 564);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(212, 47);
            this.logButton.TabIndex = 23;
            this.logButton.Text = "Entrance";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click);
            // 
            // passA
            // 
            this.passA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passA.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passA.Location = new System.Drawing.Point(151, 445);
            this.passA.Name = "passA";
            this.passA.PasswordChar = '*';
            this.passA.Size = new System.Drawing.Size(314, 100);
            this.passA.TabIndex = 22;
            this.passA.UseSystemPasswordChar = true;
            // 
            // logBoxA
            // 
            this.logBoxA.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logBoxA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logBoxA.Font = new System.Drawing.Font("Mongolian Baiti", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBoxA.Location = new System.Drawing.Point(151, 292);
            this.logBoxA.Multiline = true;
            this.logBoxA.Name = "logBoxA";
            this.logBoxA.Size = new System.Drawing.Size(314, 53);
            this.logBoxA.TabIndex = 21;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsForms1.Properties.Resources.construction_project_plan_building_architect_design_develop_77_icon_icons_com_60235;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(21, 431);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 84);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsForms1.Properties.Resources.builder_24_icon_icons_com_60367;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(23, 276);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 85);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label1.Location = new System.Drawing.Point(136, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1154, 207);
            this.label1.TabIndex = 18;
            this.label1.Text = "Authorization";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 80);
            this.label2.TabIndex = 24;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.label2_MouseEnter);
            this.label2.MouseLeave += new System.EventHandler(this.label2_MouseLeave);
            // 
            // Authorization_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.BackgroundImage = global::WindowsForms1.Properties.Resources._1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1154, 682);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logButton);
            this.Controls.Add(this.passA);
            this.Controls.Add(this.logBoxA);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Authorization_A";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Authorization_A_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button logButton;
        private System.Windows.Forms.TextBox passA;
        private System.Windows.Forms.TextBox logBoxA;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}