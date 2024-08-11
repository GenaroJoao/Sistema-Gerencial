namespace ERP
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bcancelar = new System.Windows.Forms.Button();
            this.Bentrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Tbusuario = new System.Windows.Forms.TextBox();
            this.Tbsenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.l_horas = new System.Windows.Forms.Label();
            this.l_data = new System.Windows.Forms.Label();
            this.Horas = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.Bcancelar);
            this.groupBox1.Controls.Add(this.Bentrar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Tbusuario);
            this.groupBox1.Controls.Add(this.Tbsenha);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(234, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Bcancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcancelar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bcancelar.Location = new System.Drawing.Point(126, 127);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(99, 32);
            this.Bcancelar.TabIndex = 10;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // Bentrar
            // 
            this.Bentrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Bentrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bentrar.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Bentrar.Location = new System.Drawing.Point(241, 127);
            this.Bentrar.Name = "Bentrar";
            this.Bentrar.Size = new System.Drawing.Size(104, 32);
            this.Bentrar.TabIndex = 9;
            this.Bentrar.Text = "Entrar";
            this.Bentrar.UseVisualStyleBackColor = false;
            this.Bentrar.Click += new System.EventHandler(this.Bentrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Senha";
            // 
            // Tbusuario
            // 
            this.Tbusuario.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbusuario.Location = new System.Drawing.Point(126, 36);
            this.Tbusuario.Name = "Tbusuario";
            this.Tbusuario.Size = new System.Drawing.Size(219, 26);
            this.Tbusuario.TabIndex = 1;
            // 
            // Tbsenha
            // 
            this.Tbsenha.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbsenha.Location = new System.Drawing.Point(126, 74);
            this.Tbsenha.Name = "Tbsenha";
            this.Tbsenha.PasswordChar = '*';
            this.Tbsenha.Size = new System.Drawing.Size(219, 26);
            this.Tbsenha.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuário";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.l_horas);
            this.panel1.Controls.Add(this.l_data);
            this.panel1.Location = new System.Drawing.Point(12, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 59);
            this.panel1.TabIndex = 10;
            // 
            // l_horas
            // 
            this.l_horas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_horas.AutoSize = true;
            this.l_horas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.l_horas.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_horas.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_horas.Location = new System.Drawing.Point(51, 32);
            this.l_horas.Name = "l_horas";
            this.l_horas.Size = new System.Drawing.Size(54, 19);
            this.l_horas.TabIndex = 1;
            this.l_horas.Text = "horas";
            // 
            // l_data
            // 
            this.l_data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_data.AutoSize = true;
            this.l_data.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.l_data.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_data.ForeColor = System.Drawing.SystemColors.Highlight;
            this.l_data.Location = new System.Drawing.Point(51, 10);
            this.l_data.Name = "l_data";
            this.l_data.Size = new System.Drawing.Size(43, 19);
            this.l_data.TabIndex = 0;
            this.l_data.Text = "data";
            // 
            // Horas
            // 
            this.Horas.Enabled = true;
            this.Horas.Interval = 1000;
            this.Horas.Tick += new System.EventHandler(this.Horas_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Tbusuario;
        private System.Windows.Forms.TextBox Tbsenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Bentrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label l_horas;
        private System.Windows.Forms.Label l_data;
        private System.Windows.Forms.Timer Horas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Bcancelar;
    }
}