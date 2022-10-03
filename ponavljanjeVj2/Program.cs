using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ponavljanjeVj2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
        
        class Stablo
        {
            bool otpadajuListovi;
            string vrstaStabla;

            public Stablo(bool otpadajuListovi)
            {
                this.otpadajuListovi = otpadajuListovi;
                bool stablo1 = false;
                bool stablo2 = true;
            }

            public string OtpadajuListovi { get; set; }

            public override string ToString()
            {
                if(otpadajuListovi = true)
                {
                    vrstaStabla = "bijelogorično";
                }

                if (otpadajuListovi = true)
                {
                    vrstaStabla = "crnogorično";
                }

                return base.ToString();
            }

            
        }
    }
}
