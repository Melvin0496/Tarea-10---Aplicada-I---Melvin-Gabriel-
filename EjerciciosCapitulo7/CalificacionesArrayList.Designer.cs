namespace EjerciciosCapitulo7
{
    partial class CalificacionesArrayList
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
            this.CalificaciontextBox = new System.Windows.Forms.TextBox();
            this.PromediotextBox = new System.Windows.Forms.TextBox();
            this.MaximatextBox = new System.Windows.Forms.TextBox();
            this.MinimatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CalificacioneslistBox = new System.Windows.Forms.ListBox();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Mostrarbutton = new System.Windows.Forms.Button();
            this.Limpiarbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalificaciontextBox
            // 
            this.CalificaciontextBox.Location = new System.Drawing.Point(197, 87);
            this.CalificaciontextBox.Name = "CalificaciontextBox";
            this.CalificaciontextBox.Size = new System.Drawing.Size(100, 20);
            this.CalificaciontextBox.TabIndex = 0;
            // 
            // PromediotextBox
            // 
            this.PromediotextBox.Location = new System.Drawing.Point(197, 122);
            this.PromediotextBox.Name = "PromediotextBox";
            this.PromediotextBox.ReadOnly = true;
            this.PromediotextBox.Size = new System.Drawing.Size(100, 20);
            this.PromediotextBox.TabIndex = 1;
            // 
            // MaximatextBox
            // 
            this.MaximatextBox.Location = new System.Drawing.Point(197, 157);
            this.MaximatextBox.Name = "MaximatextBox";
            this.MaximatextBox.ReadOnly = true;
            this.MaximatextBox.Size = new System.Drawing.Size(100, 20);
            this.MaximatextBox.TabIndex = 2;
            // 
            // MinimatextBox
            // 
            this.MinimatextBox.Location = new System.Drawing.Point(197, 193);
            this.MinimatextBox.Name = "MinimatextBox";
            this.MinimatextBox.ReadOnly = true;
            this.MinimatextBox.Size = new System.Drawing.Size(100, 20);
            this.MinimatextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Calificacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Promedio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(128, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Maxima:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minima:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Todas las calificaciones:";
            // 
            // CalificacioneslistBox
            // 
            this.CalificacioneslistBox.FormattingEnabled = true;
            this.CalificacioneslistBox.Items.AddRange(new object[] {
            "Calificaciones"});
            this.CalificacioneslistBox.Location = new System.Drawing.Point(130, 242);
            this.CalificacioneslistBox.Name = "CalificacioneslistBox";
            this.CalificacioneslistBox.Size = new System.Drawing.Size(218, 95);
            this.CalificacioneslistBox.TabIndex = 10;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(99, 367);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guardarbutton.TabIndex = 11;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Mostrarbutton
            // 
            this.Mostrarbutton.Location = new System.Drawing.Point(294, 367);
            this.Mostrarbutton.Name = "Mostrarbutton";
            this.Mostrarbutton.Size = new System.Drawing.Size(75, 23);
            this.Mostrarbutton.TabIndex = 12;
            this.Mostrarbutton.Text = "Mostrar";
            this.Mostrarbutton.UseVisualStyleBackColor = true;
            this.Mostrarbutton.Click += new System.EventHandler(this.Mostrarbutton_Click);
            // 
            // Limpiarbutton
            // 
            this.Limpiarbutton.Location = new System.Drawing.Point(197, 367);
            this.Limpiarbutton.Name = "Limpiarbutton";
            this.Limpiarbutton.Size = new System.Drawing.Size(75, 23);
            this.Limpiarbutton.TabIndex = 13;
            this.Limpiarbutton.Text = "Limpiar";
            this.Limpiarbutton.UseVisualStyleBackColor = true;
            this.Limpiarbutton.Click += new System.EventHandler(this.Limpiarbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(124, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 38);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salon de clases:";
            // 
            // CalificacionesArrayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 435);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Limpiarbutton);
            this.Controls.Add(this.Mostrarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.CalificacioneslistBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinimatextBox);
            this.Controls.Add(this.MaximatextBox);
            this.Controls.Add(this.PromediotextBox);
            this.Controls.Add(this.CalificaciontextBox);
            this.Name = "CalificacionesArrayList";
            this.Text = "Calificaciones ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CalificaciontextBox;
        private System.Windows.Forms.TextBox PromediotextBox;
        private System.Windows.Forms.TextBox MaximatextBox;
        private System.Windows.Forms.TextBox MinimatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox CalificacioneslistBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Mostrarbutton;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.Label label6;
    }
}