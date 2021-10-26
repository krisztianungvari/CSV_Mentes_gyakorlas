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
    public partial class KutyaForm : Form
    {
        public KutyaForm()
        {
            InitializeComponent();
        }

        private void button_Felvitel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(textBox_Nem.Text))
            {
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dtp_Szuletesi_ido.MaxDate > dtp_Szuletesi_ido.Value)
            {
                MessageBox.Show("Nincs kitöltve!", "HIBA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                KutyaOsztaly kutyaOsztaly = new KutyaOsztaly(textBox_Nev.Text, textBox_Nem.Text, dtp_Szuletesi_ido.Value);
                
            }
        }
    }
}
