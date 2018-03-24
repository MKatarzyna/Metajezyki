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
            this.tabPageZadbjO = new System.Windows.Forms.TabPage();
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
            this.tabPageAutorzy = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageZadbjO.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageZadbjO);
            this.tabControl1.Controls.Add(this.tabPageAutorzy);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageZadbjO
            // 
            this.tabPageZadbjO.Controls.Add(this.panel1);
            this.tabPageZadbjO.Controls.Add(this.buttonDodaj);
            this.tabPageZadbjO.Controls.Add(this.buttonEdytuj);
            this.tabPageZadbjO.Controls.Add(this.buttonUsun);
            this.tabPageZadbjO.Controls.Add(this.buttonCialo);
            this.tabPageZadbjO.Controls.Add(this.buttonDlonieStopy);
            this.tabPageZadbjO.Controls.Add(this.dataGridView1);
            this.tabPageZadbjO.Controls.Add(this.buttonGlowa);
            this.tabPageZadbjO.Location = new System.Drawing.Point(4, 22);
            this.tabPageZadbjO.Name = "tabPageZadbjO";
            this.tabPageZadbjO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZadbjO.Size = new System.Drawing.Size(1092, 531);
            this.tabPageZadbjO.TabIndex = 0;
            this.tabPageZadbjO.Text = "Zadbaj o...";
            this.tabPageZadbjO.UseVisualStyleBackColor = true;
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
            this.textBoxOpis.Name = "textBoxOpis";
            this.textBoxOpis.Size = new System.Drawing.Size(378, 20);
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
            this.buttonCialo.Size = new System.Drawing.Size(75, 23);
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
            this.buttonGlowa.Location = new System.Drawing.Point(3, 6);
            this.buttonGlowa.Name = "buttonGlowa";
            this.buttonGlowa.Size = new System.Drawing.Size(105, 23);
            this.buttonGlowa.TabIndex = 1;
            this.buttonGlowa.Text = "Głowa";
            this.buttonGlowa.UseVisualStyleBackColor = true;
            this.buttonGlowa.Click += new System.EventHandler(this.buttonGlowa_Click);
            // 
            // tabPageAutorzy
            // 
            this.tabPageAutorzy.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutorzy.Name = "tabPageAutorzy";
            this.tabPageAutorzy.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutorzy.Size = new System.Drawing.Size(1092, 531);
            this.tabPageAutorzy.TabIndex = 1;
            this.tabPageAutorzy.Text = "Autorzy";
            this.tabPageAutorzy.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
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
            this.tabPageZadbjO.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageZadbjO;
        private System.Windows.Forms.TabPage tabPageAutorzy;
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
    }
}

