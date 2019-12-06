namespace LatvanyossagokApplication
{
    internal class Varos
    {
        private int id;
        private string nev;
        private int lakossag;

        public Varos(int id, string nev, int lakossag)
        {
            this.id = id;
            this.nev = nev;
            this.lakossag = lakossag;
        }

        public int Id { get => id; }
        public string Nev { get => nev; set => nev = value; }
        public int Lakossag { get => lakossag; set => lakossag = value; }



        public override string ToString()
        {
            return this.nev + " - Lakosság: " + this.lakossag + " fő";
        }
    }
}