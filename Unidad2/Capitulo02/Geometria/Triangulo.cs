using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class Triangulo
    {
        private int m_catetobase;

        private int m_cateto2;

        private int m_cateto3;

        private int m_altura;

        public int CatetoBase { get => m_catetobase; set => m_catetobase = value; }
        public int Cateto2 { get => m_cateto2; set => m_cateto2 = value; }
        public int Cateto3 { get => m_cateto3; set => m_cateto3 = value; }
        public int Altura { get => m_altura; set => m_altura = value; }

        public int CalcularPerimetro()
        {
            return CatetoBase + Cateto2 + Cateto3;
        }

        public int CalcularSuperficie()
        {
            return Altura * CatetoBase;
        }
    }
}
