namespace EjerciciosCapitulo7
{
    partial class OrdenarCadenas
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
            this.PrimeraCadenatextBox = new System.Windows.Forms.TextBox();
            this.SegundaCadenatextBox = new System.Windows.Forms.TextBox();
            this.OrdenlistBox = new System.Windows.Forms.ListBox();
            this.Presionabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primera cadena:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Segunda cadena:";
            // 
            // PrimeraCadenatextBox
            // 
            this.PrimeraCadenatextBox.Location = new System.Drawing.Point(102, 24);
            this.PrimeraCadenatextBox.Name = "PrimeraCadenatextBox";
            this.PrimeraCadenatextBox.Size = new System.Drawing.Size(100, 20);
            this.PrimeraCadenatextBox.TabIndex = 2;
            // 
            // SegundaCadenatextBox
            // 
            this.SegundaCadenatextBox.Location = new System.Drawing.Point(102, 58);
            this.SegundaCadenatextBox.Name = "SegundaCadenatextBox";
            this.SegundaCadenatextBox.Size = new System.Drawing.Size(100, 20);
            this.SegundaCadenatextBox.TabIndex = 3;
            // 
            // OrdenlistBox
            // 
            this.OrdenlistBox.FormattingEnabled = true;
            this.OrdenlistBox.Items.AddRange(new object[] {
            "Cadenas Ordenadas:"});
            this.OrdenlistBox.Location = new System.Drawing.Point(12, 101);
            this.OrdenlistBox.Name = "OrdenlistBox";
            this.OrdenlistBox.Size = new System.Drawing.Size(260, 95);
            this.OrdenlistBox.TabIndex = 4;
            // 
            // Presionabutton
            // 
            this.Presionabutton.Location = new System.Drawing.Point(102, 226);
            this.Presionabutton.Name = "Presionabutton";
            this.Presionabutton.Size = new System.Drawing.Size(75, 23);
            this.Presionabutton.TabIndex = 5;
            this.Presionabutton.Text = "Presionar";
            this.Presionabutton.UseVisualStyleBackColor = true;
            this.Presionabutton.Click += new System.EventHandler(this.Presionabutton_Click);
            // 
            // OrdenarCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Presionabutton);
            this.Controls.Add(this.OrdenlistBox);
            this.Controls.Add(this.SegundaCadenatextBox);
            this.Controls.Add(this.PrimeraCadenatextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdenarCadenas";
            this.Text = "Ordenar cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PrimeraCadenatextBox;
        private System.Windows.Forms.TextBox SegundaCadenatextBox;
        private System.Windows.Forms.ListBox OrdenlistBox;
        private System.Windows.Forms.Button Presionabutton;
    }
}