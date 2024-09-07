using InterfacesReview.Entities;

namespace InterfacesReview.Services
{
	public class RentalService
	{
        private PortugalTaxService _portugalTaxService = new PortugalTaxService();

		public double PricePerHour { get; private set; }
		public double PricePerDay { get; private set; }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _portugalTaxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        } 
    }
}

