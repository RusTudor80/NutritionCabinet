using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MVP.Model
{
    class ClientPersistenta
    {
        public string cale = "../../clientDate.xml";

        public List<Client> loadClient()
        {
            XmlDocument doc = new XmlDocument();
            List<Client> lista = new List<Client>();
            doc.Load(cale);
            XmlNodeList Clienti = doc.SelectNodes("/Clienti/Client");

            foreach (XmlNode Client in Clienti)
            {
                try
                {
                    string nume = Client.SelectSingleNode("Nume").InnerText;
                    string varsta = Client.SelectSingleNode("varsta").InnerText;
                    string greutate = Client.SelectSingleNode("greutate").InnerText;
                    string dieta = Client.SelectSingleNode("dieta").InnerText;
                    

                    int varsta1 = Int32.Parse(varsta);
                    float greutate1 = float.Parse(greutate);

                    Client U = new Client(nume, varsta1, greutate1, dieta);
                    lista.Add(U);
                }
                catch
                {
                    Console.WriteLine("Nu se poate citi din fisierul XML!");
                }

            }

            return lista;
        }
        public void salvare(List<Client> Clienti)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode nod = doc.CreateElement("Clienti");
            doc.AppendChild(nod);
            foreach (Client C in Clienti)
            {
                XmlNode Cdate = doc.CreateElement("Client");
                nod.AppendChild(Cdate);

                XmlNode Cnume = doc.CreateElement("Nume");
                Cnume.InnerText = C.getNume();
               
                XmlNode Cvarsta = doc.CreateElement("varsta");
                int AuxVarsta = C.getVarsta();
                Cvarsta.InnerText = AuxVarsta.ToString();

                XmlNode Cgreutate = doc.CreateElement("greutate");
                float greutate = C.getGreutate();
                Cgreutate.InnerText = greutate.ToString();

                XmlNode Cdieta = doc.CreateElement("dieta");
                Cdieta.InnerText = C.getDieta();

                



                Cdate.AppendChild(Cnume);
                Cdate.AppendChild(Cvarsta);
                Cdate.AppendChild(Cgreutate);
                Cdate.AppendChild(Cdieta);
               
            }
            doc.Save(cale);
        }
        public void salvareClient(Client Client)
        {
            List<Client> lista = new List<Client>();
            lista = this.loadClient();
            bool ok = false;

            foreach (Client C in lista)
            {
                if (C.getNume() == Client.getNume())
                    ok = true;
            }
            if (!ok)
            {
                lista.Add(Client);
                this.salvare(lista);
            }

        }

        public void stergeClient(Client Client)
        {
            List<Client> lista = new List<Client>();
            lista = this.loadClient();
            foreach (Client C in lista)
            {
                if (C.getNume() == Client.getNume())
                {
                    lista.Remove(C);
                    break;
                }
            }
            this.salvare(lista);
        }
        public void editareClient(Client oldClient, Client newClient)
        {
            List<Client> lista = new List<Client>();
            lista = this.loadClient();
            foreach (Client C in lista)
            {
                if (C.getNume() == oldClient.getNume())
                {
                    lista.Remove(C);
                    lista.Add(newClient);
                    break;
                }
            }
            this.salvare(lista);
        }
        public Client cautareClient(string Client)
        {
            List<Client> lista = new List<Client>();
            lista = this.loadClient();
            foreach (Client C in lista)
            {
                if (Client == C.getNume())
                    return C;
            }
            return new Client("Nu",0 , 0 ,"exista!");
        }
        public List<Client> filtrareClient1(string tip, string variabila)
        {
            List<Client> lista = new List<Client>();
            List<Client> filtru = new List<Client>();
            lista = this.loadClient();
            foreach (Client client in lista)
            {
                switch (tip)
                {
                    

                    case "varsta":
                        if (client.getVarsta().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    case "greutate":
                        if (client.getGreutate().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    case "dieta":
                        if (client.getDieta().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    default:
                        break;
                }

            }
            return filtru;
        }
        public List<Client> filtrareClient2(string tip, string variabila)
        {
            List<Client> lista = new List<Client>();
            List<Client> filtru = new List<Client>();
            lista = this.loadClient();
            foreach (Client client in lista)
            {
                switch (tip)
                {


                    case "varsta":
                        if (client.getVarsta().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    case "greutate":
                        if (client.getGreutate().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    case "dieta":
                        if (client.getDieta().ToString() == variabila)
                            filtru.Add(client);
                        break;

                    default:
                        break;
                }

            }
            return filtru;
        }
    }

}
