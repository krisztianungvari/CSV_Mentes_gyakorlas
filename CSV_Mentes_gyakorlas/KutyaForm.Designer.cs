
namespace CSV_Mentes_gyakorlas
{
    partial class KutyaForm
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
            this.textBox_Nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Nem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_Szuletesi_ido = new System.Windows.Forms.DateTimePicker();
            this.button_Felvitel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név : ";
            // 
            // textBox_Nev
            // 
            this.textBox_Nev.Location = new System.Drawing.Point(13, 32);
            this.textBox_Nev.Name = "textBox_Nev";
            this.textBox_Nev.Size = new System.Drawing.Size(163, 23);
            this.textBox_Nev.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Neme : ";
            // 
            // textBox_Nem
            // 
            this.textBox_Nem.Location = new System.Drawing.Point(13, 81);
            this.textBox_Nem.Name = "textBox_Nem";
            this.textBox_Nem.Size = new System.Drawing.Size(163, 23);
            this.textBox_Nem.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Születési idő : ";
            // 
            // dtp_Szuletesi_ido
            // 
            this.dtp_Szuletesi_ido.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Szuletesi_ido.Location = new System.Drawing.Point(13, 130);
            this.dtp_Szuletesi_ido.MaxDate = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            this.dtp_Szuletesi_ido.Name = "dtp_Szuletesi_ido";
            this.dtp_Szuletesi_ido.Size = new System.Drawing.Size(163, 23);
            this.dtp_Szuletesi_ido.TabIndex = 5;
            this.dtp_Szuletesi_ido.Value = new System.DateTime(2021, 10, 25, 0, 0, 0, 0);
            // 
            // button_Felvitel
            // 
            this.button_Felvitel.Location = new System.Drawing.Point(13, 169);
            this.button_Felvitel.Name = "button_Felvitel";
            this.button_Felvitel.Size = new System.Drawing.Size(163, 23);
            this.button_Felvitel.TabIndex = 6;
            this.button_Felvitel.Text = "Felvitel";
            this.button_Felvitel.UseVisualStyleBackColor = true;
            this.button_Felvitel.Click += new System.EventHandler(this.button_Felvitel_Click);
            // 
            // KutyaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 202);
            this.Controls.Add(this.button_Felvitel);
            this.Controls.Add(this.dtp_Szuletesi_ido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Nem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Nev);
            this.Controls.Add(this.label1);
            this.Name = "KutyaForm";
            this.Text = "KutyaForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Nem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_Szuletesi_ido;
        private System.Windows.Forms.Button button_Felvitel;
    }
}