using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekInterface
{
    public interface IExpedit
    {
        string roll
        {
            get; set;
        }
        string aNummer
        {
            get; set;
        }
        string lösen
        {
            get; set;
        }
        string namn { get; set; }
    }
}
