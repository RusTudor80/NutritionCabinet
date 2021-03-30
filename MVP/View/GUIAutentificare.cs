using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Model;

namespace MVP.View

{
    public partial class GUIAutentificare : Form
    {
        public GUIAutentificare()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UtilizatorPersistenta U = new UtilizatorPersistenta();
            Utilizator u = U.cautaUtilizator(this.contText.Text);
            if (u.getCont() == "Nu" || u.getParola() != this.parolaText.Text)
                MessageBox.Show("Nume sau parola incorecte.");
            else
            {
                if (u.getRol() == "dieteticean")
                {
                    this.Hide();
                    GUIDieteticean DieteticeanMenu = new GUIDieteticean();
                    DieteticeanMenu.ShowDialog();
                }
                if (u.getRol() == "admin")
                {
                    this.Hide();
                    GUIAdministrator AdministratorMenu = new GUIAdministrator();
                    AdministratorMenu.ShowDialog();
                }
                if (u.getRol() == "secretar")
                {
                    this.Hide();
                    GUISecretar SecretarMenu = new GUISecretar();
                    SecretarMenu.ShowDialog();

                }

            }


        }

    }
}
