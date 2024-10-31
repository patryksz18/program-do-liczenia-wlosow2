namespace SzacowanieWlosowNaGlowie
{
    public class Glowa
    {
        private const double SredniaLiczbaWlosow = 100000;
        private const double DomyslnyObwodGlowy = 56.0;
        private const double DomyslnaWysokoscCzola = 15.0;
        private double obwodGlowy;
        private double wysokoscCzolla;
        private double gestoscWlosow;
        private double powierzchniaGlowy;
        private double liczbaWlosow;

        public Glowa()
        {
            obwodGlowy = DomyslnyObwodGlowy;
            wysokoscCzolla = DomyslnaWysokoscCzola;
            gestoscWlosow = 100;
            liczbaWlosow = 0;
            powierzchniaGlowy = 0;
        }

        public void UstawObwodGlowy(double obwod) => obwodGlowy = obwod;
        public void UstawWysokoscCzola(double wysokosc) => wysokoscCzolla = wysokosc;
        public void UstawGestoscWlosow(double gestosc) => gestoscWlosow = gestosc;

        public void ObliczLiczbeWlosow()
        {
            powierzchniaGlowy = (obwodGlowy * wysokoscCzolla) / 2;
            liczbaWlosow = powierzchniaGlowy * gestoscWlosow;
        }

        public double PobierzLiczbeWlosow() => liczbaWlosow;

        public double PorownajDoSredniej()
        {
            return ((liczbaWlosow - SredniaLiczbaWlosow) / SredniaLiczbaWlosow) * 100;
        }

        public void Resetuj()
        {
            obwodGlowy = DomyslnyObwodGlowy;
            wysokoscCzolla = DomyslnaWysokoscCzola;
            gestoscWlosow = 100;
            powierzchniaGlowy = 0;
            liczbaWlosow = 0;
        }
    }
}

