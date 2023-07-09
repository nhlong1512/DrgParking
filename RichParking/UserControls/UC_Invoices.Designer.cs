
namespace RichParking.UserControls
{
    partial class UC_Invoices
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Invoices));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaImageReplaceColor1 = new Guna.UI.WinForms.GunaImageReplaceColor(this.components);
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.inputSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtgvInvoice = new Guna.UI.WinForms.GunaDataGridView();
            this.btnLoadData = new Guna.UI.WinForms.GunaButton();
            this.btnPrintInvoice = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaImageReplaceColor1
            // 
            this.gunaImageReplaceColor1.Image = null;
            this.gunaImageReplaceColor1.NewColor = System.Drawing.Color.Empty;
            this.gunaImageReplaceColor1.OldColor = System.Drawing.Color.White;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 24;
            this.gunaElipse1.TargetControl = this;
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(120, 27);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 4;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(223, 32);
            this.gunaDateTimePicker1.TabIndex = 0;
            this.gunaDateTimePicker1.Text = "Sunday, July 9, 2023";
            this.gunaDateTimePicker1.Value = new System.DateTime(2023, 7, 9, 13, 17, 21, 880);
            // 
            // inputSearch
            // 
            this.inputSearch.BorderRadius = 15;
            this.inputSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSearch.DefaultText = "";
            this.inputSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputSearch.DisabledState.Parent = this.inputSearch;
            this.inputSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputSearch.FocusedState.Parent = this.inputSearch;
            this.inputSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputSearch.HoverState.Parent = this.inputSearch;
            this.inputSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("inputSearch.IconLeft")));
            this.inputSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.inputSearch.Location = new System.Drawing.Point(54, 74);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.PasswordChar = '\0';
            this.inputSearch.PlaceholderText = "Search an Invoice";
            this.inputSearch.SelectedText = "";
            this.inputSearch.ShadowDecoration.Parent = this.inputSearch;
            this.inputSearch.Size = new System.Drawing.Size(391, 40);
            this.inputSearch.TabIndex = 36;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(50, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 37;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(384, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 39;
            this.label2.Text = "To:";
            // 
            // gunaDateTimePicker2
            // 
            this.gunaDateTimePicker2.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker2.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker2.CustomFormat = null;
            this.gunaDateTimePicker2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.gunaDateTimePicker2.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Location = new System.Drawing.Point(427, 27);
            this.gunaDateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker2.Name = "gunaDateTimePicker2";
            this.gunaDateTimePicker2.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.gunaDateTimePicker2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker2.Radius = 4;
            this.gunaDateTimePicker2.Size = new System.Drawing.Size(223, 32);
            this.gunaDateTimePicker2.TabIndex = 38;
            this.gunaDateTimePicker2.Text = "Sunday, July 9, 2023";
            this.gunaDateTimePicker2.Value = new System.DateTime(2023, 7, 9, 13, 17, 21, 880);
            // 
            // dtgvInvoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.dtgvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvInvoice.ColumnHeadersHeight = 30;
            this.dtgvInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvInvoice.EnableHeadersVisualStyles = false;
            this.dtgvInvoice.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInvoice.Location = new System.Drawing.Point(54, 134);
            this.dtgvInvoice.Name = "dtgvInvoice";
            this.dtgvInvoice.RowHeadersVisible = false;
            this.dtgvInvoice.RowHeadersWidth = 51;
            this.dtgvInvoice.RowTemplate.Height = 24;
            this.dtgvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvInvoice.Size = new System.Drawing.Size(853, 364);
            this.dtgvInvoice.TabIndex = 40;
            this.dtgvInvoice.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvInvoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInvoice.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvInvoice.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvInvoice.ThemeStyle.ReadOnly = false;
            this.dtgvInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvInvoice.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnLoadData
            // 
            this.btnLoadData.AnimationHoverSpeed = 0.07F;
            this.btnLoadData.AnimationSpeed = 0.03F;
            this.btnLoadData.BackColor = System.Drawing.Color.Transparent;
            this.btnLoadData.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnLoadData.BorderColor = System.Drawing.Color.Black;
            this.btnLoadData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadData.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoadData.FocusedColor = System.Drawing.Color.Empty;
            this.btnLoadData.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoadData.ForeColor = System.Drawing.Color.White;
            this.btnLoadData.Image = null;
            this.btnLoadData.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLoadData.Location = new System.Drawing.Point(481, 80);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnLoadData.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLoadData.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLoadData.OnHoverImage = null;
            this.btnLoadData.OnPressedColor = System.Drawing.Color.Black;
            this.btnLoadData.Radius = 16;
            this.btnLoadData.Size = new System.Drawing.Size(80, 30);
            this.btnLoadData.TabIndex = 47;
            this.btnLoadData.Text = "Load";
            this.btnLoadData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.AnimationHoverSpeed = 0.07F;
            this.btnPrintInvoice.AnimationSpeed = 0.03F;
            this.btnPrintInvoice.BackColor = System.Drawing.Color.Transparent;
            this.btnPrintInvoice.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnPrintInvoice.BorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintInvoice.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrintInvoice.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrintInvoice.ForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.Image = null;
            this.btnPrintInvoice.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrintInvoice.Location = new System.Drawing.Point(930, 134);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnPrintInvoice.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrintInvoice.OnHoverImage = null;
            this.btnPrintInvoice.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrintInvoice.Radius = 22;
            this.btnPrintInvoice.Size = new System.Drawing.Size(240, 50);
            this.btnPrintInvoice.TabIndex = 48;
            this.btnPrintInvoice.Text = "Print";
            this.btnPrintInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // UC_Invoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnPrintInvoice);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.dtgvInvoice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaDateTimePicker2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Name = "UC_Invoices";
            this.Size = new System.Drawing.Size(1200, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvInvoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaImageReplaceColor gunaImageReplaceColor1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox inputSearch;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDataGridView dtgvInvoice;
        private Guna.UI.WinForms.GunaButton btnLoadData;
        private Guna.UI.WinForms.GunaButton btnPrintInvoice;
    }
}
