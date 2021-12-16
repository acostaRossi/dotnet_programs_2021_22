namespace EsVillaAlloggio
{
    public class Alloggio
    {
        public Alloggio(string codice, int numPersone, double metriQuadri)
        {
            Codice = codice;
            NumPersone = numPersone;
            MetriQuadri = metriQuadri;
        }

        public string Codice { get; }
        public int NumPersone { get; }
        public double MetriQuadri { get; }

        public double CostoAcqua(double v)
        {
            return v * NumPersone;
        }
        public double Valore(double v)
        {
            return v * MetriQuadri;
        }
        virtual public double Densita()
        {
            return MetriQuadri / NumPersone;
        }
    }
}
