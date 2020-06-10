namespace operaciones_Windows
{
    partial class Form1
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
            this.btbMostrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtingresar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmes = new System.Windows.Forms.TextBox();
            this.btbmostratmes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btbMostrar
            // 
            this.btbMostrar.Location = new System.Drawing.Point(165, 136);
            this.btbMostrar.Name = "btbMostrar";
            this.btbMostrar.Size = new System.Drawing.Size(116, 28);
            this.btbMostrar.TabIndex = 0;
            this.btbMostrar.Text = "Mostrar";
            this.btbMostrar.UseVisualStyleBackColor = true;
            this.btbMostrar.Click += new System.EventHandler(this.btbMostrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(33, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "MOSTRAR SI EL NUMERO ES PAR O IMPAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtingresar
            // 
            this.txtingresar.Location = new System.Drawing.Point(165, 80);
            this.txtingresar.Name = "txtingresar";
            this.txtingresar.Size = new System.Drawing.Size(116, 22);
            this.txtingresar.TabIndex = 2;
            this.txtingresar.TextChanged += new System.EventHandler(this.txtresultado_TextChanged);
            this.txtingresar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtresultado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(528, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "MOSTRAR EL MES ";
            this.label2.UseCompatibleTextRendering = true;
            // 
            // txtmes
            // 
            this.txtmes.Location = new System.Drawing.Point(550, 80);
            this.txtmes.Name = "txtmes";
            this.txtmes.Size = new System.Drawing.Size(116, 22);
            this.txtmes.TabIndex = 4;
            // 
            // btbmostratmes
            // 
            this.btbmostratmes.Location = new System.Drawing.Point(550, 136);
            this.btbmostratmes.Name = "btbmostratmes";
            this.btbmostratmes.Size = new System.Drawing.Size(116, 28);
            this.btbmostratmes.TabIndex = 5;
            this.btbmostratmes.Text = "Mostrar";
            this.btbmostratmes.UseVisualStyleBackColor = true;
            this.btbmostratmes.Click += new System.EventHandler(this.btbmostratmes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btbmostratmes);
            this.Controls.Add(this.txtmes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtingresar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btbMostrar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btbMostrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtingresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmes;
        private System.Windows.Forms.Button btbmostratmes;
    }
}

