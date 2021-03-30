using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVP.Model;
using MVP.View;
using System.Windows.Forms;

namespace MVP.Presenter
{
    class PAdministrator
    {
        IAdministrator presenterAdministrator;
        UtilizatorPersistenta utilizator = new UtilizatorPersistenta();
        public PAdministrator(IAdministrator view)
        {
            this.presenterAdministrator = view;
        }

        public void ShowInfo()
        {
            List<Utilizator> lista = utilizator.loadUtilizator();
            foreach (Utilizator u in lista)
                this.presenterAdministrator.tabel.Rows.Add(u.getCont(), u.getParola(), u.getRol());
        }
        public void refreshInfo()
        {
            this.presenterAdministrator.tabel.Rows.Clear();
            this.presenterAdministrator.tabel.Refresh();
            this.ShowInfo();
        }
        public void adaugareUtilizator()
        {
            if (this.presenterAdministrator.cont.Text == "" || this.presenterAdministrator.parola.Text == "" || this.presenterAdministrator.rol.Text == "")
            {
                MessageBox.Show("Introduceti contul, parola si rolul!");
            }
            else
            {
                Utilizator u = new Utilizator(this.presenterAdministrator.rol.Text, this.presenterAdministrator.cont.Text, this.presenterAdministrator.parola.Text);
                utilizator.salvareUtilizator(u);
                this.refreshInfo();
            }
        }

        public void stergeUtilizator()
        {

            if (this.presenterAdministrator.cont.Text == "")
            {
                MessageBox.Show("Scrieti doar numele utilizatorului pe care doriti sa il stergeti!");
            }
            else
            {
                Utilizator U = utilizator.cautaUtilizator(this.presenterAdministrator.cont.Text);
                if (U.getCont() == "Nu")
                {
                    MessageBox.Show("Acest utilizator nu exista!");
                }
                else
                {
                    utilizator.stergeUtilizator(U);
                    this.refreshInfo();
                }
            }
        }

      

        public void editareUtilizator()
        {
            List<Utilizator> lista = utilizator.loadUtilizator();
            Utilizator U = utilizator.cautaUtilizator(this.presenterAdministrator.cont.Text);
            if (U.getCont() == "Nu")
            {
                MessageBox.Show("Acest utilizator nu exista!");
            }
            else
            {
                if (this.presenterAdministrator.parola.Text == "" || this.presenterAdministrator.rol.Text == "")
                {
                    MessageBox.Show("Introduceti parola si rolul utilizatorului !");
                }
                else
                {
                    Utilizator newUtilizator = new Utilizator(this.presenterAdministrator.rol.Text, this.presenterAdministrator.cont.Text, this.presenterAdministrator.parola.Text);
                    utilizator.editareUtilizator(U, newUtilizator);
                }
            }

            this.presenterAdministrator.tabel.Rows.Clear();
            this.presenterAdministrator.tabel.Refresh();
            List<Utilizator> final = utilizator.loadUtilizator();
            foreach (Utilizator u in final)
                this.presenterAdministrator.tabel.Rows.Add(u.getCont(), u.getParola(), u.getRol());
        }
    }

}

