using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logika;

namespace ZadB9
{
    public partial class Form1 : Form
    {
        Zamowienie zamowienie = new Zamowienie();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "0";
            label4.Text = "0";
            zamowienie = new Zamowienie();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Salatka.TypSalatki typ = Salatka.TypSalatki.ZPomidorem; //Wartośc domyslna
            if (comboBox1.SelectedIndex == 0) typ = Salatka.TypSalatki.ZKurczakiem;
            if (comboBox1.SelectedIndex == 1) typ = Salatka.TypSalatki.ZSerem;
            if (comboBox1.SelectedIndex == 2) typ = Salatka.TypSalatki.ZPomidorem;
            zamowienie.DodajProdukt(new Salatka(typ));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            zamowienie.DodajProdukt(new HotDog(checkBox1.Checked, checkBox2.Checked));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pizza p = new Pizza((int)numericUpDown1.Value);
            if (checkBox3.Checked) p.DodajSkladnik(new Pomidor());
            if (checkBox4.Checked) p.DodajSkladnik(new Ser());
            zamowienie.DodajProdukt(p);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zamowienie.Zamow();
            label3.Text = zamowienie.Cena.ToString();
            label4.Text = zamowienie.CzasProdukcji.ToString();
        }
    }
}
