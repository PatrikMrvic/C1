namespace Skola
{
    internal class Predmet
    {
        private string naziv;

        public Predmet(string naziv)
        {
            this.Naziv = naziv;
        }

        public string Naziv { get => naziv; set => naziv = value; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}