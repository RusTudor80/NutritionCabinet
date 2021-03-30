using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Presenter;
using MVP.Model;

namespace MVP.View
{
    public partial class GUISecretar : Form,ISecretar
    {
        public GUISecretar()
        {
            InitializeComponent();
        }
        public DataGridView tabel
        {
            get
            {
                return this.dataGridView1;
            }
            set
            {
                this.dataGridView1 = value;
            }
        }

        public ComboBox selectie1
        {
            get
            {
                return this.comboBox2;
            }
        }

        public TextBox nume
        {
            get
            {
                return this.textBox3;
            }
        }

        public TextBox varsta
        {
            get
            {
                return this.textBox4;
            }
        }

        public TextBox greutate
        {
            get
            {
                return this.textBox5;
            }
        }
        public TextBox dieta
        {
            get
            {
                return this.textBox8;
            }
        }

        public TextBox search
        {
            get
            {
                return this.textBox2;
            }
        }
        public TextBox filtru
        {
            get
            {
                return this.textBox7;
            }
        }
        public ComboBox selectie2
        {
            get
            {
                return this.comboBox1;
            }
        }





        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIAutentificare autentificare = new GUIAutentificare();
            autentificare.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.cautareClient();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.adaugareClient();
        }

        private void GUISecretar_Load(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.editareClient();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.stergeClient();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.filtrareClient();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PSecretar form = new PSecretar(this);
            form.generareRapoarte();
        }
    }
}
