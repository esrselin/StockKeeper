
namespace Form1
{
    partial class ListCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListCustomer));
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.UPGRADE = new System.Windows.Forms.Button();
            this.email = new System.Windows.Forms.TextBox();
            this.adress = new System.Windows.Forms.TextBox();
            this.CLEAR = new System.Windows.Forms.Button();
            this.phone = new System.Windows.Forms.TextBox();
            this.nameSurname = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DELETE = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.jGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Silver;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Controls.Add(this.ADD);
            this.jGradientPanel1.Controls.Add(this.panel2);
            this.jGradientPanel1.Controls.Add(this.label1);
            this.jGradientPanel1.Controls.Add(this.label15);
            this.jGradientPanel1.Controls.Add(this.label14);
            this.jGradientPanel1.Controls.Add(this.label13);
            this.jGradientPanel1.Controls.Add(this.UPGRADE);
            this.jGradientPanel1.Controls.Add(this.email);
            this.jGradientPanel1.Controls.Add(this.adress);
            this.jGradientPanel1.Controls.Add(this.CLEAR);
            this.jGradientPanel1.Controls.Add(this.phone);
            this.jGradientPanel1.Controls.Add(this.nameSurname);
            this.jGradientPanel1.Controls.Add(this.id);
            this.jGradientPanel1.Controls.Add(this.label12);
            this.jGradientPanel1.Controls.Add(this.label16);
            this.jGradientPanel1.Location = new System.Drawing.Point(-4, -6);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(328, 602);
            this.jGradientPanel1.TabIndex = 73;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(17, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 88;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 106;
            this.label1.Text = "CUSTOMER INFORMATIONS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 226);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 21);
            this.label15.TabIndex = 104;
            this.label15.Text = "Phone Number:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 375);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 21);
            this.label14.TabIndex = 103;
            this.label14.Text = "Adress:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 102;
            this.label13.Text = "Email:";
            // 
            // UPGRADE
            // 
            this.UPGRADE.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UPGRADE.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UPGRADE.ForeColor = System.Drawing.SystemColors.Window;
            this.UPGRADE.Location = new System.Drawing.Point(170, 470);
            this.UPGRADE.Name = "UPGRADE";
            this.UPGRADE.Size = new System.Drawing.Size(140, 45);
            this.UPGRADE.TabIndex = 94;
            this.UPGRADE.Text = "UPGRADE";
            this.UPGRADE.UseVisualStyleBackColor = false;
            this.UPGRADE.Click += new System.EventHandler(this.UPGRADE_Click);
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(170, 296);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(140, 22);
            this.email.TabIndex = 93;
            // 
            // adress
            // 
            this.adress.Location = new System.Drawing.Point(98, 376);
            this.adress.Multiline = true;
            this.adress.Name = "adress";
            this.adress.Size = new System.Drawing.Size(212, 77);
            this.adress.TabIndex = 91;
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CLEAR.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CLEAR.ForeColor = System.Drawing.SystemColors.Window;
            this.CLEAR.Location = new System.Drawing.Point(98, 535);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(126, 45);
            this.CLEAR.TabIndex = 90;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(170, 228);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(140, 22);
            this.phone.TabIndex = 87;
            // 
            // nameSurname
            // 
            this.nameSurname.Location = new System.Drawing.Point(170, 164);
            this.nameSurname.Multiline = true;
            this.nameSurname.Name = "nameSurname";
            this.nameSurname.Size = new System.Drawing.Size(140, 22);
            this.nameSurname.TabIndex = 86;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(170, 102);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(140, 22);
            this.id.TabIndex = 85;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 21);
            this.label12.TabIndex = 101;
            this.label12.Text = "ID Number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 164);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(142, 21);
            this.label16.TabIndex = 105;
            this.label16.Text = "Name Surname:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3,
            this.Adres});
            this.dataGridView1.Location = new System.Drawing.Point(370, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(913, 441);
            this.dataGridView1.TabIndex = 74;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "tc";
            this.Column1.HeaderText = "ID Number";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "adsoyad";
            this.Column2.HeaderText = "Name Surname";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "telefon";
            this.Column4.HeaderText = "Phone";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "email";
            this.Column3.HeaderText = "Email";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Adres
            // 
            this.Adres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adres.DataPropertyName = "adres";
            this.Adres.HeaderText = "Adress";
            this.Adres.MinimumWidth = 6;
            this.Adres.Name = "Adres";
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.CornflowerBlue;
            this.DELETE.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DELETE.ForeColor = System.Drawing.SystemColors.Window;
            this.DELETE.Location = new System.Drawing.Point(1157, 515);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(126, 46);
            this.DELETE.TabIndex = 81;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(752, 22);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(356, 29);
            this.search.TabIndex = 87;
            this.search.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(534, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 22);
            this.label2.TabIndex = 102;
            this.label2.Text = "Search Customer ID:";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.MidnightBlue;
            this.ADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ADD.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.ADD.Location = new System.Drawing.Point(17, 470);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(134, 45);
            this.ADD.TabIndex = 103;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // ListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 586);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.DELETE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListCustomer";
            this.Load += new System.EventHandler(this.ListCustomer_Load);
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox adress;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox nameSurname;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button UPGRADE;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adres;
        private System.Windows.Forms.Button ADD;
    }
}