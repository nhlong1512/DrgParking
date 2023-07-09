
namespace RichParking.UserControls
{
    partial class UC_Statistics
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.revenueChart = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.btnQtyType = new Guna.UI.WinForms.GunaButton();
            this.btnRevenue = new Guna.UI.WinForms.GunaButton();
            this.QtyCarTypeChart = new LiveCharts.WinForms.PieChart();
            this.txtQtyType = new System.Windows.Forms.Label();
            this.txtRevenue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 24;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // revenueChart
            // 
            this.revenueChart.Location = new System.Drawing.Point(51, 204);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Size = new System.Drawing.Size(1113, 342);
            this.revenueChart.TabIndex = 2;
            this.revenueChart.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(723, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 37);
            this.label3.TabIndex = 50;
            this.label3.Text = "Statistics";
            // 
            // btnQtyType
            // 
            this.btnQtyType.AnimationHoverSpeed = 0.07F;
            this.btnQtyType.AnimationSpeed = 0.03F;
            this.btnQtyType.BackColor = System.Drawing.Color.Transparent;
            this.btnQtyType.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnQtyType.BorderColor = System.Drawing.Color.Black;
            this.btnQtyType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQtyType.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnQtyType.FocusedColor = System.Drawing.Color.Empty;
            this.btnQtyType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnQtyType.ForeColor = System.Drawing.Color.White;
            this.btnQtyType.Image = null;
            this.btnQtyType.ImageSize = new System.Drawing.Size(20, 20);
            this.btnQtyType.Location = new System.Drawing.Point(274, 74);
            this.btnQtyType.Name = "btnQtyType";
            this.btnQtyType.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnQtyType.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnQtyType.OnHoverForeColor = System.Drawing.Color.White;
            this.btnQtyType.OnHoverImage = null;
            this.btnQtyType.OnPressedColor = System.Drawing.Color.Black;
            this.btnQtyType.Radius = 22;
            this.btnQtyType.Size = new System.Drawing.Size(282, 52);
            this.btnQtyType.TabIndex = 52;
            this.btnQtyType.Text = "Quantity Car Type";
            this.btnQtyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnQtyType.Click += new System.EventHandler(this.btnQtyType_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.AnimationHoverSpeed = 0.07F;
            this.btnRevenue.AnimationSpeed = 0.03F;
            this.btnRevenue.BackColor = System.Drawing.Color.Transparent;
            this.btnRevenue.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnRevenue.BorderColor = System.Drawing.Color.Black;
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRevenue.FocusedColor = System.Drawing.Color.Empty;
            this.btnRevenue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Image = null;
            this.btnRevenue.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRevenue.Location = new System.Drawing.Point(51, 74);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnRevenue.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRevenue.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRevenue.OnHoverImage = null;
            this.btnRevenue.OnPressedColor = System.Drawing.Color.Black;
            this.btnRevenue.Radius = 22;
            this.btnRevenue.Size = new System.Drawing.Size(208, 52);
            this.btnRevenue.TabIndex = 53;
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // QtyCarTypeChart
            // 
            this.QtyCarTypeChart.Location = new System.Drawing.Point(624, 164);
            this.QtyCarTypeChart.Name = "QtyCarTypeChart";
            this.QtyCarTypeChart.Size = new System.Drawing.Size(468, 313);
            this.QtyCarTypeChart.TabIndex = 54;
            this.QtyCarTypeChart.Text = "pieChart1";
            // 
            // txtQtyType
            // 
            this.txtQtyType.AutoSize = true;
            this.txtQtyType.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtyType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQtyType.Location = new System.Drawing.Point(556, 129);
            this.txtQtyType.Name = "txtQtyType";
            this.txtQtyType.Size = new System.Drawing.Size(472, 32);
            this.txtQtyType.TabIndex = 55;
            this.txtQtyType.Text = "Quantity of each vehicle type 2023";
            // 
            // txtRevenue
            // 
            this.txtRevenue.AutoSize = true;
            this.txtRevenue.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRevenue.Location = new System.Drawing.Point(604, 129);
            this.txtRevenue.Name = "txtRevenue";
            this.txtRevenue.Size = new System.Drawing.Size(359, 32);
            this.txtRevenue.TabIndex = 56;
            this.txtRevenue.Text = "Revenue by month in 2023";
            // 
            // UC_Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtRevenue);
            this.Controls.Add(this.txtQtyType);
            this.Controls.Add(this.QtyCarTypeChart);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnQtyType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.revenueChart);
            this.Name = "UC_Statistics";
            this.Size = new System.Drawing.Size(1200, 570);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private LiveCharts.WinForms.CartesianChart revenueChart;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnRevenue;
        private Guna.UI.WinForms.GunaButton btnQtyType;
        private LiveCharts.WinForms.PieChart QtyCarTypeChart;
        private System.Windows.Forms.Label txtQtyType;
        private System.Windows.Forms.Label txtRevenue;
    }
}
