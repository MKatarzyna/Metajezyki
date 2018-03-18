using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace PlannerUrodowy
{
    public partial class Form1 : Form
    {
        XmlDocument document;

        String glownaCzescCiala;
        String wybranaCzescCiala;
        String rodzajZabiegu;
        String dataPlanowanegoZabiegu;
        String opisZabiegu;
        String kosztZabiegu;

        public Form1()
        {
            InitializeComponent();
            document = new XmlDocument();
            document.Load("./uslugi.xml");

        }

        public void WyczyscDane()
        {
            glownaCzescCiala = "";
            wybranaCzescCiala = "";
            rodzajZabiegu = "";
            dataPlanowanegoZabiegu = "";
            opisZabiegu = "";
            kosztZabiegu = "";
        }

        private void WyswietlDaneWTabeli(int idKategorii)
        {
            int iloscZabiegow;
            XmlNodeList nodelistUslugi = document.DocumentElement.SelectNodes("/planerUrodowy/zadbajO/zabieg[@id_kategorii='" + idKategorii + "']");
            iloscZabiegow = nodelistUslugi.Count;
            Console.WriteLine("ilosc zabiegow: " + iloscZabiegow);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < iloscZabiegow; i++)
            {
                XmlNode node = nodelistUslugi.Item(i);

                glownaCzescCiala = node.SelectSingleNode("glownaCzescCiala").InnerText;
                wybranaCzescCiala = node.SelectSingleNode("wybranaCzescCiala").InnerText;
                rodzajZabiegu = node.SelectSingleNode("rodzajZabiegu").InnerText;
                dataPlanowanegoZabiegu = node.SelectSingleNode("dataPlanowanegoZabiegu").InnerText;
                opisZabiegu = node.SelectSingleNode("opisZabiegu").InnerText;
                kosztZabiegu = node.SelectSingleNode("kosztZabiegu").InnerText;

                dataGridView1.Rows.Add(glownaCzescCiala, wybranaCzescCiala, rodzajZabiegu, dataPlanowanegoZabiegu, opisZabiegu, kosztZabiegu);
            }
        }

        private void buttonGlowa_Click(object sender, EventArgs e)
        {
            WyswietlDaneWTabeli(1);
        }

        private void buttonDlonieStopy_Click(object sender, EventArgs e)
        {
            WyswietlDaneWTabeli(2);
        }

        private void buttonCialo_Click(object sender, EventArgs e)
        {
            WyswietlDaneWTabeli(3);
        }
    }
}
