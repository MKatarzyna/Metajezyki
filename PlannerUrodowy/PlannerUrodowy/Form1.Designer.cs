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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageZadbjO = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCialo = new System.Windows.Forms.Button();
            this.buttonDlonieStopy = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.glownaCzescCiala1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wybranaCzescCiala1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rodzajZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataPlanowanegoZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kosztZabiegu1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonGlowa = new System.Windows.Forms.Button();
            this.tabPageAutorzy = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPageZadbjO.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(1229, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageZadbjO
            // 
            this.tabPageZadbjO.Controls.Add(this.button2);
            this.tabPageZadbjO.Controls.Add(this.buttonCialo);
            this.tabPageZadbjO.Controls.Add(this.buttonDlonieStopy);
            this.tabPageZadbjO.Controls.Add(this.dataGridView1);
            this.tabPageZadbjO.Controls.Add(this.buttonGlowa);
            this.tabPageZadbjO.Location = new System.Drawing.Point(4, 22);
            this.tabPageZadbjO.Name = "tabPageZadbjO";
            this.tabPageZadbjO.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageZadbjO.Size = new System.Drawing.Size(1221, 531);
            this.tabPageZadbjO.TabIndex = 0;
            this.tabPageZadbjO.Text = "Zadbaj o...";
            this.tabPageZadbjO.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
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
            this.glownaCzescCiala1,
            this.wybranaCzescCiala1,
            this.rodzajZabiegu1,
            this.dataPlanowanegoZabiegu1,
            this.opisZabiegu1,
            this.kosztZabiegu1});
            this.dataGridView1.Location = new System.Drawing.Point(6, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(838, 366);
            this.dataGridView1.TabIndex = 0;
            // 
            // glownaCzescCiala1
            // 
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
            this.tabPageAutorzy.Size = new System.Drawing.Size(1221, 531);
            this.tabPageAutorzy.TabIndex = 1;
            this.tabPageAutorzy.Text = "Autorzy";
            this.tabPageAutorzy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageZadbjO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageZadbjO;
        private System.Windows.Forms.TabPage tabPageAutorzy;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonGlowa;
        private System.Windows.Forms.DataGridViewTextBoxColumn glownaCzescCiala1;
        private System.Windows.Forms.DataGridViewTextBoxColumn wybranaCzescCiala1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rodzajZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataPlanowanegoZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisZabiegu1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kosztZabiegu1;
        private System.Windows.Forms.Button buttonDlonieStopy;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCialo;
    }
}

