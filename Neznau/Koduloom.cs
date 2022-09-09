namespace Neznau
{
    abstract class Koduloom
    {
        public string nimi;
        public string varv;

        public enum sugu { isane, emane }
        public sugu loomaSugu;
        public double kaal;
        public int vanus;
        public bool elav;

        public Koduloom(string nimi, string varv, sugu loomaSugu, double kaal, int vanus, bool elav = true)
        {
            this.nimi = nimi;
            this.varv = varv;
            this.loomaSugu = loomaSugu;
            this.kaal = kaal;
            this.vanus = vanus;
            this.elav = elav;
        }
        public Koduloom() { }

        public abstract void printInfo();
        public abstract void printHaal();
    }
}
