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

        String idZabieg;
        String glownaCzescCiala;
        String wybranaCzescCiala;
        String rodzajZabiegu;
        String dataPlanowanegoZabiegu;
        String opisZabiegu;
        String kosztZabiegu;

        String panelIdZabiegu;
        String panelKategoria;
        String panelCzescCiala;
        String panelRodzajZabiegu;
        String panelData;
        String panelKoszt;
        String panelOpis;

        int numerAktualnegoDzialu;
        int rodzajWybraneKategorii;

        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            
            comboBoxKategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCzescCiala.DropDownStyle = ComboBoxStyle.DropDownList;
            WyczyscDane();
            WczytajDokumentXML();
        }

        public void WczytajDokumentXML()
        {
            document = new XmlDocument();
            document.Load("../../Resources/uslugi.xml");
        }

        public void WyczyscDane()
        {
            rodzajWybraneKategorii = 0;
            numerAktualnegoDzialu = 0;
            idZabieg = "";
            glownaCzescCiala = "";
            wybranaCzescCiala = "";
            rodzajZabiegu = "";
            dataPlanowanegoZabiegu = "";
            opisZabiegu = "";
            kosztZabiegu = "";

            panelIdZabiegu = "";
            panelKategoria = "";
            panelCzescCiala = "";
            panelRodzajZabiegu = "";
            panelData = "";
            panelKoszt = "";
            panelOpis = "";
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

                XmlAttribute idZabiegAtrybut = (XmlAttribute)node.Attributes.GetNamedItem("id_zabieg");
                idZabieg = idZabiegAtrybut.Value;

                glownaCzescCiala = node.SelectSingleNode("glownaCzescCiala").InnerText;
                wybranaCzescCiala = node.SelectSingleNode("wybranaCzescCiala").InnerText;
                rodzajZabiegu = node.SelectSingleNode("rodzajZabiegu").InnerText;
                dataPlanowanegoZabiegu = node.SelectSingleNode("dataPlanowanegoZabiegu").InnerText;
                opisZabiegu = node.SelectSingleNode("opisZabiegu").InnerText;
                kosztZabiegu = node.SelectSingleNode("kosztZabiegu").InnerText;

                dataGridView1.Rows.Add(idZabieg, glownaCzescCiala, wybranaCzescCiala, rodzajZabiegu, dataPlanowanegoZabiegu, opisZabiegu, kosztZabiegu);
            }
        }

        private void buttonGlowa_Click(object sender, EventArgs e)
        {
            numerAktualnegoDzialu = 1;
            WyswietlDaneWTabeli(numerAktualnegoDzialu);
        }

        private void buttonDlonieStopy_Click(object sender, EventArgs e)
        {
            numerAktualnegoDzialu = 2;
            WyswietlDaneWTabeli(numerAktualnegoDzialu);
        }

        private void buttonCialo_Click(object sender, EventArgs e)
        {
            numerAktualnegoDzialu = 3;
            WyswietlDaneWTabeli(numerAktualnegoDzialu);
        }

        private void buttonUsun_Click(object sender, EventArgs e)
        {
            String komorkaIdZabieg;
            String xPathElement;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // podbrac zaznaczony id zabiegu
                komorkaIdZabieg = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                
                // utworzyc xpath
                xPathElement = "/planerUrodowy/zadbajO/zabieg[@id_zabieg='" + komorkaIdZabieg + "']";

                var potwierdzenie = MessageBox.Show("Czy chcesz na pewno usunąć dany wiersz?", "Potwierdzenie", MessageBoxButtons.YesNo);
                if (potwierdzenie == DialogResult.Yes)
                {
                    // usunac cały tag dla konkretnego id zabiegu
                    WczytajDokumentXML();
                    XmlNode node = document.SelectSingleNode(xPathElement);
                    node.RemoveAll();

                    XmlNode parentNode = node.ParentNode;
                    parentNode.RemoveChild(node);
                    document.Save("../../Resources/uslugi.xml");
                    WyswietlDaneWTabeli(numerAktualnegoDzialu);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz poprawnie cały wiersz", "Informacja", MessageBoxButtons.OK);
            }
        }

        public void WyczyscElementyZListy()
        {
            comboBoxCzescCiala.Items.Clear();
        }

        public void WypelnijListe()
        {
            comboBoxCzescCiala.Items.Add("Włosy");
            comboBoxCzescCiala.Items.Add("Twarz");
            comboBoxCzescCiala.Items.Add("Paznokcie");
            comboBoxCzescCiala.Items.Add("Dłonie");
            comboBoxCzescCiala.Items.Add("Stopy");
            comboBoxCzescCiala.Items.Add("Całe ciało");
            comboBoxCzescCiala.Items.Add("Nogi");
        }

        private void buttonEdytuj_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Visible = true;
                numerAktualnegoDzialu = 1;

                textBoxRodzajZabiegu.Enabled = false;
                comboBoxKategoria.Enabled = false;
                comboBoxCzescCiala.Enabled = false;

                WyczyscElementyZListy();

                WypelnijListe();
               
                // do zmiennych lokalnych pobrac wartości z tych pól do nowych stringów (podane wyzej)
                panelIdZabiegu = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                panelKategoria = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
                panelCzescCiala = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
                panelRodzajZabiegu = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[3].Value.ToString();
                panelData = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString();
                panelOpis = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString();
                panelKoszt = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[6].Value.ToString();
               
                comboBoxKategoria.SelectedIndex = comboBoxKategoria.FindStringExact(panelKategoria);
                comboBoxCzescCiala.SelectedIndex = comboBoxCzescCiala.FindStringExact(panelCzescCiala);
                textBoxRodzajZabiegu.Text = panelRodzajZabiegu;
                textBoxKoszt.Text = panelKoszt;
                textBoxOpis.Text = panelOpis;

                if (panelData != null && !panelData.Equals(""))
                {
                    dateTimePicker1.Value = DateTime.Parse(panelData);
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Today;
                }
            }
            else
            {
                MessageBox.Show("Zaznacz poprawnie cały wiersz, aby edytować.", "Informacja", MessageBoxButtons.OK);
            }  
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            numerAktualnegoDzialu = 2;

            textBoxRodzajZabiegu.Enabled = true;
            comboBoxKategoria.Enabled = true;
            comboBoxCzescCiala.Enabled = true;

            textBoxRodzajZabiegu.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            textBoxKoszt.Text = "";
            textBoxOpis.Text = "";
        }

        private void buttonAnuluj_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void buttonZatwierdz_Click(object sender, EventArgs e)
        {
            String xPathElement;

            if (numerAktualnegoDzialu == 1)
            {
                //EDYCJA

                // utwożyć xpath do zabiegu który bedzie edytowany
                xPathElement = "/planerUrodowy/zadbajO/zabieg[@id_zabieg='" + panelIdZabiegu + "']";

                // edytowac xml  i zapisac go
                WczytajDokumentXML();
                XmlNode nodes = document.SelectSingleNode(xPathElement);

                nodes.SelectSingleNode("dataPlanowanegoZabiegu").InnerText = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                nodes.SelectSingleNode("kosztZabiegu").InnerText = textBoxKoszt.Text;
                nodes.SelectSingleNode("opisZabiegu").InnerText = textBoxOpis.Text;
                document.Save("../../Resources/uslugi.xml");
                WyswietlDaneWTabeli(numerAktualnegoDzialu);
                panel1.Visible = false;
            }
            else if (numerAktualnegoDzialu == 2)
            {
                // DODAWANIE

                WczytajDokumentXML();
                var maxId = document.SelectNodes("/planerUrodowy/zadbajO/zabieg")
                                   .Cast<XmlElement>()
                                   .Max(c => Int32.Parse(c.Attributes["id_zabieg"].Value));
                Console.WriteLine("JAKI ID: " + maxId);

                XmlElement el = (XmlElement)document.SelectSingleNode("/planerUrodowy/zadbajO");
                XmlElement elem = document.CreateElement("zabieg");
                elem.SetAttribute("id_zabieg", (maxId + 1).ToString());
                elem.SetAttribute("id_kategorii", rodzajWybraneKategorii.ToString());
                el.AppendChild(elem);

                XmlElement subElem1 = document.CreateElement("glownaCzescCiala");
                subElem1.InnerText = comboBoxKategoria.Text;
                elem.AppendChild(subElem1);

                XmlElement subElem2 = document.CreateElement("wybranaCzescCiala");
                subElem2.InnerText = comboBoxCzescCiala.Text;
                elem.AppendChild(subElem2);

                XmlElement subElem3 = document.CreateElement("rodzajZabiegu");
                subElem3.InnerText = textBoxRodzajZabiegu.Text;
                elem.AppendChild(subElem3);

                XmlElement subElem4 = document.CreateElement("dataPlanowanegoZabiegu");
                subElem4.InnerText = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                elem.AppendChild(subElem4);

                XmlElement subElem5 = document.CreateElement("kosztZabiegu");
                subElem5.InnerText = textBoxKoszt.Text;
                elem.AppendChild(subElem5);

                XmlElement subElem6 = document.CreateElement("opisZabiegu");
                subElem6.InnerText = textBoxOpis.Text;
                elem.AppendChild(subElem6);

                document.Save("../../Resources/uslugi.xml");
                numerAktualnegoDzialu = rodzajWybraneKategorii;
                WyswietlDaneWTabeli(numerAktualnegoDzialu);
                panel1.Visible = false;
            }
        }

        private void comboBoxKategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKategoria.SelectedIndex == 0)
            {
                //GŁOWA
                WyczyscElementyZListy();
                comboBoxCzescCiala.Items.Add("Włosy");
                comboBoxCzescCiala.Items.Add("Twarz");
                rodzajWybraneKategorii = 1;
            }
            else if (comboBoxKategoria.SelectedIndex == 1)
            {
                //DŁONIE I STOPY
                WyczyscElementyZListy();
                comboBoxCzescCiala.Items.Add("Paznokcie");
                comboBoxCzescCiala.Items.Add("Dłonie");
                comboBoxCzescCiala.Items.Add("Stopy");
                rodzajWybraneKategorii = 2;
            }
            else if (comboBoxKategoria.SelectedIndex == 2)
            {
                // CIAŁO
                WyczyscElementyZListy();
                comboBoxCzescCiala.Items.Add("Całe ciało");
                comboBoxCzescCiala.Items.Add("Nogi");
                rodzajWybraneKategorii = 3;
            }
        }
    }
}
