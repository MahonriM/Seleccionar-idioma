namespace WindowsFormsApp2
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
            this.chBingles = new System.Windows.Forms.CheckBox();
            this.chBoxFrances = new System.Windows.Forms.CheckBox();
            this.chBoxAleman = new System.Windows.Forms.CheckBox();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chBingles
            // 
            this.chBingles.AutoSize = true;
            this.chBingles.Location = new System.Drawing.Point(2, 28);
            this.chBingles.Name = "chBingles";
            this.chBingles.Size = new System.Drawing.Size(54, 17);
            this.chBingles.TabIndex = 0;
            this.chBingles.Text = "Ingles";
            this.chBingles.UseVisualStyleBackColor = true;
            this.chBingles.CheckedChanged += new System.EventHandler(this.chBingles_CheckedChanged);
            // 
            // chBoxFrances
            // 
            this.chBoxFrances.AutoSize = true;
            this.chBoxFrances.Location = new System.Drawing.Point(2, 51);
            this.chBoxFrances.Name = "chBoxFrances";
            this.chBoxFrances.Size = new System.Drawing.Size(64, 17);
            this.chBoxFrances.TabIndex = 1;
            this.chBoxFrances.Text = "Frances";
            this.chBoxFrances.UseVisualStyleBackColor = true;
            this.chBoxFrances.CheckedChanged += new System.EventHandler(this.chBoxFrances_CheckedChanged);
            // 
            // chBoxAleman
            // 
            this.chBoxAleman.AutoSize = true;
            this.chBoxAleman.Location = new System.Drawing.Point(2, 74);
            this.chBoxAleman.Name = "chBoxAleman";
            this.chBoxAleman.Size = new System.Drawing.Size(61, 17);
            this.chBoxAleman.TabIndex = 2;
            this.chBoxAleman.Text = "Aleman";
            this.chBoxAleman.UseVisualStyleBackColor = true;
            this.chBoxAleman.CheckedChanged += new System.EventHandler(this.chBoxAleman_CheckedChanged);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(15, 111);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(214, 26);
            this.btnseleccion.TabIndex = 3;
            this.btnseleccion.Text = "Mostrar seleccionados";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(21, 140);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 13);
            this.lb.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 167);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.chBoxAleman);
            this.Controls.Add(this.chBoxFrances);
            this.Controls.Add(this.chBingles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chBingles;
        private System.Windows.Forms.CheckBox chBoxFrances;
        private System.Windows.Forms.CheckBox chBoxAleman;
        private System.Windows.Forms.Button btnseleccion;
        private System.Windows.Forms.Label lb;
    }
}

