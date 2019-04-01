using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Anthology : IBook
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public TypeOfBook TypeOfEdition { get; set; }
        public int Pages { get; set; }
        public int ISBN { get; set; }


        public string Ediotr { get; set; }
        public string Theme { get; set; }
        public List<Story> Stories { get; set; }

        public int GenerateISBN()
        {
            throw new NotImplementedException();
        }
    }
}
