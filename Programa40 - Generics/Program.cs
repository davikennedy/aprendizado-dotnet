using System;

namespace Generics
{
    public class Lista
    {
        private No primeiro;

        public void Adicionar (object elemento)
        {
            No novoNo = new No();
            novoNo.Elemento = elemento;

            if (primeiro == null)
            {
                primeiro = novoNo;
            }
            else
            {
                No no = primeiro;
                
                while (no.Proximo != null)
                {
                    no = no.Proximo;
                }
                no.Proximo = novoNo;
            }
        }

        public object Ler(int pos)
        {
            if (pos < 0)
            {
                return null;
            }
            
            if (primeiro == null)
            {
                return null;
            }

            int count = 0;
            No no = primeiro;

            while (count < pos)
            {
                no = no.Proximo;
                count++;
            }

            return no.Elemento;
        }

        private class No
        {
            public object Elemento { get; set; };
            public No Proximo { get; set; } }
        }
    }
}