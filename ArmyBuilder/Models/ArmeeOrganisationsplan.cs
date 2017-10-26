using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyBuilder.Models
{
    public class ArmeeOrganisationsplan
    {
        public string Name { get; set; }
        private int _Punkte;
        public int Punkte { get { return _Punkte; } set
            {
                _Punkte = value;
                if (_Punkte < 2000)
                    AuswahlAnzahl = new ArmeeAuswahlen
                    {
                        Charakter = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 3 },
                        Kommandanten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 0 },
                        Helden = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 3 },
                        Kerneinheiten = new ArmeeAuswahlTyp { Minimalwert = 2, MaximalWert = 999999 },
                        EliteEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 3 },
                        SelteneEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 1 }
                    };
                else if (_Punkte < 3000)
                    AuswahlAnzahl = new ArmeeAuswahlen
                    {
                        Charakter = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 4 },
                        Kommandanten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 1 },
                        Helden = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 4 },
                        Kerneinheiten = new ArmeeAuswahlTyp { Minimalwert = 3, MaximalWert = 999999 },
                        EliteEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 4 },
                        SelteneEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 2 }
                    };
                else if (_Punkte < 4000)
                    AuswahlAnzahl = new ArmeeAuswahlen
                    {
                        Charakter = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 6 },
                        Kommandanten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 2 },
                        Helden = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 6 },
                        Kerneinheiten = new ArmeeAuswahlTyp { Minimalwert = 4, MaximalWert = 999999 },
                        EliteEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 5 },
                        SelteneEinheiten = new ArmeeAuswahlTyp { Minimalwert = 0, MaximalWert = 3 }
                    };
            }
        }
        public Armee Armee { get; set; }
        public ArmeeAuswahlen AuswahlAnzahl { get; set; }





    }

    public class ArmeeAuswahlen
    {
        public ArmeeAuswahlTyp Charakter { get; set; }
        public ArmeeAuswahlTyp Kommandanten { get; set; }
        public ArmeeAuswahlTyp Helden { get; set; }
        public ArmeeAuswahlTyp Kerneinheiten { get; set; }
        public ArmeeAuswahlTyp EliteEinheiten { get; set; }
        public ArmeeAuswahlTyp SelteneEinheiten { get; set; }
    }

    public class ArmeeAuswahlTyp
    {
        public int Minimalwert { get; set; }
        public int MaximalWert { get; set; }

    }
  
}
