using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Libro
    {
        private List<string> paginas;

        public Libro()
        {
            this.paginas = new List<string>();
        }
        public string this[int i]
        {
            get 
            {
                if (i < paginas.Count && i > 0)
                    return paginas[i];
                else
                    return string.Empty;
            }
            set 
            {
                if(i>=0)
                {
                    if (i < paginas.Count)
                        this.paginas[i] = value;
                    else if (i >= paginas.Count)
                        paginas.Add(value);
                }
            }
        }
    }
}
