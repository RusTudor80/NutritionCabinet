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

namespace MVP.View
{
    public partial class GUIAdministrator : Form,IAdministrator
    {
        public GUIAdministrator()
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

      
        public TextBox cont
        {
            get
            {
                return this.contText;
            }
        }
        public TextBox parola
        {
            get
            {
                return this.parolaText;
            }
        }
        public TextBox rol
        {
            get
            {
                return this.rolText;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PAdministrator form = new PAdministrator(this);
            form.ShowInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PAdministrator form = new PAdministrator(this);
            form.adaugareUtilizator();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PAdministrator form = new PAdministrator(this);
            form.stergeUtilizator();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PAdministrator form = new PAdministrator(this);
            form.editareUtilizator();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GUIAutentificare autentificare = new GUIAutentificare();
            autentificare.ShowDialog();
            
        }

       
    }
}
