namespace EsVillaAlloggio
{
    public class Villa : Alloggio
    {
        public Villa(string codice, int numPersone, double metriQuadri, double giardino): base(codice, numPersone, metriQuadri)
        {
            Giardino = giardino;
        }

        public double Giardino { get; }

        public double Valore(double v1, double v2)
        {
            return base.Valore(v1) + v2 * Giardino;
        }

        public override double Densita()
        {
            return (MetriQuadri + Giardino) / NumPersone;
        }
    }
}
