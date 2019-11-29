namespace LatvanyossagokApplication
{
    internal class Latvanyossag
    {
        private int id;
        private string nev;
        private string leiras;
        private int ar;
        private int varos_id;

        public Latvanyossag(int id, string nev, string leiras, int ar, int varos_id)
        {
            this.Id = id;
            this.Nev = nev;
            this.Leiras = leiras;
            this.Ar = ar;
            this.Varos_id = varos_id;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public int Ar { get => ar; set => ar = value; }
        public int Varos_id { get => varos_id; set => varos_id = value; }

        public override string ToString()
        {
            var e = "";

            if (this.ar == 0)
            {
                e = "Ingyenes";
            }
            else
            {
                e = this.ar + " Ft";
            }

            return this.nev + " - " + this.ar + " Ft";
        }
    }
}