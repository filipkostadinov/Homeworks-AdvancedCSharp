using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IBook
    {
        int ID { get; set; }
        string Title { get; set; }
        TypeOfBook TypeOfEdition { get; set; }
        int Pages { get; set; }
        int ISBN { get; set; }

        int GenerateISBN(); 
    }
}
