namespace Gyümölcs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBox1_gyümölcsök = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.be = new System.Windows.Forms.Button();
            this.textBox3_egysegar = new System.Windows.Forms.TextBox();
            this.textBox2_nev = new System.Windows.Forms.TextBox();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1_gyümölcsök
            // 
            this.listBox1_gyümölcsök.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1_gyümölcsök.FormattingEnabled = true;
            this.listBox1_gyümölcsök.Location = new System.Drawing.Point(0, 0);
            this.listBox1_gyümölcsök.Name = "listBox1_gyümölcsök";
            this.listBox1_gyümölcsök.Size = new System.Drawing.Size(134, 450);
            this.listBox1_gyümölcsök.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.be);
            this.groupBox1.Controls.Add(this.textBox3_egysegar);
            this.groupBox1.Controls.Add(this.textBox2_nev);
            this.groupBox1.Controls.Add(this.textBox1_id);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(134, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatok bevitele:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(109, 197);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(130, 20);
            this.numericUpDown1.TabIndex = 19;
            // 
            // be
            // 
            this.be.Location = new System.Drawing.Point(109, 268);
            this.be.Name = "be";
            this.be.Size = new System.Drawing.Size(130, 23);
            this.be.TabIndex = 18;
            this.be.Text = "Be";
            this.be.UseVisualStyleBackColor = true;
            this.be.Click += new System.EventHandler(this.be_Click);
            // 
            // textBox3_egysegar
            // 
            this.textBox3_egysegar.Location = new System.Drawing.Point(109, 151);
            this.textBox3_egysegar.Name = "textBox3_egysegar";
            this.textBox3_egysegar.Size = new System.Drawing.Size(130, 20);
            this.textBox3_egysegar.TabIndex = 17;
            // 
            // textBox2_nev
            // 
            this.textBox2_nev.Location = new System.Drawing.Point(109, 100);
            this.textBox2_nev.Name = "textBox2_nev";
            this.textBox2_nev.Size = new System.Drawing.Size(130, 20);
            this.textBox2_nev.TabIndex = 16;
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(109, 56);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.ReadOnly = true;
            this.textBox1_id.Size = new System.Drawing.Size(130, 20);
            this.textBox1_id.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mennyiség:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Egységár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Név:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1_gyümölcsök);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Gyümölcsök adatai";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1_gyümölcsök;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button be;
        private System.Windows.Forms.TextBox textBox3_egysegar;
        private System.Windows.Forms.TextBox textBox2_nev;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

