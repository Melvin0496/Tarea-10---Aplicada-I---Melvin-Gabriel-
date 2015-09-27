namespace EjerciciosCapitulo7
{
    partial class SumasConCadenas
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
            this.label2 = new System.Windows.Forms.Label();
            this.PrimerNumerotextBox = new System.Windows.Forms.TextBox();
            this.SegundoNumerotextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.Resultadobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primer numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segundo numero:";
            // 
            // PrimerNumerotextBox
            // 
            this.PrimerNumerotextBox.Location = new System.Drawing.Point(109, 29);
            this.PrimerNumerotextBox.Name = "PrimerNumerotextBox";
            this.PrimerNumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.PrimerNumerotextBox.TabIndex = 2;
            // 
            // SegundoNumerotextBox
            // 
            this.SegundoNumerotextBox.Location = new System.Drawing.Point(109, 55);
            this.SegundoNumerotextBox.Name = "SegundoNumerotextBox";
            this.SegundoNumerotextBox.Size = new System.Drawing.Size(100, 20);
            this.SegundoNumerotextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado:";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(109, 81);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.ReadOnly = true;
            this.ResultadotextBox.Size = new System.Drawing.Size(100, 20);
            this.ResultadotextBox.TabIndex = 5;
            // 
            // Resultadobutton
            // 
            this.Resultadobutton.Location = new System.Drawing.Point(100, 144);
            this.Resultadobutton.Name = "Resultadobutton";
            this.Resultadobutton.Size = new System.Drawing.Size(75, 23);
            this.Resultadobutton.TabIndex = 6;
            this.Resultadobutton.Text = "Resultado";
            this.Resultadobutton.UseVisualStyleBackColor = true;
            this.Resultadobutton.Click += new System.EventHandler(this.Resultadobutton_Click);
            // 
            // SumasConCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 297);
            this.Controls.Add(this.Resultadobutton);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SegundoNumerotextBox);
            this.Controls.Add(this.PrimerNumerotextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SumasConCadenas";
            this.Text = "Sumas con cadenas";
            this.Load += new System.EventHandler(this.SumasConCadenas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimerNumerotextBox;
        private System.Windows.Forms.TextBox SegundoNumerotextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultadotextBox;
        private System.Windows.Forms.Button Resultadobutton;
    }
}