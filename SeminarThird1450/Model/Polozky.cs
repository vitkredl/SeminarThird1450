namespace SeminarThird1450.Model
{
    public class Polozky
    {
        public DateOnly Datum { get; set; }
       
        private double naklady;
        public double Naklady
        {
            get { return naklady; }
            set
            {
                if (naklady != value)
                {
                    if (value >= 0)
                    {
                        naklady = value;
                    }
                }


                Vynosy = value;
            }
        }
        public double Vynosy
        {
            get { return vynosy; }
            set
            {
                if (vynosy != value)
                {
                    if (value >= 0)
                    {
                        vynosy = value;
                    }
                }


                vynosy = value;
            }
        }

        public double vynosy => Vynosy - Naklady;
    }
}
