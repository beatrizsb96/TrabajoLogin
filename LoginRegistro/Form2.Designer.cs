﻿namespace LoginRegistro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(117, 218);
            label1.Name = "label1";
            label1.Size = new Size(93, 36);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(97, 312);
            label2.Name = "label2";
            label2.Size = new Size(128, 36);
            label2.TabIndex = 1;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.BackColor = Color.White;
            button1.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.HotTrack;
            button1.Location = new Point(204, 408);
            button1.Name = "button1";
            button1.Size = new Size(141, 46);
            button1.TabIndex = 2;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(277, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Sitka Display", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(277, 312);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 39);
            textBox2.TabIndex = 4;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Sitka Display", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(218, 89);
            label3.Name = "label3";
            label3.Size = new Size(114, 49);
            label3.TabIndex = 5;
            label3.Text = "LOGIN";
            label3.Click += label3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(563, 561);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}