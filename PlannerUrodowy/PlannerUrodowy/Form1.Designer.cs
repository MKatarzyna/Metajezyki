namespace PlannerUrodowy
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPagePlaner = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.textBoxRodzajZabiegu = new System.Windows.Forms.TextBox();
            this.labelKategoria = new System.Windows.Forms.Label();
            this.labelOpis = new System.Windows.Forms.Label();
            this.comboBoxKategoria = new System.Windows.Forms.ComboBox();
            this.textBoxOpis = new System.Windows.Forms.TextBox();
            this.comboBoxCzescCiala = new System.Windows.Forms.ComboBox();
            this.textBoxKoszt = new System.Windows.Forms.TextBox();
            this.labelCzescCiala = new System.Windows.Forms.Label();
            this.labelKosztZabiegu = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelRodzajZabiegu = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.buttonEdytuj = new System.Windows.Forms.Button();
            this.buttonUsun = new System.Windows.Forms.Button();
            this.buttonCialo = new System.Windows.Forms.Button();
            this.buttonDlonieStopy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Zabiegu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.glownaCzescCiala1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wybranaCzescCiala1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlanowanegoZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGlowa = new System.Windows.Forms.Button();
            this.tabPagePorady = new System.Windows.Forms.TabPage();
            this.tabPageAutorzy = new System.Windows.Forms.TabPage();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxMail = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelAdres = new System.Windows.Forms.Label();
            this.labelNazwisko = new System.Windows.Forms.Label();
            this.labelImie = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonZatwierdzPorady = new System.Windows.Forms.Button();
            this.buttonAnulujPorady = new System.Windows.Forms.Button();
            this.labelPoradaKategoria = new System.Windows.Forms.Label();
            this.labelOpisPorady = new System.Windows.Forms.Label();
            this.comboBoxPoradyKategoria = new System.Windows.Forms.ComboBox();
            this.textBoxOpisPorady = new System.Windows.Forms.TextBox();
            this.buttonUsunPorady = new System.Windows.Forms.Button();
            this.buttonPoradyCialo = new System.Windows.Forms.Button();
            this.buttonPoradyDlonie = new System.Windows.Forms.Button();
            this.buttonPoradyGlowa = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonDodajPorady = new System.Windows.Forms.Button();
            this.buttonEdytujPorady = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisPorady = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPagePlaner.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPagePorady.SuspendLayout();
            this.tabPageAutorzy.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagePlaner);
            this.tabControl1.Controls.Add(this.tabPagePorady);
            this.tabControl1.Controls.Add(this.tabPageAutorzy);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPagePlaner
            // 
            this.tabPagePlaner.Controls.Add(this.panel1);
            this.tabPagePlaner.Controls.Add(this.buttonDodaj);
            this.tabPagePlaner.Controls.Add(this.buttonEdytuj);
            this.tabPagePlaner.Controls.Add(this.buttonUsun);
            this.tabPagePlaner.Controls.Add(this.buttonCialo);
            this.tabPagePlaner.Controls.Add(this.buttonDlonieStopy);
            this.tabPagePlaner.Controls.Add(this.dataGridView1);
            this.tabPagePlaner.Controls.Add(this.buttonGlowa);
            this.tabPagePlaner.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlaner.Name = "tabPagePlaner";
            this.tabPagePlaner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePlaner.Size = new System.Drawing.Size(1092, 531);
            this.tabPagePlaner.TabIndex = 0;
            this.tabPagePlaner.Text = "Planer";
            this.tabPagePlaner.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonZatwierdz);
            this.panel1.Controls.Add(this.buttonAnuluj);
            this.panel1.Controls.Add(this.textBoxRodzajZabiegu);
            this.panel1.Controls.Add(this.labelKategoria);
            this.panel1.Controls.Add(this.labelOpis);
            this.panel1.Controls.Add(this.comboBoxKategoria);
            this.panel1.Controls.Add(this.textBoxOpis);
            this.panel1.Controls.Add(this.comboBoxCzescCiala);
            this.panel1.Controls.Add(this.textBoxKoszt);
            this.panel1.Controls.Add(this.labelCzescCiala);
            this.panel1.Controls.Add(this.labelKosztZabiegu);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.labelRodzajZabiegu);
            this.panel1.Controls.Add(this.labelData);
            this.panel1.Location = new System.Drawing.Point(676, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 267);
            this.panel1.TabIndex = 19;
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(314, 231);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(75, 23);
            this.buttonZatwierdz.TabIndex = 21;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(233, 231);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(75, 23);
            this.buttonAnuluj.TabIndex = 20;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // textBoxRodzajZabiegu
            // 
            this.textBoxRodzajZabiegu.Location = new System.Drawing.Point(271, 43);
            this.textBoxRodzajZabiegu.Name = "textBoxRodzajZabiegu";
            this.textBoxRodzajZabiegu.Size = new System.Drawing.Size(118, 20);
            this.textBoxRodzajZabiegu.TabIndex = 19;
            // 
            // labelKategoria
            // 
            this.labelKategoria.AutoSize = true;
            this.labelKategoria.Location = new System.Drawing.Point(12, 24);
            this.labelKategoria.Name = "labelKategoria";
            this.labelKategoria.Size = new System.Drawing.Size(55, 13);
            this.labelKategoria.TabIndex = 9;
            this.labelKategoria.Text = "Kategoria:";
            // 
            // labelOpis
            // 
            this.labelOpis.AutoSize = true;
            this.labelOpis.Location = new System.Drawing.Point(11, 142);
            this.labelOpis.Name = "labelOpis";
            this.labelOpis.Size = new System.Drawing.Size(71, 13);
            this.labelOpis.TabIndex = 18;
            this.labelOpis.Text = "Opis zabiegu:";
            // 
            // comboBoxKategoria
            // 
            this.comboBoxKategoria.FormattingEnabled = true;
            this.comboBoxKategoria.Items.AddRange(new object[] {
            "GŁOWA",
            "DŁONIE I STOPY",
            "CIAŁO"});
            this.comboBoxKategoria.Location = new System.Drawing.Point(12, 43);
            this.comboBoxKategoria.Name = "comboBoxKategoria";
            this.comboBoxKategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKategoria.TabIndex = 7;
            this.comboBoxKategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategoria_SelectedIndexChanged);
            // 
            // textBoxOpis
            // 
            this.textBoxOpis.Location = new System.Drawing.Point(11, 158);
            this.textBoxOpis.Multiline = true;
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(378, 67);
            this.textBoxOpis.TabIndex = 17;
            // 
            // comboBoxCzescCiala
            // 
            this.comboBoxCzescCiala.FormattingEnabled = true;
            this.comboBoxCzescCiala.Items.AddRange(new object[] {
            "Włosy",
            "Twarz",
            "Paznokcie",
            "Dłonie",
            "Stopy",
            "Całe ciało",
            "Nogi"});
            this.comboBoxCzescCiala.Location = new System.Drawing.Point(140, 42);
            this.comboBoxCzescCiala.Name = "comboBoxCzescCiala";
            this.comboBoxCzescCiala.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCzescCiala.TabIndex = 8;
            // 
            // textBoxKoszt
            // 
            this.textBoxKoszt.Location = new System.Drawing.Point(146, 101);
            this.textBoxKoszt.Name = "textBoxKoszt";
            this.textBoxKoszt.Size = new System.Drawing.Size(115, 20);
            this.textBoxKoszt.TabIndex = 16;
            // 
            // labelCzescCiala
            // 
            this.labelCzescCiala.AutoSize = true;
            this.labelCzescCiala.Location = new System.Drawing.Point(140, 23);
            this.labelCzescCiala.Name = "labelCzescCiala";
            this.labelCzescCiala.Size = new System.Drawing.Size(66, 13);
            this.labelCzescCiala.TabIndex = 10;
            this.labelCzescCiala.Text = "Część ciała:";
            // 
            // labelKosztZabiegu
            // 
            this.labelKosztZabiegu.AutoSize = true;
            this.labelKosztZabiegu.Location = new System.Drawing.Point(143, 83);
            this.labelKosztZabiegu.Name = "labelKosztZabiegu";
            this.labelKosztZabiegu.Size = new System.Drawing.Size(76, 13);
            this.labelKosztZabiegu.TabIndex = 15;
            this.labelKosztZabiegu.Text = "Koszt zabiegu:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 101);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // labelRodzajZabiegu
            // 
            this.labelRodzajZabiegu.AutoSize = true;
            this.labelRodzajZabiegu.Location = new System.Drawing.Point(268, 23);
            this.labelRodzajZabiegu.Name = "labelRodzajZabiegu";
            this.labelRodzajZabiegu.Size = new System.Drawing.Size(83, 13);
            this.labelRodzajZabiegu.TabIndex = 12;
            this.labelRodzajZabiegu.Text = "Rodzaj zabiegu:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(12, 84);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(73, 13);
            this.labelData.TabIndex = 13;
            this.labelData.Text = "Data zabiegu:";
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Location = new System.Drawing.Point(839, 35);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(75, 23);
            this.buttonDodaj.TabIndex = 6;
            this.buttonDodaj.Text = "Dodaj";
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // buttonEdytuj
            // 
            this.buttonEdytuj.Location = new System.Drawing.Point(758, 35);
            this.buttonEdytuj.Name = "buttonEdytuj";
            this.buttonEdytuj.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytuj.TabIndex = 5;
            this.buttonEdytuj.Text = "Edytuj";
            this.buttonEdytuj.UseVisualStyleBackColor = true;
            this.buttonEdytuj.Click += new System.EventHandler(this.buttonEdytuj_Click);
            // 
            // buttonUsun
            // 
            this.buttonUsun.Location = new System.Drawing.Point(677, 35);
            this.buttonUsun.Name = "buttonUsun";
            this.buttonUsun.Size = new System.Drawing.Size(75, 23);
            this.buttonUsun.TabIndex = 4;
            this.buttonUsun.Text = "Usuń";
            this.buttonUsun.UseVisualStyleBackColor = true;
            this.buttonUsun.Click += new System.EventHandler(this.buttonUsun_Click);
            // 
            // buttonCialo
            // 
            this.buttonCialo.Location = new System.Drawing.Point(224, 7);
            this.buttonCialo.Name = "buttonCialo";
            this.buttonCialo.Size = new System.Drawing.Size(91, 23);
            this.buttonCialo.TabIndex = 3;
            this.buttonCialo.Text = "Ciało";
            this.buttonCialo.UseVisualStyleBackColor = true;
            this.buttonCialo.Click += new System.EventHandler(this.buttonCialo_Click);
            // 
            // buttonDlonieStopy
            // 
            this.buttonDlonieStopy.Location = new System.Drawing.Point(115, 6);
            this.buttonDlonieStopy.Name = "buttonDlonieStopy";
            this.buttonDlonieStopy.Size = new System.Drawing.Size(102, 23);
            this.buttonDlonieStopy.TabIndex = 2;
            this.buttonDlonieStopy.Text = "Dłonie i stopy";
            this.buttonDlonieStopy.UseVisualStyleBackColor = true;
            this.buttonDlonieStopy.Click += new System.EventHandler(this.buttonDlonieStopy_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Zabiegu,
            this.glownaCzescCiala1,
            this.wybranaCzescCiala1,
            this.rodzajZabiegu1,
            this.dataPlanowanegoZabiegu1,
            this.opisZabiegu1,
            this.kosztZabiegu1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(664, 493);
            this.dataGridView1.TabIndex = 0;
            // 
            // ID_Zabiegu
            // 
            this.ID_Zabiegu.Frozen = true;
            this.ID_Zabiegu.HeaderText = "ID";
            this.ID_Zabiegu.Name = "ID_Zabiegu";
            this.ID_Zabiegu.ReadOnly = true;
            this.ID_Zabiegu.Width = 20;
            // 
            // glownaCzescCiala1
            // 
            this.glownaCzescCiala1.Frozen = true;
            this.glownaCzescCiala1.HeaderText = "Kategoria";
            this.glownaCzescCiala1.Name = "glownaCzescCiala1";
            this.glownaCzescCiala1.ReadOnly = true;
            // 
            // wybranaCzescCiala1
            // 
            this.wybranaCzescCiala1.HeaderText = "Część ciała";
            this.wybranaCzescCiala1.Name = "wybranaCzescCiala1";
            this.wybranaCzescCiala1.ReadOnly = true;
            // 
            // rodzajZabiegu1
            // 
            this.rodzajZabiegu1.HeaderText = "Rodzaj zabiegu";
            this.rodzajZabiegu1.Name = "rodzajZabiegu1";
            this.rodzajZabiegu1.ReadOnly = true;
            // 
            // dataPlanowanegoZabiegu1
            // 
            this.dataPlanowanegoZabiegu1.HeaderText = "Data planowanego zabiegu";
            this.dataPlanowanegoZabiegu1.Name = "dataPlanowanegoZabiegu1";
            this.dataPlanowanegoZabiegu1.ReadOnly = true;
            // 
            // opisZabiegu1
            // 
            this.opisZabiegu1.HeaderText = "Opis zabiegu";
            this.opisZabiegu1.Name = "opisZabiegu1";
            this.opisZabiegu1.ReadOnly = true;
            // 
            // kosztZabiegu1
            // 
            this.kosztZabiegu1.HeaderText = "Koszt zabiegu";
            this.kosztZabiegu1.Name = "kosztZabiegu1";
            this.kosztZabiegu1.ReadOnly = true;
            // 
            // buttonGlowa
            // 
            this.buttonGlowa.Location = new System.Drawing.Point(6, 6);
            this.buttonGlowa.Name = "buttonGlowa";
            this.buttonGlowa.Size = new System.Drawing.Size(102, 23);
            this.buttonGlowa.TabIndex = 1;
            this.buttonGlowa.Text = "Głowa";
            this.buttonGlowa.UseVisualStyleBackColor = true;
            this.buttonGlowa.Click += new System.EventHandler(this.buttonGlowa_Click);
            // 
            // tabPagePorady
            // 
            this.tabPagePorady.Controls.Add(this.buttonDodajPorady);
            this.tabPagePorady.Controls.Add(this.buttonEdytujPorady);
            this.tabPagePorady.Controls.Add(this.dataGridView2);
            this.tabPagePorady.Controls.Add(this.panel2);
            this.tabPagePorady.Controls.Add(this.buttonUsunPorady);
            this.tabPagePorady.Controls.Add(this.buttonPoradyCialo);
            this.tabPagePorady.Controls.Add(this.buttonPoradyDlonie);
            this.tabPagePorady.Controls.Add(this.buttonPoradyGlowa);
            this.tabPagePorady.Location = new System.Drawing.Point(4, 22);
            this.tabPagePorady.Name = "tabPagePorady";
            this.tabPagePorady.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePorady.Size = new System.Drawing.Size(1092, 531);
            this.tabPagePorady.TabIndex = 1;
            this.tabPagePorady.Text = "Porady";
            this.tabPagePorady.UseVisualStyleBackColor = true;
            // 
            // tabPageAutorzy
            // 
            this.tabPageAutorzy.Controls.Add(this.textBoxTelefon);
            this.tabPageAutorzy.Controls.Add(this.textBoxMail);
            this.tabPageAutorzy.Controls.Add(this.textBoxAdres);
            this.tabPageAutorzy.Controls.Add(this.textBoxNazwisko);
            this.tabPageAutorzy.Controls.Add(this.textBoxImie);
            this.tabPageAutorzy.Controls.Add(this.labelTelefon);
            this.tabPageAutorzy.Controls.Add(this.labelMail);
            this.tabPageAutorzy.Controls.Add(this.labelAdres);
            this.tabPageAutorzy.Controls.Add(this.labelNazwisko);
            this.tabPageAutorzy.Controls.Add(this.labelImie);
            this.tabPageAutorzy.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutorzy.Name = "tabPageAutorzy";
            this.tabPageAutorzy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutorzy.Size = new System.Drawing.Size(1092, 531);
            this.tabPageAutorzy.TabIndex = 2;
            this.tabPageAutorzy.Text = "Autorzy";
            this.tabPageAutorzy.UseVisualStyleBackColor = true;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(223, 208);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(100, 20);
            this.textBoxTelefon.TabIndex = 19;
            // 
            // textBoxMail
            // 
            this.textBoxMail.Location = new System.Drawing.Point(223, 181);
            this.textBoxMail.Name = "textBoxMail";
            this.textBoxMail.Size = new System.Drawing.Size(100, 20);
            this.textBoxMail.TabIndex = 18;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(223, 154);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(100, 20);
            this.textBoxAdres.TabIndex = 17;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(223, 127);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(100, 20);
            this.textBoxNazwisko.TabIndex = 16;
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(223, 100);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(100, 20);
            this.textBoxImie.TabIndex = 15;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Location = new System.Drawing.Point(171, 211);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(46, 13);
            this.labelTelefon.TabIndex = 14;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelMail
            // 
            this.labelMail.AutoSize = true;
            this.labelMail.Location = new System.Drawing.Point(188, 184);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(29, 13);
            this.labelMail.TabIndex = 13;
            this.labelMail.Text = "Mail:";
            // 
            // labelAdres
            // 
            this.labelAdres.AutoSize = true;
            this.labelAdres.Location = new System.Drawing.Point(180, 157);
            this.labelAdres.Name = "labelAdres";
            this.labelAdres.Size = new System.Drawing.Size(37, 13);
            this.labelAdres.TabIndex = 12;
            this.labelAdres.Text = "Adres:";
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(161, 130);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(56, 13);
            this.labelNazwisko.TabIndex = 11;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(188, 103);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(29, 13);
            this.labelImie.TabIndex = 10;
            this.labelImie.Text = "Imię:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonZatwierdzPorady);
            this.panel2.Controls.Add(this.buttonAnulujPorady);
            this.panel2.Controls.Add(this.labelPoradaKategoria);
            this.panel2.Controls.Add(this.labelOpisPorady);
            this.panel2.Controls.Add(this.comboBoxPoradyKategoria);
            this.panel2.Controls.Add(this.textBoxOpisPorady);
            this.panel2.Location = new System.Drawing.Point(676, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 267);
            this.panel2.TabIndex = 25;
            // 
            // buttonZatwierdzPorady
            // 
            this.buttonZatwierdzPorady.Location = new System.Drawing.Point(314, 231);
            this.buttonZatwierdzPorady.Name = "buttonZatwierdzPorady";
            this.buttonZatwierdzPorady.Size = new System.Drawing.Size(75, 23);
            this.buttonZatwierdzPorady.TabIndex = 21;
            this.buttonZatwierdzPorady.Text = "Zatwierdź";
            this.buttonZatwierdzPorady.UseVisualStyleBackColor = true;
            // 
            // buttonAnulujPorady
            // 
            this.buttonAnulujPorady.Location = new System.Drawing.Point(233, 231);
            this.buttonAnulujPorady.Name = "buttonAnulujPorady";
            this.buttonAnulujPorady.Size = new System.Drawing.Size(75, 23);
            this.buttonAnulujPorady.TabIndex = 20;
            this.buttonAnulujPorady.Text = "Anuluj";
            this.buttonAnulujPorady.UseVisualStyleBackColor = true;
            // 
            // labelPoradaKategoria
            // 
            this.labelPoradaKategoria.AutoSize = true;
            this.labelPoradaKategoria.Location = new System.Drawing.Point(12, 24);
            this.labelPoradaKategoria.Name = "labelPoradaKategoria";
            this.labelPoradaKategoria.Size = new System.Drawing.Size(55, 13);
            this.labelPoradaKategoria.TabIndex = 9;
            this.labelPoradaKategoria.Text = "Kategoria:";
            // 
            // labelOpisPorady
            // 
            this.labelOpisPorady.AutoSize = true;
            this.labelOpisPorady.Location = new System.Drawing.Point(12, 85);
            this.labelOpisPorady.Name = "labelOpisPorady";
            this.labelOpisPorady.Size = new System.Drawing.Size(66, 13);
            this.labelOpisPorady.TabIndex = 18;
            this.labelOpisPorady.Text = "Opis porady:";
            // 
            // comboBoxPoradyKategoria
            // 
            this.comboBoxPoradyKategoria.FormattingEnabled = true;
            this.comboBoxPoradyKategoria.Items.AddRange(new object[] {
            "GŁOWA",
            "DŁONIE I STOPY",
            "CIAŁO"});
            this.comboBoxPoradyKategoria.Location = new System.Drawing.Point(12, 40);
            this.comboBoxPoradyKategoria.Name = "comboBoxPoradyKategoria";
            this.comboBoxPoradyKategoria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPoradyKategoria.TabIndex = 7;
            // 
            // textBoxOpisPorady
            // 
            this.textBoxOpisPorady.Location = new System.Drawing.Point(12, 101);
            this.textBoxOpisPorady.Multiline = true;
            this.textBoxOpisPorady.Name = "textBoxOpisPorady";
            this.textBoxOpisPorady.Size = new System.Drawing.Size(377, 124);
            this.textBoxOpisPorady.TabIndex = 17;
            // 
            // buttonUsunPorady
            // 
            this.buttonUsunPorady.Location = new System.Drawing.Point(677, 35);
            this.buttonUsunPorady.Name = "buttonUsunPorady";
            this.buttonUsunPorady.Size = new System.Drawing.Size(75, 23);
            this.buttonUsunPorady.TabIndex = 24;
            this.buttonUsunPorady.Text = "Usuń";
            this.buttonUsunPorady.UseVisualStyleBackColor = true;
            // 
            // buttonPoradyCialo
            // 
            this.buttonPoradyCialo.Location = new System.Drawing.Point(223, 6);
            this.buttonPoradyCialo.Name = "buttonPoradyCialo";
            this.buttonPoradyCialo.Size = new System.Drawing.Size(91, 23);
            this.buttonPoradyCialo.TabIndex = 23;
            this.buttonPoradyCialo.Text = "Ciało";
            this.buttonPoradyCialo.UseVisualStyleBackColor = true;
            // 
            // buttonPoradyDlonie
            // 
            this.buttonPoradyDlonie.Location = new System.Drawing.Point(115, 6);
            this.buttonPoradyDlonie.Name = "buttonPoradyDlonie";
            this.buttonPoradyDlonie.Size = new System.Drawing.Size(102, 23);
            this.buttonPoradyDlonie.TabIndex = 22;
            this.buttonPoradyDlonie.Text = "Dłonie i stopy";
            this.buttonPoradyDlonie.UseVisualStyleBackColor = true;
            // 
            // buttonPoradyGlowa
            // 
            this.buttonPoradyGlowa.Location = new System.Drawing.Point(6, 6);
            this.buttonPoradyGlowa.Name = "buttonPoradyGlowa";
            this.buttonPoradyGlowa.Size = new System.Drawing.Size(102, 23);
            this.buttonPoradyGlowa.TabIndex = 21;
            this.buttonPoradyGlowa.Text = "Głowa";
            this.buttonPoradyGlowa.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Kategoria,
            this.OpisPorady});
            this.dataGridView2.Location = new System.Drawing.Point(6, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(665, 492);
            this.dataGridView2.TabIndex = 26;
            // 
            // buttonDodajPorady
            // 
            this.buttonDodajPorady.Location = new System.Drawing.Point(839, 35);
            this.buttonDodajPorady.Name = "buttonDodajPorady";
            this.buttonDodajPorady.Size = new System.Drawing.Size(75, 23);
            this.buttonDodajPorady.TabIndex = 28;
            this.buttonDodajPorady.Text = "Dodaj";
            this.buttonDodajPorady.UseVisualStyleBackColor = true;
            // 
            // buttonEdytujPorady
            // 
            this.buttonEdytujPorady.Location = new System.Drawing.Point(758, 35);
            this.buttonEdytujPorady.Name = "buttonEdytujPorady";
            this.buttonEdytujPorady.Size = new System.Drawing.Size(75, 23);
            this.buttonEdytujPorady.TabIndex = 27;
            this.buttonEdytujPorady.Text = "Edytuj";
            this.buttonEdytujPorady.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 20;
            // 
            // Kategoria
            // 
            this.Kategoria.HeaderText = "Kategoria";
            this.Kategoria.Name = "Kategoria";
            // 
            // OpisPorady
            // 
            this.OpisPorady.FillWeight = 200F;
            this.OpisPorady.HeaderText = "Opis porady";
            this.OpisPorady.Name = "OpisPorady";
            this.OpisPorady.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 581);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPagePlaner.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPagePorady.ResumeLayout(false);
            this.tabPageAutorzy.ResumeLayout(false);
            this.tabPageAutorzy.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPagePlaner;
        private System.Windows.Forms.TabPage tabPagePorady;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGlowa;
        private System.Windows.Forms.Button buttonDlonieStopy;
        private System.Windows.Forms.Button buttonCialo;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Button buttonEdytuj;
        private System.Windows.Forms.Button buttonUsun;
        private System.Windows.Forms.ComboBox comboBoxKategoria;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox comboBoxCzescCiala;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Zabiegu;
        private System.Windows.Forms.DataGridViewTextBoxColumn glownaCzescCiala1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wybranaCzescCiala1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlanowanegoZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztZabiegu1;
        private System.Windows.Forms.Label labelKategoria;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Label labelRodzajZabiegu;
        private System.Windows.Forms.Label labelCzescCiala;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOpis;
        private System.Windows.Forms.TextBox textBoxOpis;
        private System.Windows.Forms.TextBox textBoxKoszt;
        private System.Windows.Forms.Label labelKosztZabiegu;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.TextBox textBoxRodzajZabiegu;
        private System.Windows.Forms.TabPage tabPageAutorzy;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxMail;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelMail;
        private System.Windows.Forms.Label labelAdres;
        private System.Windows.Forms.Label labelNazwisko;
        private System.Windows.Forms.Label labelImie;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonZatwierdzPorady;
        private System.Windows.Forms.Button buttonAnulujPorady;
        private System.Windows.Forms.Label labelPoradaKategoria;
        private System.Windows.Forms.Label labelOpisPorady;
        private System.Windows.Forms.ComboBox comboBoxPoradyKategoria;
        private System.Windows.Forms.TextBox textBoxOpisPorady;
        private System.Windows.Forms.Button buttonUsunPorady;
        private System.Windows.Forms.Button buttonPoradyCialo;
        private System.Windows.Forms.Button buttonPoradyDlonie;
        private System.Windows.Forms.Button buttonPoradyGlowa;
        private System.Windows.Forms.Button buttonDodajPorady;
        private System.Windows.Forms.Button buttonEdytujPorady;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisPorady;
    }
}

