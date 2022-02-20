namespace AutoEcole
{
    partial class F_List_Paimant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_List_Paimant));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.guna2DateTimePicker2 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.BtnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dgv_paiement = new Guna.UI2.WinForms.Guna2DataGridView();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.update = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paiement)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel2.Location = new System.Drawing.Point(570, 131);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(16, 18);
            this.gunaLabel2.TabIndex = 44;
            this.gunaLabel2.Text = "a";
            // 
            // guna2DateTimePicker2
            // 
            this.guna2DateTimePicker2.BorderRadius = 5;
            this.guna2DateTimePicker2.CheckedState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker2.HoverState.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Location = new System.Drawing.Point(588, 124);
            this.guna2DateTimePicker2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker2.Name = "guna2DateTimePicker2";
            this.guna2DateTimePicker2.ShadowDecoration.Parent = this.guna2DateTimePicker2;
            this.guna2DateTimePicker2.Size = new System.Drawing.Size(181, 36);
            this.guna2DateTimePicker2.TabIndex = 43;
            this.guna2DateTimePicker2.Value = new System.DateTime(2022, 2, 7, 20, 59, 16, 801);
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 5;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(373, 124);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(195, 36);
            this.guna2DateTimePicker1.TabIndex = 42;
            this.guna2DateTimePicker1.Value = new System.DateTime(2022, 2, 7, 20, 59, 16, 801);
            // 
            // BtnAdd
            // 
            this.BtnAdd.AnimationHoverSpeed = 0.07F;
            this.BtnAdd.AnimationSpeed = 0.03F;
            this.BtnAdd.BackColor = System.Drawing.Color.Transparent;
            this.BtnAdd.BaseColor = System.Drawing.Color.LimeGreen;
            this.BtnAdd.BorderColor = System.Drawing.Color.Black;
            this.BtnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.BtnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.BtnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.BtnAdd.CheckedImage = ((System.Drawing.Image)(resources.GetObject("BtnAdd.CheckedImage")));
            this.BtnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.BtnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.BtnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd.Image")));
            this.BtnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.BtnAdd.LineColor = System.Drawing.Color.LimeGreen;
            this.BtnAdd.Location = new System.Drawing.Point(682, 40);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.OnHoverBaseColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BtnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.BtnAdd.OnHoverImage = null;
            this.BtnAdd.OnHoverLineColor = System.Drawing.Color.ForestGreen;
            this.BtnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.BtnAdd.Radius = 12;
            this.BtnAdd.Size = new System.Drawing.Size(87, 42);
            this.BtnAdd.TabIndex = 41;
            this.BtnAdd.Text = "ADD";
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dgv_paiement
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_paiement.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_paiement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_paiement.BackgroundColor = System.Drawing.Color.White;
            this.dgv_paiement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_paiement.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_paiement.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_paiement.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_paiement.ColumnHeadersHeight = 30;
            this.dgv_paiement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.update});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_paiement.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_paiement.EnableHeadersVisualStyles = false;
            this.dgv_paiement.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_paiement.Location = new System.Drawing.Point(90, 175);
            this.dgv_paiement.Name = "dgv_paiement";
            this.dgv_paiement.RowHeadersVisible = false;
            this.dgv_paiement.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_paiement.Size = new System.Drawing.Size(678, 304);
            this.dgv_paiement.TabIndex = 33;
            this.dgv_paiement.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgv_paiement.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_paiement.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_paiement.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_paiement.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_paiement.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_paiement.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_paiement.ThemeStyle.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_paiement.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.dgv_paiement.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_paiement.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_paiement.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_paiement.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_paiement.ThemeStyle.HeaderStyle.Height = 30;
            this.dgv_paiement.ThemeStyle.ReadOnly = false;
            this.dgv_paiement.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_paiement.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_paiement.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_paiement.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgv_paiement.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_paiement.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_paiement.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoSize = true;
            this.gunaLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.gunaLabel10.Location = new System.Drawing.Point(83, 40);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(115, 29);
            this.gunaLabel10.TabIndex = 40;
            this.gunaLabel10.Text = "Paiement";
            // 
            // guna2Button2
            // 
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(220, 506);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(49, 45);
            this.guna2Button2.TabIndex = 39;
            this.guna2Button2.Text = "<";
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.DimGray;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(588, 506);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(49, 45);
            this.guna2Button1.TabIndex = 38;
            this.guna2Button1.Text = ">";
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator2.Location = new System.Drawing.Point(275, 519);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator2.TabIndex = 37;
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(458, 519);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(147, 10);
            this.gunaSeparator1.TabIndex = 36;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(428, 506);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(24, 25);
            this.gunaLabel1.TabIndex = 35;
            this.gunaLabel1.Text = "1";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderRadius = 5;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "Search";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.IconLeft = global::AutoEcole.Properties.Resources.search_48px;
            this.guna2TextBox1.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TextBox1.Location = new System.Drawing.Point(90, 124);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.SelectionStart = 6;
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(277, 36);
            this.guna2TextBox1.TabIndex = 34;
            // 
            // update
            // 
            this.update.HeaderText = "";
            this.update.Name = "update";
            // 
            // F_List_Paimant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 591);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.guna2DateTimePicker2);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dgv_paiement);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.gunaSeparator2);
            this.Controls.Add(this.gunaSeparator1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.guna2TextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_List_Paimant";
            this.Text = "F_List_Paimant";
            this.Load += new System.EventHandler(this.F_List_Paimant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_paiement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI.WinForms.GunaAdvenceButton BtnAdd;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_paiement;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridViewImageColumn update;
    }
}