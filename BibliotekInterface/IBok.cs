using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekInterface
{
    public interface IBok
    {
        string ISBN { get; set; }
        string titel { get; set; }
        bool tillgänglig { get; set; }
        
    }
}
