using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVP.Model;
using MVP.View;
using System.IO;
using Newtonsoft.Json;

namespace MVP.Presenter
{
    class PSecretar
    {

        ISecretar presenterSecretar;
        ClientPersistenta clientul = new ClientPersistenta();
        public PSecretar(ISecretar view)
        {
            this.presenterSecretar = view;
        }
        public void ShowInfo()
        {
            List<Client> lista = clientul.loadClient();
            foreach (Client C in lista)
            {
                this.presenterSecretar.tabel.Rows.Add(C.getNume(), C.getVarsta(), C.getGreutate(), C.getDieta());
            }
        }
        public void refreshInfo()
        {
            this.presenterSecretar.tabel.Rows.Clear();
            this.presenterSecretar.tabel.Refresh();
            this.ShowInfo();
        }
        public void adaugareClient()
        {
            if (this.presenterSecretar.nume.Text == "" || this.presenterSecretar.varsta.Text == "" ||
                this.presenterSecretar.greutate.Text == "" || this.presenterSecretar.dieta.Text == "")
            {
                MessageBox.Show("Scrie toate detaliile despre client !");
            }
            else
            {
                Client c = new Client(this.presenterSecretar.nume.Text, Int32.Parse(this.presenterSecretar.varsta.Text),
                    Int32.Parse(this.presenterSecretar.greutate.Text), this.presenterSecretar.dieta.Text);
                clientul.salvareClient(c);
                this.refreshInfo();
            }
        }
        public void cautareClient()
        {
            Client c = clientul.cautareClient(this.presenterSecretar.search.Text);
            if (c.getNume() == "Nu")
            {
                string clientDate = String.Format("Clientul {0} nu exista!", this.presenterSecretar.search.Text);
                MessageBox.Show(clientDate, "Client :");
            }
            else
            {
                MessageBox.Show(c.ShowInfo2(), "Client");
            }
        }
        public void stergeClient()
        {

            if (this.presenterSecretar.nume.Text == "")
            {
                MessageBox.Show("Introduceti numele clientului pe care doriti sa il stergeti!");
            }
            else
            {
                Client c = clientul.cautareClient(this.presenterSecretar.nume.Text);
                if (c.getNume() == "Nu")
                {
                    MessageBox.Show("Acest client nu exista!");
                }
                else
                {
                    clientul.stergeClient(c);
                    this.refreshInfo();
                }
            }
        }
        public void filtrareClient()
        {
            List<Client> lista = clientul.filtrareClient2(this.presenterSecretar.selectie1.Text, this.presenterSecretar.filtru.Text);

            this.presenterSecretar.tabel.Rows.Clear();
            this.presenterSecretar.tabel.Refresh();
            foreach (Client cl in lista)
            {
                this.presenterSecretar.tabel.Rows.Add(cl.getNume(), cl.getVarsta(), cl.getGreutate(), cl.getDieta());
            }
        }
        public void editareClient()
        {
            List<Client> result = clientul.loadClient();
            Client c = clientul.cautareClient(this.presenterSecretar.nume.Text);
            if (c.getNume() == "Nu")
            {
                MessageBox.Show("Acest client nu exista!");
            }
            else
            {
                if (this.presenterSecretar.varsta.Text == "" || this.presenterSecretar.greutate.Text == "" || this.presenterSecretar.dieta.Text == "")
                {
                    MessageBox.Show("Trebuie specificata varsta greutatea si dieta!");
                }
                else
                {
                    Client newClient = new Client(this.presenterSecretar.nume.Text, Int32.Parse(this.presenterSecretar.varsta.Text),
                    Int32.Parse(this.presenterSecretar.greutate.Text), this.presenterSecretar.dieta.Text);
                    clientul.editareClient(c, newClient);
                }
            }
            this.presenterSecretar.tabel.Rows.Clear();
            this.presenterSecretar.tabel.Refresh();
            List<Client> lista = clientul.loadClient();
            foreach (Client cl in lista)
            {
                this.presenterSecretar.tabel.Rows.Add(cl.getNume(), cl.getVarsta(), cl.getGreutate(), cl.getDieta());
            }
        }
        public void generareRapoarte()
        {
            List<Client> lista= clientul.loadClient();

            if (this.presenterSecretar.selectie2.Text == "CSV")
            {
                var cale = "../../CSV_Report.csv";
                using (StreamWriter writer = new StreamWriter(new FileStream(cale,FileMode.Create, FileAccess.Write)))
                {
                    string fields = String.Format("Nume,Varsta,Greutate,Dieta");
                    writer.WriteLine(fields);
                    foreach (Client client1 in lista)
                    {
                        string date = String.Format("{0},{1},{2},{3}", client1.getNume(), client1.getVarsta(), client1.getGreutate(),client1.getDieta());
                        writer.WriteLine(date);
                    }
                }

                MessageBox.Show("Raportul a fost generat cu success!");
            }
            if (this.presenterSecretar.selectie2.Text == "JSON")
            {
                var filepath = "../../JSON_Report.json";
                using (StreamWriter writer = new StreamWriter(new FileStream(filepath,FileMode.Create, FileAccess.Write)))
                {
                    foreach (Client client2 in lista)
                    {
                        string json = Newtonsoft.Json.JsonConvert.SerializeObject(client2);
                        writer.WriteLine(json);
                    }
                }
                MessageBox.Show("Raportul a fost generat cu success!");
            }
        }
    }   
}
