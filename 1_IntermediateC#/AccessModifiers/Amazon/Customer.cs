using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); //not a good practice, creates coupling / dependency
            var rating = calculator.Calculate(this); 

            Console.WriteLine("promote logic changed");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
