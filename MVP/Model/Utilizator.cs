using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP.Model
{
    class Utilizator
    {
        private string rol { get; set; }
        private string cont { get; set; }
        private string parola { get; set; }

        public void setCont(string cont)
        {
            this.cont = cont;
        }
        public void setParola(string parola)
        {
            this.parola = parola;
        }
        
        public void setRol(string rol)
        {
            this.rol = rol;
        }
        public string getRol()
        {
            return this.rol;
        }
        public string getCont()
        {
            return this.cont;
        }
        public string getParola()
        {
            return this.parola;
        }

        public Utilizator()
        {
        
            this.rol = "";
            this.cont = "";
            this.parola = "";

        }

        public Utilizator( string rol, string cont, string parola)
        {
     
            this.rol = rol;
            this.cont = cont;
            this.parola = parola;

        }
        public Utilizator(Utilizator U)
        {
      
            this.rol = U.rol;
            this.cont = U.cont;
            this.parola = U.parola;
        }
        public string showInfo()
        {
            return String.Format("Cont: {0} Parola: {1} Rol: {2}", this.cont, this.parola, this.rol);
        }

    }
}
