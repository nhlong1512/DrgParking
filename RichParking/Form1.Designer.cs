namespace RichParking
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.uC_Invoices1 = new RichParking.UserControls.UC_Invoices();
            this.uC_AddCar1 = new RichParking.UserControls.UC_AddCar();
            this.uC_Statistics1 = new RichParking.UserControls.UC_Statistics();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button3);
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 608);
            this.panel1.TabIndex = 0;
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button3.BorderRadius = 22;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button3.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button3.CheckedState.Parent = this.guna2Button3;
            this.guna2Button3.CustomImages.Parent = this.guna2Button3;
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button3.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.HoverState.Parent = this.guna2Button3;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button3.Location = new System.Drawing.Point(23, 259);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.ShadowDecoration.Parent = this.guna2Button3;
            this.guna2Button3.Size = new System.Drawing.Size(149, 43);
            this.guna2Button3.TabIndex = 2;
            this.guna2Button3.Text = "Statistics";
            this.guna2Button3.UseTransparentBackground = true;
            this.guna2Button3.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button2.BorderRadius = 22;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button2.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.Location = new System.Drawing.Point(23, 196);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(149, 43);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "Invoices";
            this.guna2Button2.UseTransparentBackground = true;
            this.guna2Button2.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "RichParking";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 22;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.Checked = true;
            this.guna2Button1.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button1.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.Location = new System.Drawing.Point(23, 133);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(149, 43);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Add Car";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.CheckedChanged += new System.EventHandler(this.guna2Button1_CheckedChanged);
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Statistics1);
            this.panel2.Controls.Add(this.uC_Invoices1);
            this.panel2.Controls.Add(this.uC_AddCar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.panel2.Size = new System.Drawing.Size(1220, 608);
            this.panel2.TabIndex = 1;
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.CheckedState.Parent = this.guna2Button6;
            this.guna2Button6.CustomImages.Parent = this.guna2Button6;
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.HoverState.Parent = this.guna2Button6;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button6.Location = new System.Drawing.Point(50, 495);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.ShadowDecoration.Parent = this.guna2Button6;
            this.guna2Button6.Size = new System.Drawing.Size(97, 59);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(141, 103);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // uC_Invoices1
            // 
            this.uC_Invoices1.BackColor = System.Drawing.Color.White;
            this.uC_Invoices1.Location = new System.Drawing.Point(0, 18);
            this.uC_Invoices1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.uC_Invoices1.Name = "uC_Invoices1";
            this.uC_Invoices1.Size = new System.Drawing.Size(1200, 570);
            this.uC_Invoices1.TabIndex = 1;
            // 
            // uC_AddCar1
            // 
            this.uC_AddCar1.BackColor = System.Drawing.Color.White;
            this.uC_AddCar1.Location = new System.Drawing.Point(0, 18);
            this.uC_AddCar1.Margin = new System.Windows.Forms.Padding(30, 49, 30, 49);
            this.uC_AddCar1.Name = "uC_AddCar1";
            this.uC_AddCar1.Size = new System.Drawing.Size(1200, 570);
            this.uC_AddCar1.TabIndex = 0;
            // 
            // uC_Statistics1
            // 
            this.uC_Statistics1.BackColor = System.Drawing.Color.White;
            this.uC_Statistics1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.uC_Statistics1.Location = new System.Drawing.Point(0, 18);
            this.uC_Statistics1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Statistics1.Name = "uC_Statistics1";
            this.uC_Statistics1.Size = new System.Drawing.Size(1200, 570);
            this.uC_Statistics1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1400, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private System.Windows.Forms.Panel panel2;
        private UserControls.UC_AddCar uC_AddCar1;
        private System.Windows.Forms.Label label1;
        private UserControls.UC_Invoices uC_Invoices1;
        private UserControls.UC_Statistics uC_Statistics1;
    }
}

