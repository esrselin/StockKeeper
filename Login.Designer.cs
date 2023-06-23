
namespace StockKeeper
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.CLEAR = new System.Windows.Forms.Button();
            this.SUMBIT = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.userName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.jGradientPanel1 = new JGradient_Panel.JGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // CLEAR
            // 
            this.CLEAR.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CLEAR.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CLEAR.ForeColor = System.Drawing.SystemColors.Window;
            this.CLEAR.Location = new System.Drawing.Point(210, 350);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(126, 59);
            this.CLEAR.TabIndex = 19;
            this.CLEAR.Text = "CLEAR";
            this.CLEAR.UseVisualStyleBackColor = false;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // SUMBIT
            // 
            this.SUMBIT.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SUMBIT.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SUMBIT.ForeColor = System.Drawing.SystemColors.Window;
            this.SUMBIT.Location = new System.Drawing.Point(445, 350);
            this.SUMBIT.Name = "SUMBIT";
            this.SUMBIT.Size = new System.Drawing.Size(126, 59);
            this.SUMBIT.TabIndex = 18;
            this.SUMBIT.Text = "SUMBIT";
            this.SUMBIT.UseVisualStyleBackColor = false;
            this.SUMBIT.Click += new System.EventHandler(this.SUMBIT_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Location = new System.Drawing.Point(312, 250);
            this.password.Name = "password";
            this.password.PasswordChar = '•';
            this.password.Size = new System.Drawing.Size(243, 15);
            this.password.TabIndex = 17;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // userName
            // 
            this.userName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userName.Location = new System.Drawing.Point(312, 143);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(243, 15);
            this.userName.TabIndex = 16;
            this.userName.TextChanged += new System.EventHandler(this.userName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(252, 284);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(252, 222);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // jGradientPanel1
            // 
            this.jGradientPanel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.jGradientPanel1.ColorBottom = System.Drawing.Color.Silver;
            this.jGradientPanel1.ColorTop = System.Drawing.Color.Empty;
            this.jGradientPanel1.Location = new System.Drawing.Point(0, -4);
            this.jGradientPanel1.Name = "jGradientPanel1";
            this.jGradientPanel1.Size = new System.Drawing.Size(127, 492);
            this.jGradientPanel1.TabIndex = 11;
            this.jGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.jGradientPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(182, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(473, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "WELCOME TO STOCK KEEPER";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(252, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(122, 29);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(77, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(716, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.SUMBIT);
            this.Controls.Add(this.password);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.jGradientPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Keeper";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.Button SUMBIT;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private JGradient_Panel.JGradientPanel jGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}