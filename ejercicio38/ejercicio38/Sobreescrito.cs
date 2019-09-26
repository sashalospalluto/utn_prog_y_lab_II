using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio38
{
    abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            miAtributo = "Probar abstractos";
        }

        public abstract string MiPropiedad
        {
            get;
        }

        public string MiMetodo()
        {
            return MiPropiedad;
        }

        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
        }

        public override int GetHashCode()
        {           
            return 1142510187;
        }
        public override bool Equals(object obj)
        {
            bool ret=true;
            if(this.GetType().Equals(obj.GetType())) // (this.GetType() == (obj.GetType()))
            {
                ret=false;
            }
            return ret;
        }

    }

}
