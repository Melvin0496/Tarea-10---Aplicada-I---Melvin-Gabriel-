namespace EjerciciosCapitulo7
{
    partial class CadenaJustificada
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.JustificadalistBox = new System.Windows.Forms.ListBox();
            this.Presionarbutton = new System.Windows.Forms.Button();
            this.DerecharadioButton = new System.Windows.Forms.RadioButton();
            this.IzquierdaradioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CadenatextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Introducir cadena:";
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(59, 23);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(100, 20);
            this.CadenatextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadena:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.IzquierdaradioButton);
            this.groupBox2.Controls.Add(this.DerecharadioButton);
            this.groupBox2.Location = new System.Drawing.Point(188, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(161, 110);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de justificarla:";
            // 
            // JustificadalistBox
            // 
            this.JustificadalistBox.FormattingEnabled = true;
            this.JustificadalistBox.Items.AddRange(new object[] {
            "Cadena justificada:"});
            this.JustificadalistBox.Location = new System.Drawing.Point(9, 128);
            this.JustificadalistBox.Name = "JustificadalistBox";
            this.JustificadalistBox.Size = new System.Drawing.Size(163, 95);
            this.JustificadalistBox.TabIndex = 3;
            // 
            // Presionarbutton
            // 
            this.Presionarbutton.Location = new System.Drawing.Point(225, 161);
            this.Presionarbutton.Name = "Presionarbutton";
            this.Presionarbutton.Size = new System.Drawing.Size(75, 23);
            this.Presionarbutton.TabIndex = 4;
            this.Presionarbutton.Text = "Presionar";
            this.Presionarbutton.UseVisualStyleBackColor = true;
            this.Presionarbutton.Click += new System.EventHandler(this.Presionarbutton_Click);
            // 
            // DerecharadioButton
            // 
            this.DerecharadioButton.AutoSize = true;
            this.DerecharadioButton.Location = new System.Drawing.Point(6, 24);
            this.DerecharadioButton.Name = "DerecharadioButton";
            this.DerecharadioButton.Size = new System.Drawing.Size(66, 17);
            this.DerecharadioButton.TabIndex = 0;
            this.DerecharadioButton.TabStop = true;
            this.DerecharadioButton.Text = "Derecha";
            this.DerecharadioButton.UseVisualStyleBackColor = true;
            // 
            // IzquierdaradioButton
            // 
            this.IzquierdaradioButton.AutoSize = true;
            this.IzquierdaradioButton.Location = new System.Drawing.Point(6, 56);
            this.IzquierdaradioButton.Name = "IzquierdaradioButton";
            this.IzquierdaradioButton.Size = new System.Drawing.Size(68, 17);
            this.IzquierdaradioButton.TabIndex = 1;
            this.IzquierdaradioButton.TabStop = true;
            this.IzquierdaradioButton.Text = "Izquierda";
            this.IzquierdaradioButton.UseVisualStyleBackColor = true;
            // 
            // CadenaJustificada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.Presionarbutton);
            this.Controls.Add(this.JustificadalistBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadenaJustificada";
            this.Text = "Cadena justificada";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox JustificadalistBox;
        private System.Windows.Forms.Button Presionarbutton;
        private System.Windows.Forms.RadioButton IzquierdaradioButton;
        private System.Windows.Forms.RadioButton DerecharadioButton;
    }
}