namespace Proyecto_C
{
    partial class Frm_Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.BtnHoteles = new System.Windows.Forms.Button();
            this.BtnAereolinea = new System.Windows.Forms.Button();
            this.BtnRestaurantes = new System.Windows.Forms.Button();
            this.BtnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inicio";
            // 
            // BtnHoteles
            // 
            this.BtnHoteles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHoteles.Location = new System.Drawing.Point(138, 124);
            this.BtnHoteles.Name = "BtnHoteles";
            this.BtnHoteles.Size = new System.Drawing.Size(98, 34);
            this.BtnHoteles.TabIndex = 1;
            this.BtnHoteles.Text = "HOTELES";
            this.BtnHoteles.UseVisualStyleBackColor = true;
            this.BtnHoteles.Click += new System.EventHandler(this.BtnHoteles_Click);
            // 
            // BtnAereolinea
            // 
            this.BtnAereolinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAereolinea.Location = new System.Drawing.Point(287, 124);
            this.BtnAereolinea.Name = "BtnAereolinea";
            this.BtnAereolinea.Size = new System.Drawing.Size(138, 34);
            this.BtnAereolinea.TabIndex = 2;
            this.BtnAereolinea.Text = "AEREOLINEAS";
            this.BtnAereolinea.UseVisualStyleBackColor = true;
            // 
            // BtnRestaurantes
            // 
            this.BtnRestaurantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRestaurantes.Location = new System.Drawing.Point(462, 124);
            this.BtnRestaurantes.Name = "BtnRestaurantes";
            this.BtnRestaurantes.Size = new System.Drawing.Size(149, 34);
            this.BtnRestaurantes.TabIndex = 3;
            this.BtnRestaurantes.Text = "RESTAURANTES";
            this.BtnRestaurantes.UseVisualStyleBackColor = true;
            // 
            // BtnRegresar
            // 
            this.BtnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegresar.Location = new System.Drawing.Point(138, 351);
            this.BtnRegresar.Name = "BtnRegresar";
            this.BtnRegresar.Size = new System.Drawing.Size(112, 34);
            this.BtnRegresar.TabIndex = 4;
            this.BtnRegresar.Text = "REGRESAR";
            this.BtnRegresar.UseVisualStyleBackColor = true;
            this.BtnRegresar.Click += new System.EventHandler(this.BtnRegresar_Click);
            // 
            // Frm_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnRegresar);
            this.Controls.Add(this.BtnRestaurantes);
            this.Controls.Add(this.BtnAereolinea);
            this.Controls.Add(this.BtnHoteles);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnHoteles;
        private System.Windows.Forms.Button BtnAereolinea;
        private System.Windows.Forms.Button BtnRestaurantes;
        private System.Windows.Forms.Button BtnRegresar;
    }
}