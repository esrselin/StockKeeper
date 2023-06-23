
namespace Form1
{
    partial class ListProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListProduct));
            this.newgroup = new System.Windows.Forms.GroupBox();
            this.nqui = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.npurc = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.combra = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comcat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nbar = new System.Windows.Forms.TextBox();
            this.npro = new System.Windows.Forms.TextBox();
            this.nsale = new System.Windows.Forms.TextBox();
            this.luptade = new System.Windows.Forms.Button();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.ADD = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.searchb = new System.Windows.Forms.TextBox();
            this.ldelete = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.newgroup.SuspendLayout();
            this.jGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // newgroup
            // 
            this.newgroup.BackColor = System.Drawing.Color.Transparent;
            this.newgroup.Controls.Add(this.nqui);
            this.newgroup.Controls.Add(this.label2);
            this.newgroup.Controls.Add(this.label1);
            this.newgroup.Controls.Add(this.label4);
            this.newgroup.Controls.Add(this.label5);
            this.newgroup.Controls.Add(this.npurc);
            this.newgroup.Controls.Add(this.label6);
            this.newgroup.Controls.Add(this.combra);
            this.newgroup.Controls.Add(this.label7);
            this.newgroup.Controls.Add(this.comcat);
            this.newgroup.Controls.Add(this.label8);
            this.newgroup.Controls.Add(this.nbar);
            this.newgroup.Controls.Add(this.npro);
            this.newgroup.Controls.Add(this.nsale);
            this.newgroup.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newgroup.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newgroup.Location = new System.Drawing.Point(22, 114);
            this.newgroup.Name = "newgroup";
            this.newgroup.Size = new System.Drawing.Size(322, 331);
            this.newgroup.TabIndex = 59;
            this.newgroup.TabStop = false;
            this.newgroup.Text = "Show Product";
            // 
            // nqui
            // 
            this.nqui.Location = new System.Drawing.Point(152, 191);
            this.nqui.Mask = "0000000000000";
            this.nqui.Name = "nqui";
            this.nqui.Size = new System.Drawing.Size(161, 26);
            this.nqui.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(5, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Brand:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 67;
            this.label1.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(6, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 58;
            this.label4.Text = "Sale Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 21);
            this.label5.TabIndex = 59;
            this.label5.Text = "Purchase Price:";
            // 
            // npurc
            // 
            this.npurc.Location = new System.Drawing.Point(152, 233);
            this.npurc.Name = "npurc";
            this.npurc.Size = new System.Drawing.Size(161, 26);
            this.npurc.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(6, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 21);
            this.label6.TabIndex = 60;
            this.label6.Text = "Quantity:";
            // 
            // combra
            // 
            this.combra.FormattingEnabled = true;
            this.combra.Location = new System.Drawing.Point(152, 154);
            this.combra.Name = "combra";
            this.combra.Size = new System.Drawing.Size(161, 28);
            this.combra.TabIndex = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(5, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 61;
            this.label7.Text = "Product Name:";
            // 
            // comcat
            // 
            this.comcat.FormattingEnabled = true;
            this.comcat.Location = new System.Drawing.Point(152, 116);
            this.comcat.Name = "comcat";
            this.comcat.Size = new System.Drawing.Size(161, 28);
            this.comcat.TabIndex = 69;
            this.comcat.SelectedIndexChanged += new System.EventHandler(this.comcat_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = "Barcode:";
            // 
            // nbar
            // 
            this.nbar.Location = new System.Drawing.Point(152, 41);
            this.nbar.Name = "nbar";
            this.nbar.Size = new System.Drawing.Size(161, 26);
            this.nbar.TabIndex = 61;
            // 
            // npro
            // 
            this.npro.Location = new System.Drawing.Point(152, 79);
            this.npro.Name = "npro";
            this.npro.Size = new System.Drawing.Size(161, 26);
            this.npro.TabIndex = 60;
            // 
            // nsale
            // 
            this.nsale.Location = new System.Drawing.Point(152, 274);
            this.nsale.Name = "nsale";
            this.nsale.Size = new System.Drawing.Size(161, 26);
            this.nsale.TabIndex = 59;
            // 
            // luptade
            // 
            this.luptade.BackColor = System.Drawing.Color.CornflowerBlue;
            this.luptade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.luptade.ForeColor = System.Drawing.Color.Transparent;
            this.luptade.Location = new System.Drawing.Point(174, 470);
            this.luptade.Name = "luptade";
            this.luptade.Size = new System.Drawing.Size(170, 38);
            this.luptade.TabIndex = 58;
            this.luptade.Text = "UPDATE";
            this.luptade.UseVisualStyleBackColor = false;
            this.luptade.Click += new System.EventHandler(this.luptade_Click);
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Silver;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Controls.Add(this.panel2);
            this.jGradientPanel1.Controls.Add(this.label11);
            this.jGradientPanel1.Controls.Add(this.ADD);
            this.jGradientPanel1.Controls.Add(this.luptade);
            this.jGradientPanel1.Controls.Add(this.newgroup);
            this.jGradientPanel1.Location = new System.Drawing.Point(-10, -6);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(364, 602);
            this.jGradientPanel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(31, 77);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 107;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(59, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 23);
            this.label11.TabIndex = 108;
            this.label11.Text = "PRODUCT INFORMATIONS";
            // 
            // ADD
            // 
            this.ADD.BackColor = System.Drawing.Color.MidnightBlue;
            this.ADD.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ADD.ForeColor = System.Drawing.Color.Transparent;
            this.ADD.Location = new System.Drawing.Point(22, 470);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(142, 38);
            this.ADD.TabIndex = 71;
            this.ADD.Text = "ADD";
            this.ADD.UseVisualStyleBackColor = false;
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column4,
            this.Column5,
            this.Column6,
            this.tarih});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(380, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(840, 446);
            this.dataGridView1.TabIndex = 61;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(437, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Search Barcode:";
            // 
            // searchb
            // 
            this.searchb.Location = new System.Drawing.Point(647, 19);
            this.searchb.Multiline = true;
            this.searchb.Name = "searchb";
            this.searchb.Size = new System.Drawing.Size(479, 34);
            this.searchb.TabIndex = 89;
            this.searchb.TextChanged += new System.EventHandler(this.searchb_TextChanged);
            // 
            // ldelete
            // 
            this.ldelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ldelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ldelete.ForeColor = System.Drawing.SystemColors.Window;
            this.ldelete.Location = new System.Drawing.Point(1094, 526);
            this.ldelete.Name = "ldelete";
            this.ldelete.Size = new System.Drawing.Size(126, 47);
            this.ldelete.TabIndex = 90;
            this.ldelete.Text = "DELETE";
            this.ldelete.UseVisualStyleBackColor = false;
            this.ldelete.Click += new System.EventHandler(this.ldelete_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "barkod";
            this.Column1.HeaderText = "Barcode";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "urunadi";
            this.Column2.HeaderText = "Product Name";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "kategori";
            this.Column3.HeaderText = "Category";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "marka";
            this.Column7.HeaderText = "Brand";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "miktari";
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "alisfiyati";
            this.Column5.HeaderText = "Purchase Price";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "satisfiyati";
            this.Column6.HeaderText = "Sale Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // tarih
            // 
            this.tarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tarih.DataPropertyName = "tarih";
            this.tarih.HeaderText = "Date";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.Visible = false;
            // 
            // ListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1246, 592);
            this.Controls.Add(this.ldelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchb);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.jGradientPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListProduct";
            this.Load += new System.EventHandler(this.ListProduct_Load);
            this.newgroup.ResumeLayout(false);
            this.newgroup.PerformLayout();
            this.jGradientPanel1.ResumeLayout(false);
            this.jGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox newgroup;
        private System.Windows.Forms.ComboBox combra;
        private System.Windows.Forms.ComboBox comcat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nbar;
        private System.Windows.Forms.TextBox npro;
        private System.Windows.Forms.TextBox nsale;
        private System.Windows.Forms.TextBox npurc;
        private System.Windows.Forms.Button luptade;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchb;
        private System.Windows.Forms.Button ldelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ADD;
        private System.Windows.Forms.MaskedTextBox nqui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
    }
}