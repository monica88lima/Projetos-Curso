using PTI_EstruturaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTI_EstruturaDados
{
    public class ArvoreBinaria
    {
        private No Raiz;
        public ArvoreBinaria()
        {
            this.Raiz = null;
        }
        private void preFixado(No atual)
        {// caminhamento pré-fixado da árvore

            if (atual != null)
            {
                Console.WriteLine($"ID: {atual.getID} - Elemento:{atual.getElemento}");
                preFixado(atual.getEsq);
                preFixado(atual.getDir);
            }
            else
            {
                Console.WriteLine(" - ");
            }

        }

        public int ContarNosEsquerdaFestiva()
        {
            return ContarNosEsquerdaFestivaRecursivo(this.Raiz);
        }

        private int ContarNosEsquerdaFestivaRecursivo(No no)
        {
            if (no == null)
            {
                return 0;
            }

            int count = ContarNosEsquerdaFestivaRecursivo(no.getEsq) + ContarNosEsquerdaFestivaRecursivo(no.getDir);

            if (no.getEsq != null)
            {
                count++;
            }

            return count;
        }


        public void imprimeElementosArvore() 
        {
            preFixado(this.Raiz);
        }
        public void Inserir(int id, object obj)
        {
            No no = new No(id, obj);

            if (this.Raiz == null)
            {
                this.Raiz = no;
            }
            else
            {
                InserirRecursivo(this.Raiz, no);
            }
        }

        private void InserirRecursivo(No existente, No novo)
        {
            if (novo.getID < existente.getID)
            {
                if (existente.getEsq == null)
                {
                    existente.setEsq(novo);
                }
                else
                {
                    InserirRecursivo(existente.getEsq, novo);
                }
            }
            else
            {
                if (existente.getDir == null)
                {
                    existente.setDir(novo);
                }
                else
                {
                    InserirRecursivo(existente.getDir, novo);
                }
            }
        }




    }
}
