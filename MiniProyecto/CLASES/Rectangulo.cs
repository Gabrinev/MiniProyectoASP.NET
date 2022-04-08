using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.CLASES
{
    public class Rectangulo : Forma
    {
        int ladoMayor;
        int ladoMenor;

        public override double getArea()
        {
            return ladoMayor * ladoMenor;
        }

        public override double getPerimetro()
        {
            return (ladoMayor * 2) + (ladoMenor * 2);
        }

        public Rectangulo(string color, string nombre, int ladoM, int lado) : base(color, nombre)
        {
            ladoMayor = ladoM;
            ladoMenor = lado;
        }
        public Rectangulo(string nombre) : base(nombre)
        {
            
        }
    }
}