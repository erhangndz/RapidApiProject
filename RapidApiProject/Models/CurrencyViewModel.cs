namespace RapidApiProject.Models
{
    public class CurrencyViewModel
    {

        public class Rootobject
        {
            public float new_amount { get; set; }
            public string new_currency { get; set; }
            public string old_currency { get; set; }
            public int old_amount { get; set; }
        }

    }
}
