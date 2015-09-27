namespace EjerciciosCapitulo7
{
    partial class AgendaTelefonica
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomtextBox = new System.Windows.Forms.TextBox();
            this.TeltextBox = new System.Windows.Forms.TextBox();
            this.Guarbutton = new System.Windows.Forms.Button();
            this.Busbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ConrichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TeltextBox);
            this.groupBox2.Controls.Add(this.NomtextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir contatos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nombre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Telefono:";
            // 
            // NomtextBox
            // 
            this.NomtextBox.Location = new System.Drawing.Point(59, 26);
            this.NomtextBox.Name = "NomtextBox";
            this.NomtextBox.Size = new System.Drawing.Size(100, 20);
            this.NomtextBox.TabIndex = 2;
            // 
            // TeltextBox
            // 
            this.TeltextBox.Location = new System.Drawing.Point(59, 59);
            this.TeltextBox.Name = "TeltextBox";
            this.TeltextBox.Size = new System.Drawing.Size(100, 20);
            this.TeltextBox.TabIndex = 3;
            // 
            // Guarbutton
            // 
            this.Guarbutton.Location = new System.Drawing.Point(12, 209);
            this.Guarbutton.Name = "Guarbutton";
            this.Guarbutton.Size = new System.Drawing.Size(75, 23);
            this.Guarbutton.TabIndex = 2;
            this.Guarbutton.Text = "Guardar";
            this.Guarbutton.UseVisualStyleBackColor = true;
            this.Guarbutton.Click += new System.EventHandler(this.Guarbutton_Click);
            // 
            // Busbutton
            // 
            this.Busbutton.Location = new System.Drawing.Point(137, 209);
            this.Busbutton.Name = "Busbutton";
            this.Busbutton.Size = new System.Drawing.Size(75, 23);
            this.Busbutton.TabIndex = 3;
            this.Busbutton.Text = "Buscar";
            this.Busbutton.UseVisualStyleBackColor = true;
            this.Busbutton.Click += new System.EventHandler(this.Busbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(103, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Guarda tus contactos";
            // 
            // ConrichTextBox
            // 
            this.ConrichTextBox.Location = new System.Drawing.Point(261, 66);
            this.ConrichTextBox.Name = "ConrichTextBox";
            this.ConrichTextBox.ReadOnly = true;
            this.ConrichTextBox.Size = new System.Drawing.Size(193, 100);
            this.ConrichTextBox.TabIndex = 5;
            this.ConrichTextBox.Text = "";
            // 
            // AgendaTelefonica
            // 
            this.ClientSize = new System.Drawing.Size(466, 293);
            this.Controls.Add(this.ConrichTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Busbutton);
            this.Controls.Add(this.Guarbutton);
            this.Controls.Add(this.groupBox2);
            this.Name = "AgendaTelefonica";
            this.Text = "Agenda";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.TextBox TelefonotextBox;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ListBox ContatoslistBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Limpiarbutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TeltextBox;
        private System.Windows.Forms.TextBox NomtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guarbutton;
        private System.Windows.Forms.Button Busbutton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox ConrichTextBox;
    }
}