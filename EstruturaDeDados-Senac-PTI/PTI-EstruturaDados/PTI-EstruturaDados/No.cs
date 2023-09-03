using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI_EstruturaDados
{
    public class No
    {
        private int ID { get; set; }
        private Object Elemento { get; set; }
        private No Esquerdo { get; set; }
        private No Direito { get; set; }

        public No(int id, object elemento,No esq = null, No dir = null)
        {
            this.ID = id;
            this.Elemento = elemento;
            this.Esquerdo = esq;
            this.Direito = dir;
                
        }
        public int getID
        {
            get { return ID; }
        }

        public void setID(int id) // método para alterar o identificador do nó
        {
            this.ID = id;
        }
        public Object getElemento
        {
            get { return Elemento; }
        }
        public void setElemento(Object elemento) // método para alterar o elemento
        {
            this.Elemento = elemento;
        }
        public No getEsq
        {
            get { return Esquerdo; }
        }

        public void setEsq(No esq) // método que altera o filho esquerdo
        {
            this.Esquerdo = esq;
        }
        public No getDir
        {
            get { return Direito; }
        }
        public void setDir(No dir) // método que altera o filho direito
        {
            this.Direito = dir;
        }
        
    }
}

