namespace AstralRest
{
    partial class LookupCard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.titlelbl = new System.Windows.Forms.Label();
            this.cotnetnlbl = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 4;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.cotnetnlbl);
            this.guna2Panel1.Controls.Add(this.titlelbl);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.guna2Panel1.Location = new System.Drawing.Point(5, 6);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(823, 72);
            this.guna2Panel1.TabIndex = 0;
            // 
            // titlelbl
            // 
            this.titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.titlelbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.titlelbl.ForeColor = System.Drawing.Color.White;
            this.titlelbl.Location = new System.Drawing.Point(6, 10);
            this.titlelbl.Name = "titlelbl";
            this.titlelbl.Size = new System.Drawing.Size(776, 25);
            this.titlelbl.TabIndex = 3;
            this.titlelbl.Text = "Title here";
            // 
            // cotnetnlbl
            // 
            this.cotnetnlbl.BackColor = System.Drawing.Color.Transparent;
            this.cotnetnlbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.cotnetnlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(198)))), ((int)(((byte)(227)))));
            this.cotnetnlbl.Location = new System.Drawing.Point(6, 38);
            this.cotnetnlbl.Name = "cotnetnlbl";
            this.cotnetnlbl.Size = new System.Drawing.Size(767, 25);
            this.cotnetnlbl.TabIndex = 4;
            this.cotnetnlbl.Text = "Contnet here";
            this.cotnetnlbl.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cotnetnlbl_MouseDoubleClick);
            // 
            // LookupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(20)))), ((int)(((byte)(29)))));
            this.Controls.Add(this.guna2Panel1);
            this.Name = "LookupCard";
            this.Size = new System.Drawing.Size(835, 89);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label titlelbl;
        private System.Windows.Forms.Label cotnetnlbl;
    }
}
