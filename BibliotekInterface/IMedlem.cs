using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekInterface
{
    public interface IMedlem
    {
        string mNummer { get; set; }
        string namn { get; set; }
        string telNummer { get; set; }
        string email { get; set; }
    }
}
