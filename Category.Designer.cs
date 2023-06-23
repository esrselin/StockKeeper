
namespace Form1
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            this.cat = new System.Windows.Forms.TextBox();
            this.catAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cat
            // 
            this.cat.Location = new System.Drawing.Point(173, 30);
            this.cat.Multiline = true;
            this.cat.Name = "cat";
            this.cat.Size = new System.Drawing.Size(194, 27);
            this.cat.TabIndex = 60;
            // 
            // catAdd
            // 
            this.catAdd.BackColor = System.Drawing.Color.MidnightBlue;
            this.catAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.catAdd.ForeColor = System.Drawing.Color.Transparent;
            this.catAdd.Location = new System.Drawing.Point(116, 81);
            this.catAdd.Name = "catAdd";
            this.catAdd.Size = new System.Drawing.Size(158, 43);
            this.catAdd.TabIndex = 62;
            this.catAdd.Text = "ADD";
            this.catAdd.UseVisualStyleBackColor = false;
            this.catAdd.Click += new System.EventHandler(this.catAdd_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 68;
            this.label9.Text = "New Category:";
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(389, 146);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.catAdd);
            this.Controls.Add(this.cat);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox cat;
        private System.Windows.Forms.Button catAdd;
        private System.Windows.Forms.Label label9;
    }
}