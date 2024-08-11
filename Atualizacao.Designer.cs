namespace ERP
{
    partial class Atualizacao
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
            this.pbatl = new System.Windows.Forms.ProgressBar();
            this.lstatu = new System.Windows.Forms.Label();
            this.latl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_logo_sistema = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_sistema)).BeginInit();
            this.SuspendLayout();
            // 
            // pbatl
            // 
            this.pbatl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbatl.Location = new System.Drawing.Point(41, 207);
            this.pbatl.Name = "pbatl";
            this.pbatl.Size = new System.Drawing.Size(778, 28);
            this.pbatl.TabIndex = 0;
            // 
            // lstatu
            // 
            this.lstatu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstatu.AutoSize = true;
            this.lstatu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstatu.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lstatu.Location = new System.Drawing.Point(45, 185);
            this.lstatu.Name = "lstatu";
            this.lstatu.Size = new System.Drawing.Size(178, 19);
            this.lstatu.TabIndex = 1;
            this.lstatu.Text = "Status de atualização:";
            // 
            // latl
            // 
            this.latl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.latl.AutoSize = true;
            this.latl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latl.ForeColor = System.Drawing.SystemColors.Highlight;
            this.latl.Location = new System.Drawing.Point(217, 185);
            this.latl.Name = "latl";
            this.latl.Size = new System.Drawing.Size(66, 19);
            this.latl.TabIndex = 2;
            this.latl.Text = "(status)";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(105, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome do sistema";
            // 
            // pb_logo_sistema
            // 
            this.pb_logo_sistema.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_logo_sistema.Location = new System.Drawing.Point(556, 12);
            this.pb_logo_sistema.Name = "pb_logo_sistema";
            this.pb_logo_sistema.Size = new System.Drawing.Size(262, 173);
            this.pb_logo_sistema.TabIndex = 4;
            this.pb_logo_sistema.TabStop = false;
            // 
            // Atualizacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(873, 294);
            this.ControlBox = false;
            this.Controls.Add(this.pb_logo_sistema);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.latl);
            this.Controls.Add(this.lstatu);
            this.Controls.Add(this.pbatl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Atualizacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "atualizacao";
            this.Load += new System.EventHandler(this.Atualizacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo_sistema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbatl;
        private System.Windows.Forms.Label lstatu;
        private System.Windows.Forms.Label latl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_logo_sistema;
    }
}