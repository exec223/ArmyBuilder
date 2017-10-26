using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBuilder.Models
{
    public class ArmeeOrganisationsplan
    {
        string Name { get; set; }
        int Punkte { get; set; }
        Armee Armee { get; set; }
    }

}
