
namespace Justicia
{
    partial class frmProfugos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lstNombres = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAlias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblProfugoDesde = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROFUGOS";
            // 
            // lstNombres
            // 
            this.lstNombres.FormattingEnabled = true;
            this.lstNombres.Location = new System.Drawing.Point(12, 46);
            this.lstNombres.Name = "lstNombres";
            this.lstNombres.Size = new System.Drawing.Size(250, 537);
            this.lstNombres.TabIndex = 1;
            this.lstNombres.SelectedIndexChanged += new System.EventHandler(this.lstNombres_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "FOTO";
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BackColor = System.Drawing.Color.White;
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(329, 46);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(250, 293);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 3;
            this.pbFoto.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ALIAS";
            // 
            // lblAlias
            // 
            this.lblAlias.BackColor = System.Drawing.Color.Black;
            this.lblAlias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlias.ForeColor = System.Drawing.Color.Yellow;
            this.lblAlias.Location = new System.Drawing.Point(326, 413);
            this.lblAlias.Name = "lblAlias";
            this.lblAlias.Size = new System.Drawing.Size(253, 23);
            this.lblAlias.TabIndex = 5;
            this.lblAlias.Text = "label4";
            this.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 459);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "PROFUGO DESDE";
            // 
            // lblProfugoDesde
            // 
            this.lblProfugoDesde.BackColor = System.Drawing.Color.Black;
            this.lblProfugoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfugoDesde.ForeColor = System.Drawing.Color.Yellow;
            this.lblProfugoDesde.Location = new System.Drawing.Point(326, 484);
            this.lblProfugoDesde.Name = "lblProfugoDesde";
            this.lblProfugoDesde.Size = new System.Drawing.Size(253, 23);
            this.lblProfugoDesde.TabIndex = 7;
            this.lblProfugoDesde.Text = "label6";
            this.lblProfugoDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmProfugos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 609);
            this.Controls.Add(this.lblProfugoDesde);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAlias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstNombres);
            this.Controls.Add(this.label1);
            this.Name = "frmProfugos";
            this.Text = "Profugos";
            this.Load += new System.EventHandler(this.frmProfugos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAlias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblProfugoDesde;
    }
}

