using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikacjaOkienkowa
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Wyczysc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                MessageBox.Show("Nie można wysłać wiadomości bez podania adresata",
                            "Brak adresata",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
            }
            else
            {
                if(textBox1.Text.Length == 0)
                {
                    //pobieranie klikniętej wartości tak/nie z messageBox
                    DialogResult czyWyslac =
                    MessageBox.Show("Nie podano tytułu wiadomości. Czy na pewno chcesz wysłać maila?",
                                "Brak tytułu",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);
                 
                    if(czyWyslac == DialogResult.Yes)
                    {
                        Wyslij(textBox2.Text);
                    }   
                }
                Wyslij(textBox2.Text);
            }
        }

        private void Wyczysc()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            richTextBox1.Text = "";
        }

        private void Wyslij(String adresat)
        {
            MessageBox.Show("Wiadomość została wysłana do " + adresat,
                                "Wysłano",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            Wyczysc();
        }
    }
}
