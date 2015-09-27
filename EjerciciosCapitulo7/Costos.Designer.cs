namespace EjerciciosCapitulo7
{
    partial class Costos
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
            this.CotostextBox = new System.Windows.Forms.TextBox();
            this.TotaltextBox = new System.Windows.Forms.TextBox();
            this.OrdenlistBox = new System.Windows.Forms.ListBox();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.OrdenarlistBox = new System.Windows.Forms.ListBox();
            this.Ordenarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Costos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total:";
            // 
            // CotostextBox
            // 
            this.CotostextBox.Location = new System.Drawing.Point(105, 29);
            this.CotostextBox.Name = "CotostextBox";
            this.CotostextBox.Size = new System.Drawing.Size(100, 20);
            this.CotostextBox.TabIndex = 2;
            // 
            // TotaltextBox
            // 
            this.TotaltextBox.Location = new System.Drawing.Point(105, 66);
            this.TotaltextBox.Name = "TotaltextBox";
            this.TotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.TotaltextBox.TabIndex = 3;
            // 
            // OrdenlistBox
            // 
            this.OrdenlistBox.FormattingEnabled = true;
            this.OrdenlistBox.Items.AddRange(new object[] {
            "Costos:"});
            this.OrdenlistBox.Location = new System.Drawing.Point(12, 114);
            this.OrdenlistBox.Name = "OrdenlistBox";
            this.OrdenlistBox.Size = new System.Drawing.Size(107, 95);
            this.OrdenlistBox.TabIndex = 4;
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(44, 226);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(75, 23);
            this.Calcularbutton.TabIndex = 5;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // OrdenarlistBox
            // 
            this.OrdenarlistBox.FormattingEnabled = true;
            this.OrdenarlistBox.Items.AddRange(new object[] {
            "Ordenados:"});
            this.OrdenarlistBox.Location = new System.Drawing.Point(152, 114);
            this.OrdenarlistBox.Name = "OrdenarlistBox";
            this.OrdenarlistBox.Size = new System.Drawing.Size(120, 95);
            this.OrdenarlistBox.TabIndex = 6;
            // 
            // Ordenarbutton
            // 
            this.Ordenarbutton.Location = new System.Drawing.Point(152, 226);
            this.Ordenarbutton.Name = "Ordenarbutton";
            this.Ordenarbutton.Size = new System.Drawing.Size(75, 23);
            this.Ordenarbutton.TabIndex = 7;
            this.Ordenarbutton.Text = "Ordenar";
            this.Ordenarbutton.UseVisualStyleBackColor = true;
            this.Ordenarbutton.Click += new System.EventHandler(this.Ordenarbutton_Click);
            // 
            // Costos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Ordenarbutton);
            this.Controls.Add(this.OrdenarlistBox);
            this.Controls.Add(this.Calcularbutton);
            this.Controls.Add(this.OrdenlistBox);
            this.Controls.Add(this.TotaltextBox);
            this.Controls.Add(this.CotostextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Costos";
            this.Text = "Costos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CotostextBox;
        private System.Windows.Forms.TextBox TotaltextBox;
        private System.Windows.Forms.ListBox OrdenlistBox;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.ListBox OrdenarlistBox;
        private System.Windows.Forms.Button Ordenarbutton;
    }
}