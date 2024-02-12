namespace LoginRegistro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Sitka Display", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 40);
            label1.Name = "label1";
            label1.Size = new Size(294, 35);
            label1.TabIndex = 0;
            label1.Text = "FORMULARIO DE REGISTRO";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(87, 29);
            label2.TabIndex = 1;
            label2.Text = "Nombre:";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 147);
            label3.Name = "label3";
            label3.Size = new Size(75, 29);
            label3.TabIndex = 2;
            label3.Text = "Correo:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 195);
            label4.Name = "label4";
            label4.Size = new Size(114, 29);
            label4.TabIndex = 3;
            label4.Text = "Contraseña:";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 245);
            label5.Name = "label5";
            label5.Size = new Size(178, 29);
            label5.TabIndex = 4;
            label5.Text = "Validar contraseña:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(204, 94);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 33);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(204, 143);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 33);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(204, 191);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 33);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(204, 241);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 33);
            textBox4.TabIndex = 8;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(128, 327);
            button1.Name = "button1";
            button1.Size = new Size(127, 42);
            button1.TabIndex = 9;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Sitka Display", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkRed;
            label6.Location = new Point(61, 386);
            label6.Name = "label6";
            label6.Size = new Size(258, 29);
            label6.TabIndex = 10;
            label6.Text = "Las contraseñas no coinciden";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(377, 469);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label6;
    }
}