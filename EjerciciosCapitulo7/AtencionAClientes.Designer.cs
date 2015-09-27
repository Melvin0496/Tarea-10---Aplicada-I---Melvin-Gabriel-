namespace EjerciciosCapitulo7
{
    partial class AtencionAClientes
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
            this.ClientestextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LlegadalistBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SalidalistBox = new System.Windows.Forms.ListBox();
            this.Atenderbutton = new System.Windows.Forms.Button();
            this.Despacharbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Atencion a Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clientes:";
            // 
            // ClientestextBox
            // 
            this.ClientestextBox.Location = new System.Drawing.Point(158, 93);
            this.ClientestextBox.Name = "ClientestextBox";
            this.ClientestextBox.Size = new System.Drawing.Size(100, 20);
            this.ClientestextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LlegadalistBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 133);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 143);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Llegada de los clientes:";
            // 
            // LlegadalistBox
            // 
            this.LlegadalistBox.FormattingEnabled = true;
            this.LlegadalistBox.Items.AddRange(new object[] {
            "Llegada Clientes"});
            this.LlegadalistBox.Location = new System.Drawing.Point(3, 30);
            this.LlegadalistBox.Name = "LlegadalistBox";
            this.LlegadalistBox.Size = new System.Drawing.Size(191, 95);
            this.LlegadalistBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.SalidalistBox);
            this.groupBox2.Location = new System.Drawing.Point(261, 133);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 143);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salida de los clientes:";
            // 
            // SalidalistBox
            // 
            this.SalidalistBox.FormattingEnabled = true;
            this.SalidalistBox.Items.AddRange(new object[] {
            "Salida Clientes"});
            this.SalidalistBox.Location = new System.Drawing.Point(6, 30);
            this.SalidalistBox.Name = "SalidalistBox";
            this.SalidalistBox.Size = new System.Drawing.Size(188, 95);
            this.SalidalistBox.TabIndex = 5;
            // 
            // Atenderbutton
            // 
            this.Atenderbutton.Location = new System.Drawing.Point(108, 313);
            this.Atenderbutton.Name = "Atenderbutton";
            this.Atenderbutton.Size = new System.Drawing.Size(75, 23);
            this.Atenderbutton.TabIndex = 5;
            this.Atenderbutton.Text = "Atender";
            this.Atenderbutton.UseVisualStyleBackColor = true;
            this.Atenderbutton.Click += new System.EventHandler(this.Atenderbutton_Click);
            // 
            // Despacharbutton
            // 
            this.Despacharbutton.Location = new System.Drawing.Point(297, 313);
            this.Despacharbutton.Name = "Despacharbutton";
            this.Despacharbutton.Size = new System.Drawing.Size(75, 23);
            this.Despacharbutton.TabIndex = 6;
            this.Despacharbutton.Text = "Despachar";
            this.Despacharbutton.UseVisualStyleBackColor = true;
            this.Despacharbutton.Click += new System.EventHandler(this.Despacharbutton_Click);
            // 
            // AtencionAClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 366);
            this.Controls.Add(this.Despacharbutton);
            this.Controls.Add(this.Atenderbutton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ClientestextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AtencionAClientes";
            this.Text = "Atencion a clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientestextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LlegadalistBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox SalidalistBox;
        private System.Windows.Forms.Button Atenderbutton;
        private System.Windows.Forms.Button Despacharbutton;
    }
}