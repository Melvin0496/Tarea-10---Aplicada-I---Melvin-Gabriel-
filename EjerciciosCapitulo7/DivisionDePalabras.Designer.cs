namespace EjerciciosCapitulo7
{
    partial class DivisionDePalabras
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
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.PalabraslistBox = new System.Windows.Forms.ListBox();
            this.Dividirbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadena:";
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(65, 44);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(100, 20);
            this.CadenatextBox.TabIndex = 1;
            // 
            // PalabraslistBox
            // 
            this.PalabraslistBox.FormattingEnabled = true;
            this.PalabraslistBox.Items.AddRange(new object[] {
            "Palabras de la cadena:",
            ""});
            this.PalabraslistBox.Location = new System.Drawing.Point(15, 95);
            this.PalabraslistBox.Name = "PalabraslistBox";
            this.PalabraslistBox.Size = new System.Drawing.Size(257, 108);
            this.PalabraslistBox.TabIndex = 2;
            // 
            // Dividirbutton
            // 
            this.Dividirbutton.Location = new System.Drawing.Point(101, 226);
            this.Dividirbutton.Name = "Dividirbutton";
            this.Dividirbutton.Size = new System.Drawing.Size(75, 23);
            this.Dividirbutton.TabIndex = 3;
            this.Dividirbutton.Text = "Dividir";
            this.Dividirbutton.UseVisualStyleBackColor = true;
            this.Dividirbutton.Click += new System.EventHandler(this.Dividirbutton_Click);
            // 
            // DivisionDePalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Dividirbutton);
            this.Controls.Add(this.PalabraslistBox);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.label1);
            this.Name = "DivisionDePalabras";
            this.Text = "Division de palabras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.ListBox PalabraslistBox;
        private System.Windows.Forms.Button Dividirbutton;
    }
}