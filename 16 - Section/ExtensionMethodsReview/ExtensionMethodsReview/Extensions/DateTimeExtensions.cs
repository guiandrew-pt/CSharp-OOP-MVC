// We can put the class in the system namespace, that will be better to refer;
namespace ExtensionMethodsReview.Extensions
{
	public static class DateTimeExtensions
	{
		public static string ElapsedTime(this DateTime thisObj)
		{
			TimeSpan duration = DateTime.Now.Subtract(thisObj);

			if (duration.TotalHours < 24.0)
			{
				return $"{duration.TotalHours.ToString("F1")} hours";
			}
			else
			{
                return $"{duration.TotalDays.ToString("F1")} days";
            }
		}
	}
}

