namespace libreria.Formularios
{
    partial class FrmPreAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbVerNotas = new System.Windows.Forms.PictureBox();
            this.pcbVerEstudiante = new System.Windows.Forms.PictureBox();
            this.pcbAtras = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrar Usuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(398, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Administrar Notas";
            // 
            // pcbVerNotas
            // 
            this.pcbVerNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVerNotas.Image = global::libreria.Properties.Resources.nota;
            this.pcbVerNotas.Location = new System.Drawing.Point(404, 102);
            this.pcbVerNotas.Name = "pcbVerNotas";
            this.pcbVerNotas.Size = new System.Drawing.Size(185, 164);
            this.pcbVerNotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerNotas.TabIndex = 1;
            this.pcbVerNotas.TabStop = false;
            this.pcbVerNotas.Click += new System.EventHandler(this.pcbVerNotas_Click);
            // 
            // pcbVerEstudiante
            // 
            this.pcbVerEstudiante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVerEstudiante.Image = global::libreria.Properties.Resources.student_friends;
            this.pcbVerEstudiante.Location = new System.Drawing.Point(48, 107);
            this.pcbVerEstudiante.Name = "pcbVerEstudiante";
            this.pcbVerEstudiante.Size = new System.Drawing.Size(249, 159);
            this.pcbVerEstudiante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerEstudiante.TabIndex = 0;
            this.pcbVerEstudiante.TabStop = false;
            this.pcbVerEstudiante.Click += new System.EventHandler(this.pcbVerEstudiante_Click);
            // 
            // pcbAtras
            // 
            this.pcbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAtras.Image = global::libreria.Properties.Resources.btnBack;
            this.pcbAtras.Location = new System.Drawing.Point(12, 12);
            this.pcbAtras.Name = "pcbAtras";
            this.pcbAtras.Size = new System.Drawing.Size(59, 50);
            this.pcbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAtras.TabIndex = 5;
            this.pcbAtras.TabStop = false;
            this.pcbAtras.Click += new System.EventHandler(this.pcbAtras_Click);
            // 
            // FrmPreAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(669, 443);
            this.Controls.Add(this.pcbAtras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbVerNotas);
            this.Controls.Add(this.pcbVerEstudiante);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPreAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Administrativo";
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVerEstudiante;
        private System.Windows.Forms.PictureBox pcbVerNotas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbAtras;
    }
}