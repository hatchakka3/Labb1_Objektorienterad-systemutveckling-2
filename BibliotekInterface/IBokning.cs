using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotekInterface
{
    public interface IBokning
    {
        IMedlem Medlem { get; set; }
        DateTime StartTid { get; set; }
        DateTime SlutTid { get; set; }
        IExpedit Expedit { get; set; }
        IList<IBok> Böcker { get; set; }
        string BokningsNummer { get; set; }
    }
}
