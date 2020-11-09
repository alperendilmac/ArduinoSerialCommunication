namespace ardo
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.baslat = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.derece = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.durdur = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORT :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 23);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(148, 232);
            this.textBox1.TabIndex = 2;
            // 
            // baslat
            // 
            this.baslat.Location = new System.Drawing.Point(65, 97);
            this.baslat.Name = "baslat";
            this.baslat.Size = new System.Drawing.Size(72, 23);
            this.baslat.TabIndex = 3;
            this.baslat.Text = "Başlat";
            this.baslat.UseVisualStyleBackColor = true;
            this.baslat.Click += new System.EventHandler(this.baslat_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(65, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(72, 20);
            this.textBox2.TabIndex = 4;
            // 
            // derece
            // 
            this.derece.Location = new System.Drawing.Point(65, 166);
            this.derece.Name = "derece";
            this.derece.Size = new System.Drawing.Size(72, 20);
            this.derece.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ayarla";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // durdur
            // 
            this.durdur.Location = new System.Drawing.Point(65, 126);
            this.durdur.Name = "durdur";
            this.durdur.Size = new System.Drawing.Size(72, 23);
            this.durdur.TabIndex = 7;
            this.durdur.Text = "Durdur";
            this.durdur.UseVisualStyleBackColor = true;
            this.durdur.Click += new System.EventHandler(this.durdur_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "°C :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Anlık °C :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 280);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.durdur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.derece);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.baslat);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button baslat;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox derece;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button durdur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

