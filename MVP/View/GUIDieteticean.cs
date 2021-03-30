using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MVP.Model;
using MVP.Presenter;
using MVP.View;

namespace MVP.View
{
    public partial class GUIDieteticean : Form,IDieteticean
    {
        public GUIDieteticean()
        {
            InitializeComponent();
        }

        public DataGridView tabel
        {
            get
            {
                return this.dataGridView2;
            }
            set
            {
                this.dataGridView2 = value;
            }
        }
        public ComboBox selectie
        {
            get
            {
                return this.filtru1;
            }
        }
        public ComboBox grafic
        {
            get
            {
                return this.comboGrafic;
            }
        }
        public TextBox search
        {
            get
            {
                return this.searchText;
            }
        }
        public TextBox filtru
        {
            get
            {
                return this.filtruText;
            }
        }
        public Chart statistica
        {
            get
            {
                return this.grafic1;
            }
            set
            {
                this.grafic1 = value;
            }
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            PDieteticean form = new PDieteticean(this);
            form.cautareClient();
        }

        private void Filtrare_Click(object sender, EventArgs e)
        {
            PDieteticean form = new PDieteticean(this);
            form.filtrareClient();
        }

        private void Statistici_Click(object sender, EventArgs e)
        {
            PDieteticean form = new PDieteticean(this);
            form.showStatistics();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            GUIAutentificare autentificare = new GUIAutentificare();
            autentificare.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PDieteticean form1 = new PDieteticean(this);
            form1.ShowInfo();
        }

    }
}
