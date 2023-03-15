namespace External_Menu.Gui
{
    partial class Form11
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
            this.nhknoob = new System.Windows.Forms.Label();
            this.pnlselection = new System.Windows.Forms.Panel();
            this.KAL = new System.Windows.Forms.Label();
            this.BYE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nhknoob
            // 
            this.nhknoob.AutoSize = true;
            this.nhknoob.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nhknoob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.nhknoob.Location = new System.Drawing.Point(12, 26);
            this.nhknoob.Name = "nhknoob";
            this.nhknoob.Size = new System.Drawing.Size(160, 34);
            this.nhknoob.TabIndex = 0;
            this.nhknoob.Text = "NHK NOOB";
            this.nhknoob.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlselection
            // 
            this.pnlselection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(132)))), ((int)(((byte)(252)))));
            this.pnlselection.Location = new System.Drawing.Point(30, 60);
            this.pnlselection.Name = "pnlselection";
            this.pnlselection.Size = new System.Drawing.Size(120, 1);
            this.pnlselection.TabIndex = 1;
            // 
            // KAL
            // 
            this.KAL.AutoSize = true;
            this.KAL.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KAL.ForeColor = System.Drawing.Color.LightCyan;
            this.KAL.Location = new System.Drawing.Point(194, 26);
            this.KAL.Name = "KAL";
            this.KAL.Size = new System.Drawing.Size(220, 34);
            this.KAL.TabIndex = 2;
            this.KAL.Text = "KAL ANA NOOB";
            this.KAL.Click += new System.EventHandler(this.label2_Click);
            // 
            // BYE
            // 
            this.BYE.AutoSize = true;
            this.BYE.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BYE.ForeColor = System.Drawing.Color.LightCyan;
            this.BYE.Location = new System.Drawing.Point(436, 26);
            this.BYE.Name = "BYE";
            this.BYE.Size = new System.Drawing.Size(150, 34);
            this.BYE.TabIndex = 3;
            this.BYE.Text = "BYE NOOB";
            this.BYE.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(832, 646);
            this.Controls.Add(this.BYE);
            this.Controls.Add(this.KAL);
            this.Controls.Add(this.pnlselection);
            this.Controls.Add(this.nhknoob);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form11";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nhknoob;
        private System.Windows.Forms.Panel pnlselection;
        private System.Windows.Forms.Label KAL;
        private System.Windows.Forms.Label BYE;
    }
}