namespace libreria.Formularios
{
    partial class FrmPreEstudiante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPreEstudiante));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pcbAtras = new System.Windows.Forms.PictureBox();
            this.pcbVerDatos = new System.Windows.Forms.PictureBox();
            this.pcbVerNotas = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerNotas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ver mis notas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ver mis datos";
            // 
            // pcbAtras
            // 
            this.pcbAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbAtras.Image = global::libreria.Properties.Resources.btnBack;
            this.pcbAtras.Location = new System.Drawing.Point(12, 12);
            this.pcbAtras.Name = "pcbAtras";
            this.pcbAtras.Size = new System.Drawing.Size(57, 50);
            this.pcbAtras.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAtras.TabIndex = 4;
            this.pcbAtras.TabStop = false;
            this.pcbAtras.Click += new System.EventHandler(this.pcbAtras_Click);
            // 
            // pcbVerDatos
            // 
            this.pcbVerDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVerDatos.Image = global::libreria.Properties.Resources.datos_estudiantil;
            this.pcbVerDatos.Location = new System.Drawing.Point(36, 90);
            this.pcbVerDatos.Name = "pcbVerDatos";
            this.pcbVerDatos.Size = new System.Drawing.Size(235, 166);
            this.pcbVerDatos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerDatos.TabIndex = 1;
            this.pcbVerDatos.TabStop = false;
            this.pcbVerDatos.Click += new System.EventHandler(this.pcbVerDatos_Click);
            // 
            // pcbVerNotas
            // 
            this.pcbVerNotas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbVerNotas.Image = global::libreria.Properties.Resources.nota;
            this.pcbVerNotas.Location = new System.Drawing.Point(317, 90);
            this.pcbVerNotas.Name = "pcbVerNotas";
            this.pcbVerNotas.Size = new System.Drawing.Size(169, 162);
            this.pcbVerNotas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbVerNotas.TabIndex = 0;
            this.pcbVerNotas.TabStop = false;
            this.pcbVerNotas.Click += new System.EventHandler(this.pcbVerNotas_Click);
            // 
            // FrmPreEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(560, 394);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pcbVerDatos);
            this.Controls.Add(this.pcbAtras);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbVerNotas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPreEstudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Estudiantil";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAtras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVerNotas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbVerNotas;
        private System.Windows.Forms.PictureBox pcbVerDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pcbAtras;
    }
}