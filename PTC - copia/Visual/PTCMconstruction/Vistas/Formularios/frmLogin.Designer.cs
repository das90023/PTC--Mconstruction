namespace Vistas.Formularios
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.picMostrarPass = new System.Windows.Forms.PictureBox();
            this.btnLogIn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(442, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(46)))), ((int)(((byte)(46)))));
            this.lblid.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblid.Location = new System.Drawing.Point(442, 195);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(46, 37);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(472, 235);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(361, 42);
            this.txtID.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(472, 357);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(361, 43);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(194)))), ((int)(((byte)(251)))));
            this.lblLog.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLog.ForeColor = System.Drawing.Color.Black;
            this.lblLog.Location = new System.Drawing.Point(613, 424);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(97, 37);
            this.lblLog.TabIndex = 3;
            this.lblLog.Text = "Log In";
            // 
            // picMostrarPass
            // 
            this.picMostrarPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMostrarPass.Image = global::Vistas.Properties.Resources.ojo;
            this.picMostrarPass.Location = new System.Drawing.Point(849, 365);
            this.picMostrarPass.Name = "picMostrarPass";
            this.picMostrarPass.Size = new System.Drawing.Size(21, 22);
            this.picMostrarPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMostrarPass.TabIndex = 4;
            this.picMostrarPass.TabStop = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Image = global::Vistas.Properties.Resources.Boton;
            this.btnLogIn.Location = new System.Drawing.Point(395, 417);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(515, 51);
            this.btnLogIn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.TabStop = false;
            this.btnLogIn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vistas.Properties.Resources.Inicio__5_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1305, 727);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 688);
            this.Controls.Add(this.picMostrarPass);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmLogin";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.picMostrarPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.PictureBox btnLogIn;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.PictureBox picMostrarPass;
    }
}
