namespace AutoEcole
{
    partial class AM_paiment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AM_paiment));
            this.Btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_numBon = new Guna.UI.WinForms.GunaLineTextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.cmb_participant = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_prix = new Guna.UI.WinForms.GunaLineTextBox();
            this.dtp_date = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_save
            // 
            this.Btn_save.BorderRadius = 15;
            this.Btn_save.CheckedState.Parent = this.Btn_save;
            this.Btn_save.CustomImages.Parent = this.Btn_save;
            this.Btn_save.FillColor = System.Drawing.Color.Green;
            this.Btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_save.ForeColor = System.Drawing.Color.White;
            this.Btn_save.HoverState.Parent = this.Btn_save;
            this.Btn_save.Location = new System.Drawing.Point(142, 415);
            this.Btn_save.Name = "Btn_save";
            this.Btn_save.ShadowDecoration.Parent = this.Btn_save;
            this.Btn_save.Size = new System.Drawing.Size(154, 45);
            this.Btn_save.TabIndex = 35;
            this.Btn_save.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(91, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "prix";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(91, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "participant";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(91, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "numero";
            // 
            // txt_numBon
            // 
            this.txt_numBon.BackColor = System.Drawing.SystemColors.Control;
            this.txt_numBon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_numBon.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txt_numBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numBon.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_numBon.Location = new System.Drawing.Point(91, 111);
            this.txt_numBon.Name = "txt_numBon";
            this.txt_numBon.PasswordChar = '\0';
            this.txt_numBon.SelectedText = "";
            this.txt_numBon.Size = new System.Drawing.Size(234, 38);
            this.txt_numBon.TabIndex = 25;
            this.txt_numBon.TextOffsetX = 10;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(375, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 36;
            this.guna2PictureBox1.TabStop = false;
            // 
            // cmb_participant
            // 
            this.cmb_participant.BackColor = System.Drawing.Color.Transparent;
            this.cmb_participant.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_participant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_participant.FocusedColor = System.Drawing.Color.Empty;
            this.cmb_participant.FocusedState.Parent = this.cmb_participant;
            this.cmb_participant.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_participant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmb_participant.FormattingEnabled = true;
            this.cmb_participant.HoverState.Parent = this.cmb_participant;
            this.cmb_participant.ItemHeight = 30;
            this.cmb_participant.ItemsAppearance.Parent = this.cmb_participant;
            this.cmb_participant.Location = new System.Drawing.Point(91, 180);
            this.cmb_participant.Name = "cmb_participant";
            this.cmb_participant.ShadowDecoration.Parent = this.cmb_participant;
            this.cmb_participant.Size = new System.Drawing.Size(234, 36);
            this.cmb_participant.TabIndex = 37;
            // 
            // txt_prix
            // 
            this.txt_prix.BackColor = System.Drawing.SystemColors.Control;
            this.txt_prix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_prix.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(27)))), ((int)(((byte)(35)))));
            this.txt_prix.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prix.LineColor = System.Drawing.Color.Gainsboro;
            this.txt_prix.Location = new System.Drawing.Point(91, 247);
            this.txt_prix.Name = "txt_prix";
            this.txt_prix.PasswordChar = '\0';
            this.txt_prix.SelectedText = "";
            this.txt_prix.Size = new System.Drawing.Size(234, 41);
            this.txt_prix.TabIndex = 38;
            this.txt_prix.TextOffsetX = 10;
            // 
            // dtp_date
            // 
            this.dtp_date.BorderRadius = 5;
            this.dtp_date.CheckedState.Parent = this.dtp_date;
            this.dtp_date.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_date.HoverState.Parent = this.dtp_date;
            this.dtp_date.Location = new System.Drawing.Point(91, 319);
            this.dtp_date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.ShadowDecoration.Parent = this.dtp_date;
            this.dtp_date.Size = new System.Drawing.Size(234, 42);
            this.dtp_date.TabIndex = 39;
            this.dtp_date.Value = new System.DateTime(2022, 2, 7, 20, 59, 16, 801);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(91, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Date";
            // 
            // AM_paiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.txt_prix);
            this.Controls.Add(this.cmb_participant);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.Btn_save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_numBon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AM_paiment";
            this.Text = "AM_paiment";
            this.Load += new System.EventHandler(this.AM_paiment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button Btn_save;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaLineTextBox txt_numBon;
        private Guna.UI2.WinForms.Guna2ComboBox cmb_participant;
        private Guna.UI.WinForms.GunaLineTextBox txt_prix;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_date;
        private System.Windows.Forms.Label label3;
    }
}