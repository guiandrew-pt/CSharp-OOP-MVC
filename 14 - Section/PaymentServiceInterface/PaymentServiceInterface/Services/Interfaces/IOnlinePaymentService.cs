namespace PaymentServiceInterface.Services.Interfaces
{
	public interface IOnlinePaymentService
	{
		double PaymentFee(double amount);
		double Interest(double amount, int months);
	}
}

