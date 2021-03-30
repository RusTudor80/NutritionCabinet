using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Model
{
    public class Client
    {
        
        private string nume { get; set; }
        private int varsta { get; set; }
        private float greutate { get; set; }
        private string dieta { get; set; }

        public Client()
        {
           
        }

        public Client(string nume, int varsta, float greutate, string dieta)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.greutate = greutate;
            this.dieta = dieta;

        }
        public Client(Client C)
        {
            this.nume = C.nume;
            this.varsta = C.varsta;
            this.greutate = C.greutate;
            this.dieta = C.dieta;
          
        }
        public string getNume()
        {
            return this.nume;
        }
        public int getVarsta()
        {
            return this.varsta;
        }

        public float getGreutate()
        { 
            return this.greutate;
            
        }
        public string getDieta()
        {
            return this.dieta;
        }
        

        public void setNume(string nume)
        {
            this.nume = nume;
        }
        public void setVarsta(int varsta)
        {
            this.varsta=varsta;
        }

        public void setGreutate(float greutate)
        {
            this.greutate=greutate;

        }
        public void setDieta(string dieta)
        {
           this.dieta=dieta;
        }
        
        public string ShowInfo1()
        {
            return string.Format("Nume: {0} Varsta: {1} Greutate: {2} Dieta:{3}", this.nume, this.varsta, this.greutate,this.dieta);
        }
        public string ShowInfo2()
        {
            return string.Format("Nume: {0} Varsta: {1} Greutate: {2} Dieta: {3} ", this.nume, this.varsta, this.greutate, this.dieta);
        }



    }
}
