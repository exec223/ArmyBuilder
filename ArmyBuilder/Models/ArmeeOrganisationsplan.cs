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
                    AuswahlAnzahl = new List<ArmeeAuswahlTyp>
                    {
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Charakter,Minimalwert = 0, MaximalWert = 3 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Kommandant,Minimalwert = 0, MaximalWert = 0 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Held, Minimalwert = 0, MaximalWert = 3 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Kern, Minimalwert = 2, MaximalWert = 999999 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Elite, Minimalwert = 0, MaximalWert = 3 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Selten, Minimalwert = 0, MaximalWert = 1 }
                    };
                else if (_Punkte < 3000)
                    AuswahlAnzahl =  new List<ArmeeAuswahlTyp>
                    {
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Charakter,Minimalwert = 0, MaximalWert = 4 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Kommandant ,Minimalwert = 0, MaximalWert = 1 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Held, Minimalwert = 0, MaximalWert = 4 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Kern, Minimalwert = 3, MaximalWert = 999999 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Elite, Minimalwert = 0, MaximalWert = 4 },
                         new ArmeeAuswahlTyp {Kategorie=Kategorien.Selten, Minimalwert = 0, MaximalWert = 2 }
                    };
                else if (_Punkte < 4000)
                    AuswahlAnzahl = new List<ArmeeAuswahlTyp>
                    {
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Charakter, Minimalwert = 0, MaximalWert = 6 },
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Kommandant, Minimalwert = 0, MaximalWert = 2 },
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Held, Minimalwert = 0, MaximalWert = 6 },
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Kern, Minimalwert = 4, MaximalWert = 999999 },
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Elite, Minimalwert = 0, MaximalWert = 5 },
                        new ArmeeAuswahlTyp {Kategorie=Kategorien.Selten, Minimalwert = 0, MaximalWert = 3 }
                    };
            }
        }
        public Enums Armee { get; set; }
        public List<ArmeeAuswahlTyp> AuswahlAnzahl { get; set; }





    }

    public class ArmeeAuswahlTyp
    {   public Kategorien Kategorie {get;set;}
        public int Minimalwert { get; set; }
        public int MaximalWert { get; set; }

    }
  
}
