using System;

namespace Generics
{
    public class Lista<T>
    {
        private No<T> _primeiro;

        public void Adicionar(T elemento)
        {
            No<T> novoNo = new No<T>();
            novoNo.Elemento = elemento;

            if (_primeiro == null)
            {
                _primeiro = novoNo;
            }
            else
            {
                No<T> no = _primeiro;

                while (no.Proximo != null)
                {
                    no = no.Proximo;
                }
                no.Proximo = novoNo;
            }
        }

        public T Ler(int pos)
        {
            if (pos < 0 || _primeiro == null)
            {
                return default(T);
            }

            int count = 0;
            No<T> no = _primeiro;

            while (count < pos)
            {
                no = no.Proximo;
                count++;
            }

            return no.Elemento;
        }

        private class No<T>
        {
            public T Elemento { get; set; }
            public No<T> Proximo { get; set; }
        }
    }
}
