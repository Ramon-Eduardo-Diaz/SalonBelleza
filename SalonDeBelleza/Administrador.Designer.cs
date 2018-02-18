namespace SalonDeBelleza
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.lblNombre = new DevExpress.XtraEditors.LabelControl();
            this.lblId = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdministrador = new DevExpress.XtraEditors.LabelControl();
            this.btnIngresar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Appearance.Options.UseFont = true;
            this.lblNombre.Appearance.Options.UseForeColor = true;
            this.lblNombre.Location = new System.Drawing.Point(67, 93);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(18, 23);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Id";
            // 
            // lblId
            // 
            this.lblId.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblId.Appearance.Options.UseFont = true;
            this.lblId.Appearance.Options.UseForeColor = true;
            this.lblId.Location = new System.Drawing.Point(67, 142);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(94, 23);
            this.lblId.TabIndex = 1;
            this.lblId.Text = "Contraseña";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(178, 93);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(192, 21);
            this.txtId.TabIndex = 2;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(178, 142);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(192, 21);
            this.txtContra.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdministrador
            // 
            this.lblAdministrador.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdministrador.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblAdministrador.Appearance.Options.UseFont = true;
            this.lblAdministrador.Appearance.Options.UseForeColor = true;
            this.lblAdministrador.Location = new System.Drawing.Point(132, 21);
            this.lblAdministrador.Name = "lblAdministrador";
            this.lblAdministrador.Size = new System.Drawing.Size(163, 29);
            this.lblAdministrador.TabIndex = 5;
            this.lblAdministrador.Text = "Administrador";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Appearance.Options.UseFont = true;
            this.btnIngresar.Location = new System.Drawing.Point(144, 224);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(142, 35);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // Administrador
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 305);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.lblAdministrador);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lblNombre);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblNombre;
        private DevExpress.XtraEditors.LabelControl lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl lblAdministrador;
        private DevExpress.XtraEditors.SimpleButton btnIngresar;
    }
}