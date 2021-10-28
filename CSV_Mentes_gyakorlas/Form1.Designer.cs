
namespace CSV_Mentes_gyakorlas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_UjKutya = new System.Windows.Forms.Button();
            this.listBox_Kutya = new System.Windows.Forms.ListBox();
            this.button_Mentes = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Torles = new System.Windows.Forms.Button();
            this.DTP_Macska = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MacskaNem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MacskaNev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_UjMacska = new System.Windows.Forms.Button();
            this.listBox_Macska = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_UjKutya);
            this.groupBox1.Controls.Add(this.listBox_Kutya);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 222);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kutya";
            // 
            // button_UjKutya
            // 
            this.button_UjKutya.Location = new System.Drawing.Point(6, 177);
            this.button_UjKutya.Name = "button_UjKutya";
            this.button_UjKutya.Size = new System.Drawing.Size(232, 23);
            this.button_UjKutya.TabIndex = 5;
            this.button_UjKutya.Text = "Új Kutya";
            this.button_UjKutya.UseVisualStyleBackColor = true;
            this.button_UjKutya.Click += new System.EventHandler(this.button_UjKutya_Click);
            // 
            // listBox_Kutya
            // 
            this.listBox_Kutya.FormattingEnabled = true;
            this.listBox_Kutya.ItemHeight = 15;
            this.listBox_Kutya.Location = new System.Drawing.Point(6, 20);
            this.listBox_Kutya.Name = "listBox_Kutya";
            this.listBox_Kutya.Size = new System.Drawing.Size(232, 139);
            this.listBox_Kutya.TabIndex = 4;
            // 
            // button_Mentes
            // 
            this.button_Mentes.Location = new System.Drawing.Point(6, 376);
            this.button_Mentes.Name = "button_Mentes";
            this.button_Mentes.Size = new System.Drawing.Size(232, 23);
            this.button_Mentes.TabIndex = 6;
            this.button_Mentes.Text = "Mentés";
            this.button_Mentes.UseVisualStyleBackColor = true;
            this.button_Mentes.Click += new System.EventHandler(this.button_Mentes_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Mentes);
            this.groupBox2.Controls.Add(this.button_Torles);
            this.groupBox2.Controls.Add(this.DTP_Macska);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_MacskaNem);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_MacskaNev);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_UjMacska);
            this.groupBox2.Controls.Add(this.listBox_Macska);
            this.groupBox2.Location = new System.Drawing.Point(276, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 434);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Macska";
            // 
            // button_Torles
            // 
            this.button_Torles.Location = new System.Drawing.Point(6, 405);
            this.button_Torles.Name = "button_Torles";
            this.button_Torles.Size = new System.Drawing.Size(232, 23);
            this.button_Torles.TabIndex = 8;
            this.button_Torles.Text = "Törlés";
            this.button_Torles.UseVisualStyleBackColor = true;
            this.button_Torles.Click += new System.EventHandler(this.button_Torles_Click);
            // 
            // DTP_Macska
            // 
            this.DTP_Macska.Location = new System.Drawing.Point(8, 323);
            this.DTP_Macska.MaxDate = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            this.DTP_Macska.Name = "DTP_Macska";
            this.DTP_Macska.Size = new System.Drawing.Size(232, 23);
            this.DTP_Macska.TabIndex = 13;
            this.DTP_Macska.Value = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Születési idő";
            // 
            // textBox_MacskaNem
            // 
            this.textBox_MacskaNem.Location = new System.Drawing.Point(6, 274);
            this.textBox_MacskaNem.Name = "textBox_MacskaNem";
            this.textBox_MacskaNem.Size = new System.Drawing.Size(234, 23);
            this.textBox_MacskaNem.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nem ";
            // 
            // textBox_MacskaNev
            // 
            this.textBox_MacskaNev.Location = new System.Drawing.Point(6, 225);
            this.textBox_MacskaNev.Name = "textBox_MacskaNev";
            this.textBox_MacskaNev.Size = new System.Drawing.Size(234, 23);
            this.textBox_MacskaNev.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Név";
            // 
            // button_UjMacska
            // 
            this.button_UjMacska.Location = new System.Drawing.Point(8, 177);
            this.button_UjMacska.Name = "button_UjMacska";
            this.button_UjMacska.Size = new System.Drawing.Size(232, 23);
            this.button_UjMacska.TabIndex = 7;
            this.button_UjMacska.Text = "Új Macska";
            this.button_UjMacska.UseVisualStyleBackColor = true;
            this.button_UjMacska.Click += new System.EventHandler(this.button_UjMacska_Click);
            // 
            // listBox_Macska
            // 
            this.listBox_Macska.FormattingEnabled = true;
            this.listBox_Macska.ItemHeight = 15;
            this.listBox_Macska.Location = new System.Drawing.Point(8, 20);
            this.listBox_Macska.Name = "listBox_Macska";
            this.listBox_Macska.Size = new System.Drawing.Size(232, 139);
            this.listBox_Macska.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 459);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_Mentes;
        private System.Windows.Forms.Button button_UjKutya;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Torles;
        private System.Windows.Forms.Button button_UjMacska;
        private System.Windows.Forms.ListBox listBox_Macska;
        public System.Windows.Forms.ListBox listBox_Kutya;
        private System.Windows.Forms.DateTimePicker DTP_Macska;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MacskaNem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MacskaNev;
        private System.Windows.Forms.Label label1;
    }
}

