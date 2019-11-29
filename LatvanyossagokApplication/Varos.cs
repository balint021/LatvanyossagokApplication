namespace LatvanyossagokApplication
{
    internal class Varos
    {
        private int id;
        private string nev;
        private string lakossag;

        public Varos(int id, string nev, string lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
        }

        public int Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public string Lakossag { get => lakossag; set => lakossag = value; }



        public override string ToString()
        {
            return this.nev + " - Lakosság: " + this.lakossag + " fő";
        }
    }
}