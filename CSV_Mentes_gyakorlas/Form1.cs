using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBox_MacskaNem.Text))
            {
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (DTP_Macska.MaxDate > DTP_Macska.Value)
            {
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                 MacskaOsztaly macskaOsztaly = new MacskaOsztaly(textBox_MacskaNev.Text, textBox_MacskaNem.Text, DTP_Macska.Value);
                listBox_Macska.Items.Add(textBox_MacskaNev.Text, textBox_MacskaNem.Text, DTP_Macska.Value);
            }
        }
    }
}
