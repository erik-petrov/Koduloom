using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neznau
{
    internal class Kuulik : Koduloom, File
    {
        public enum toug { American, Britannia_Petite, Florida_White, Dutch, English_Spot };
        public toug Toug;

        public double Speed;

        public Kuulik(toug _toug, double speed, string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav = true) : base(nimi, varv, loomaSugu, kaal, vanus, elav)
        {
            this.Toug = _toug;
            this.Speed = speed;
        }

        public override void printHaal()
        {
            Console.WriteLine("*silence*");
        }
        public override void printInfo()
        {
            Console.WriteLine($"{nimi}, {varv}, {Toug}. See kuulik on {loomaSugu} ja tema kaal on {kaal}. Ta on {vanus} aastat vana. Tema kiirus on {Speed}m/s");
        }
        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        public void muudaVarv(string _varv) { varv = _varv; }
        public void muudaSugu(sugu _sugu) { loomaSugu = _sugu; }
        public void muudaKaal(double _kaal) { kaal = _kaal; }
        public void muudaVanus(int _vanus) { vanus = _vanus; }
        public void muudaKiirus(double _speed) { Speed = _speed; }
        public void toggleLife() { elav = !elav; }

        public Kuulik(Kuulik kuulik)
        {
            this.nimi = kuulik.nimi;
            this.varv = kuulik.varv;
            this.Toug = kuulik.Toug;
            this.kaal = kuulik.kaal;
            this.vanus = kuulik.vanus;
            this.loomaSugu = kuulik.loomaSugu;
            this.elav = kuulik.elav;
        }
    }
}
