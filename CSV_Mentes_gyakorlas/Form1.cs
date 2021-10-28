using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CSV_Mentes_gyakorlas
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button_UjKutya_Click(object sender, EventArgs e)
        {
            KutyaForm kutyaForm = new KutyaForm();
            kutyaForm.ShowDialog();

        }

        private void button_UjMacska_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_MacskaNev.Text))
            {
                MessageBox.Show("Nincs megadva név!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBox_MacskaNem.Text))
            {
                MessageBox.Show("Nincs megadva a nem!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*
            else if (DateTime.Compare(DTP_Macska.MaxDate,DTP_Macska.Value)!= 1)
            {
                MessageBox.Show("Születési dátum nem jó!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } */
            else
            {
                 MacskaOsztaly macskaOsztaly = new MacskaOsztaly(textBox_MacskaNev.Text, textBox_MacskaNem.Text, DTP_Macska.Value);
                listBox_Macska.Items.Add(macskaOsztaly);
            }
        }

        private void button_Mentes_Click(object sender, EventArgs e)
        {
          //  string macskafajl = @"c:\CSV_teszt"; itt én mondom meg hova mentse
            string macskafajl = "CSV_teszt.TXT"; // itt a "felhasználó" a program mellé ment
            // 
            using (StreamWriter kimentes = new StreamWriter(macskafajl, true, Encoding.Default))
            {
                foreach (MacskaOsztaly item in listBox_Macska.Items) //foreach mert végig megy a listboxon, hogy annak a tartalmát kimentse, ne csak 1 sort!
                {
                    kimentes.Write(item.ToString());
                }
            }
            
            
            

        }

        private void button_Torles_Click(object sender, EventArgs e)
        {
            if (listBox_Macska.SelectedIndex != -1)
            {
                if (MessageBox.Show("Biztosan szeretné törölni a macskát?", "Törlés", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    listBox_Macska.Items.RemoveAt(listBox_Macska.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Jelöljön ki egy macskát!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

                
        }
    }
}
