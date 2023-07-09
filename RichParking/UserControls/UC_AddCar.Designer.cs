
namespace RichParking.UserControls
{
    partial class UC_AddCar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_AddCar));
            this.btnCarOut = new Guna.UI.WinForms.GunaButton();
            this.btnAddCar = new Guna.UI.WinForms.GunaButton();
            this.label4 = new System.Windows.Forms.Label();
            this.ckBoxOilChange = new Guna.UI.WinForms.GunaCheckBox();
            this.ckBoxWash = new Guna.UI.WinForms.GunaCheckBox();
            this.rbtnVan = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtnCar7 = new Guna.UI.WinForms.GunaRadioButton();
            this.rbtnCar = new Guna.UI.WinForms.GunaRadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.inputLicensePlate = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvCar = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.inputSearch = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCarOut
            // 
            this.btnCarOut.AnimationHoverSpeed = 0.07F;
            this.btnCarOut.AnimationSpeed = 0.03F;
            this.btnCarOut.BackColor = System.Drawing.Color.Transparent;
            this.btnCarOut.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnCarOut.BorderColor = System.Drawing.Color.Black;
            this.btnCarOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCarOut.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCarOut.FocusedColor = System.Drawing.Color.Empty;
            this.btnCarOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnCarOut.ForeColor = System.Drawing.Color.White;
            this.btnCarOut.Image = null;
            this.btnCarOut.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCarOut.Location = new System.Drawing.Point(854, 353);
            this.btnCarOut.Name = "btnCarOut";
            this.btnCarOut.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnCarOut.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCarOut.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCarOut.OnHoverImage = null;
            this.btnCarOut.OnPressedColor = System.Drawing.Color.Black;
            this.btnCarOut.Radius = 22;
            this.btnCarOut.Size = new System.Drawing.Size(240, 50);
            this.btnCarOut.TabIndex = 47;
            this.btnCarOut.Text = "Car Out";
            this.btnCarOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCarOut.Click += new System.EventHandler(this.btnCarOut_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.AnimationHoverSpeed = 0.07F;
            this.btnAddCar.AnimationSpeed = 0.03F;
            this.btnAddCar.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCar.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnAddCar.BorderColor = System.Drawing.Color.Black;
            this.btnAddCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddCar.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnAddCar.ForeColor = System.Drawing.Color.White;
            this.btnAddCar.Image = null;
            this.btnAddCar.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddCar.Location = new System.Drawing.Point(854, 289);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.btnAddCar.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddCar.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddCar.OnHoverImage = null;
            this.btnAddCar.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddCar.Radius = 22;
            this.btnAddCar.Size = new System.Drawing.Size(240, 50);
            this.btnAddCar.TabIndex = 46;
            this.btnAddCar.Text = "Car In";
            this.btnAddCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(710, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Services";
            // 
            // ckBoxOilChange
            // 
            this.ckBoxOilChange.BaseColor = System.Drawing.Color.White;
            this.ckBoxOilChange.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckBoxOilChange.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ckBoxOilChange.FillColor = System.Drawing.Color.White;
            this.ckBoxOilChange.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ckBoxOilChange.Location = new System.Drawing.Point(997, 221);
            this.ckBoxOilChange.Name = "ckBoxOilChange";
            this.ckBoxOilChange.Size = new System.Drawing.Size(203, 29);
            this.ckBoxOilChange.TabIndex = 44;
            this.ckBoxOilChange.Text = "Change Oil (50$)";
            // 
            // ckBoxWash
            // 
            this.ckBoxWash.BaseColor = System.Drawing.Color.White;
            this.ckBoxWash.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckBoxWash.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ckBoxWash.FillColor = System.Drawing.Color.White;
            this.ckBoxWash.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.ckBoxWash.Location = new System.Drawing.Point(859, 221);
            this.ckBoxWash.Name = "ckBoxWash";
            this.ckBoxWash.Size = new System.Drawing.Size(142, 29);
            this.ckBoxWash.TabIndex = 43;
            this.ckBoxWash.Text = "Wash (10$)";
            // 
            // rbtnVan
            // 
            this.rbtnVan.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtnVan.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnVan.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rbtnVan.FillColor = System.Drawing.Color.White;
            this.rbtnVan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnVan.Location = new System.Drawing.Point(1098, 168);
            this.rbtnVan.Name = "rbtnVan";
            this.rbtnVan.Size = new System.Drawing.Size(85, 29);
            this.rbtnVan.TabIndex = 42;
            this.rbtnVan.Text = "Truck";
            // 
            // rbtnCar7
            // 
            this.rbtnCar7.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtnCar7.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnCar7.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rbtnCar7.FillColor = System.Drawing.Color.White;
            this.rbtnCar7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnCar7.Location = new System.Drawing.Point(937, 172);
            this.rbtnCar7.Name = "rbtnCar7";
            this.rbtnCar7.Size = new System.Drawing.Size(155, 29);
            this.rbtnCar7.TabIndex = 41;
            this.rbtnCar7.Text = "7 Seater Car";
            // 
            // rbtnCar
            // 
            this.rbtnCar.BaseColor = System.Drawing.SystemColors.Control;
            this.rbtnCar.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbtnCar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.rbtnCar.FillColor = System.Drawing.Color.White;
            this.rbtnCar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.rbtnCar.Location = new System.Drawing.Point(862, 172);
            this.rbtnCar.Name = "rbtnCar";
            this.rbtnCar.Size = new System.Drawing.Size(69, 29);
            this.rbtnCar.TabIndex = 40;
            this.rbtnCar.Text = "Car";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(710, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 23);
            this.label3.TabIndex = 39;
            this.label3.Text = "Car Type";
            // 
            // inputLicensePlate
            // 
            this.inputLicensePlate.BorderRadius = 15;
            this.inputLicensePlate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputLicensePlate.DefaultText = "";
            this.inputLicensePlate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.inputLicensePlate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.inputLicensePlate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputLicensePlate.DisabledState.Parent = this.inputLicensePlate;
            this.inputLicensePlate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.inputLicensePlate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputLicensePlate.FocusedState.Parent = this.inputLicensePlate;
            this.inputLicensePlate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.inputLicensePlate.HoverState.Parent = this.inputLicensePlate;
            this.inputLicensePlate.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.inputLicensePlate.Location = new System.Drawing.Point(854, 108);
            this.inputLicensePlate.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputLicensePlate.Name = "inputLicensePlate";
            this.inputLicensePlate.PasswordChar = '\0';
            this.inputLicensePlate.PlaceholderText = "59A-12345";
            this.inputLicensePlate.SelectedText = "";
            this.inputLicensePlate.ShadowDecoration.Parent = this.inputLicensePlate;
            this.inputLicensePlate.Size = new System.Drawing.Size(285, 40);
            this.inputLicensePlate.TabIndex = 38;
            // 
            // dtgvCar
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dtgvCar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgvCar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvCar.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgvCar.ColumnHeadersHeight = 30;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCar.DefaultCellStyle = dataGridViewCellStyle15;
            this.dtgvCar.EnableHeadersVisualStyles = false;
            this.dtgvCar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCar.Location = new System.Drawing.Point(8, 113);
            this.dtgvCar.Name = "dtgvCar";
            this.dtgvCar.RowHeadersVisible = false;
            this.dtgvCar.RowHeadersWidth = 51;
            this.dtgvCar.RowTemplate.Height = 24;
            this.dtgvCar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCar.Size = new System.Drawing.Size(693, 364);
            this.dtgvCar.TabIndex = 37;
            this.dtgvCar.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dtgvCar.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCar.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvCar.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvCar.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvCar.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvCar.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCar.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCar.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(255)))));
            this.dtgvCar.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvCar.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCar.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvCar.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvCar.ThemeStyle.HeaderStyle.Height = 30;
            this.dtgvCar.ThemeStyle.ReadOnly = false;
            this.dtgvCar.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvCar.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvCar.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgvCar.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvCar.ThemeStyle.RowsStyle.Height = 24;
            this.dtgvCar.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvCar.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvCar.SelectionChanged += new System.EventHandler(this.dtgvCar_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(482, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 32);
            this.label2.TabIndex = 36;
            this.label2.Text = "Car Parking Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(710, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "License Plate";
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 26;
            this.gunaElipse1.TargetControl = this;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
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
            this.inputSearch.Location = new System.Drawing.Point(8, 63);
            this.inputSearch.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.inputSearch.Name = "inputSearch";
            this.inputSearch.PasswordChar = '\0';
            this.inputSearch.PlaceholderText = "Search a Car";
            this.inputSearch.SelectedText = "";
            this.inputSearch.ShadowDecoration.Parent = this.inputSearch;
            this.inputSearch.Size = new System.Drawing.Size(456, 40);
            this.inputSearch.TabIndex = 35;
            this.inputSearch.TextChanged += new System.EventHandler(this.inputSearch_TextChanged);
            // 
            // UC_AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnCarOut);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ckBoxOilChange);
            this.Controls.Add(this.ckBoxWash);
            this.Controls.Add(this.rbtnVan);
            this.Controls.Add(this.rbtnCar7);
            this.Controls.Add(this.rbtnCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputLicensePlate);
            this.Controls.Add(this.dtgvCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputSearch);
            this.Controls.Add(this.label1);
            this.Name = "UC_AddCar";
            this.Size = new System.Drawing.Size(1200, 570);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnCarOut;
        private Guna.UI.WinForms.GunaButton btnAddCar;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaCheckBox ckBoxOilChange;
        private Guna.UI.WinForms.GunaCheckBox ckBoxWash;
        private Guna.UI.WinForms.GunaRadioButton rbtnVan;
        private Guna.UI.WinForms.GunaRadioButton rbtnCar7;
        private Guna.UI.WinForms.GunaRadioButton rbtnCar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox inputLicensePlate;
        private Guna.UI.WinForms.GunaDataGridView dtgvCar;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox inputSearch;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}
