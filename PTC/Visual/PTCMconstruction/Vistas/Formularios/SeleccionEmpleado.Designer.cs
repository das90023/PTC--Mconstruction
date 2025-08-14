namespace Vistas.Formularios
{
    partial class SeleccionEmpleado
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSingOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Vistas.Properties.Resources.BoxBorder;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Vistas.Properties.Resources.icons8_clientes_100;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.Location = new System.Drawing.Point(244, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 430);
            this.button1.TabIndex = 1;
            this.button1.Text = "Clientes";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::Vistas.Properties.Resources.BoxBorder;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Vistas.Properties.Resources.icons8_inventario_100;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.Location = new System.Drawing.Point(796, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(264, 430);
            this.button2.TabIndex = 2;
            this.button2.Text = "Inventario";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnSingOut
            // 
            this.btnSingOut.BackColor = System.Drawing.Color.Transparent;
            this.btnSingOut.BackgroundImage = global::Vistas.Properties.Resources.BotonSalir;
            this.btnSingOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSingOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSingOut.Location = new System.Drawing.Point(1101, 21);
            this.btnSingOut.Name = "btnSingOut";
            this.btnSingOut.Size = new System.Drawing.Size(176, 51);
            this.btnSingOut.TabIndex = 5;
            this.btnSingOut.UseVisualStyleBackColor = false;
            this.btnSingOut.Click += new System.EventHandler(this.btnSingOut_Click);
            // 
            // SeleccionEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vistas.Properties.Resources.Index;
            this.ClientSize = new System.Drawing.Size(1289, 633);
            this.Controls.Add(this.btnSingOut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "SeleccionEmpleado";
            this.Text = "SeleccionEmpleado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSingOut;
    }
}