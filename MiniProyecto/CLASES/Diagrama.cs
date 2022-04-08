using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProyecto.CLASES
{
    public class Diagrama
    {
        private List<Forma> list;
        private double perimetroTotal;
        private double areaTotal;

        public Diagrama()
        {
            list = new List<Forma>();
        }

        public void añadirForma(Forma f)
        {
            list.Add(f);

        }

        public double calcTotalPerimetros()
        {

            foreach (Forma f in list)
            {
                perimetroTotal += f.getPerimetro();
            }

            return perimetroTotal;

        }

        public double totalFormas()
        {


            return list.Count();

        }

        public double calcTotalAreas()
        {

            foreach (Forma f in list)
            {
                areaTotal += f.getArea();
            }

            return areaTotal;

        }
        public void removeLast()
        {
            int n = list.Count();
            list.RemoveAt(n);
        }
    }
}
