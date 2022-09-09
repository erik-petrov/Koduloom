using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neznau
{
    internal class Koer : Koduloom
    {
        public enum toug { chevo, kavo, kto, gde, kodga, zachem};
        public toug Toug;

        public Koer(toug toug, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav = true) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = toug;
        }

        public override void printHaal()
        {
            Console.WriteLine("I nate higgers");
        }
        public override void printInfo()
        {
            Console.WriteLine($"{nimi}, {varv}, {Toug}. See koer on {loomaSugu} ja tema kaal on {kaal}. Ta on {vanus} aastat vana");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string _varv) { varv = _varv; }
        public void muudaSugu(sugu _sugu) { loomaSugu = _sugu; }
        public void muudaKaal(double _kaal) { kaal = _kaal; }
        public void muudaVanus(int _vanus) { vanus = _vanus; }
        public void toggleLife() { elav = !elav; }

        public Koer(Koer koer)
        {
            this.nimi = koer.nimi;
            this.varv = koer.varv;
            this.Toug = koer.Toug;
            this.kaal = koer.kaal;
            this.vanus = koer.vanus;
            this.loomaSugu = koer.loomaSugu;
            this.elav = koer.elav;
        }
    }
}
