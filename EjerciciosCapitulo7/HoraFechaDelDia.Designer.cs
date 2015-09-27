namespace EjerciciosCapitulo7
{
    partial class HoraFechaDelDia
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
            this.Desplegarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FechalistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Desplegarbutton
            // 
            this.Desplegarbutton.Location = new System.Drawing.Point(104, 199);
            this.Desplegarbutton.Name = "Desplegarbutton";
            this.Desplegarbutton.Size = new System.Drawing.Size(75, 23);
            this.Desplegarbutton.TabIndex = 0;
            this.Desplegarbutton.Text = "Desplegar";
            this.Desplegarbutton.UseVisualStyleBackColor = true;
            this.Desplegarbutton.Click += new System.EventHandler(this.Desplegarbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha y hora";
            // 
            // FechalistBox
            // 
            this.FechalistBox.FormattingEnabled = true;
            this.FechalistBox.Items.AddRange(new object[] {
            "Hora y fecha"});
            this.FechalistBox.Location = new System.Drawing.Point(12, 75);
            this.FechalistBox.Name = "FechalistBox";
            this.FechalistBox.Size = new System.Drawing.Size(260, 95);
            this.FechalistBox.TabIndex = 2;
            // 
            // HoraFechaDelDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.FechalistBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Desplegarbutton);
            this.Name = "HoraFechaDelDia";
            this.Text = "Hora y fecha del dia";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Desplegarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox FechalistBox;
    }
}