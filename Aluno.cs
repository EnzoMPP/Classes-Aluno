using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02
{
    public class Aluno
    {
        private int faltas;
        public int Faltas
        {
            get{return faltas;}
            set{faltas=value;}
        }


        private string nome;
        public string Nome
        {
            get{return nome;}
            set{nome=value;}
        }
    }
    
}