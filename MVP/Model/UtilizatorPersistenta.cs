using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using MVP.Model;
using MVP.View;



namespace MVP.Model
{
    class UtilizatorPersistenta
    {
        public string cale = "../../utilizatorDate.xml";
        
        public List<Utilizator> loadUtilizator()
        {
            XmlDocument doc = new XmlDocument();
            List<Utilizator> lista = new List<Utilizator>();
            doc.Load(cale);
            XmlNodeList utilizatori = doc.SelectNodes("/utilizatori/utilizator");

            foreach(XmlNode utilizator in utilizatori)
            {
                string rol = utilizator.SelectSingleNode("rol").InnerText;
                string cont = utilizator.SelectSingleNode("cont").InnerText;
                string parola = utilizator.SelectSingleNode("parola").InnerText;
                
                 Utilizator U = new Utilizator(rol, cont, parola);
                 lista.Add(U);
                 
            }

            return lista;
        }
        public void salvare(List<Utilizator> utilizatori)
        {
            XmlDocument doc = new XmlDocument();
            XmlNode nod = doc.CreateElement("utilizatori");
            doc.AppendChild(nod);
            foreach(Utilizator U in utilizatori)
            {
                XmlNode Udate = doc.CreateElement("utilizator");
                nod.AppendChild(Udate);
                XmlNode Ucont= doc.CreateElement("cont");
                Ucont.InnerText = U.getCont();
                XmlNode Uparola = doc.CreateElement("parola");
                Uparola.InnerText = U.getParola();
                XmlNode Urol = doc.CreateElement("rol");
                Urol.InnerText = U.getRol();

                Udate.AppendChild(Ucont);
                Udate.AppendChild(Uparola);
                Udate.AppendChild(Urol);
            }
            doc.Save(cale);
        }
        public void salvareUtilizator(Utilizator utilizator)
        {
            List<Utilizator> lista = new List<Utilizator>();
            lista = this.loadUtilizator();
            bool ok = false;

            foreach(Utilizator U in lista)
            {
                if (U.getCont() == utilizator.getCont())
                    ok = true;
            }
            if (!ok)
            {
                lista.Add(utilizator);
                this.salvare(lista);
            }

        }

        public void stergeUtilizator(Utilizator utilizator)
        {
            List<Utilizator> lista = new List<Utilizator>();
            lista = this.loadUtilizator();
            foreach(Utilizator U in lista)
            {
                if (U.getCont() == utilizator.getCont()&&U.getParola()==utilizator.getParola())
                {
                    lista.Remove(U);
                    break;
                }
            }
            this.salvare(lista);
        }
        public Utilizator cautaUtilizator(string cont)
        {
            List<Utilizator> lista = new List<Utilizator>();
            lista = this.loadUtilizator();
            foreach (Utilizator U in lista)
            {
                if (cont == U.getCont())
                    return U;
            }
            return new Utilizator("Nu ", "Nu", "exista");
        }
        public void editareUtilizator(Utilizator oldUtilizator, Utilizator newUtilizator)
        {
            List<Utilizator> lista = new List<Utilizator>();
            lista = this.loadUtilizator();
            foreach (Utilizator U in lista)
            {
                if (U.getCont() == oldUtilizator.getCont())
                {
                    lista.Remove(U);
                    lista.Add(newUtilizator);
                    break;
                }
            }
            this.salvare(lista);
        }


    }
}
