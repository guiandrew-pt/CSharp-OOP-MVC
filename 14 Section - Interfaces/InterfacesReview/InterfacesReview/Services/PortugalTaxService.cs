﻿namespace InterfacesReview.Services
{
	public class PortugalTaxService
	{
		public double Tax(double amount)
		{
			if (amount <= 100.0)
			{
				return amount * 0.2;
			}
			else
			{
                return amount * 0.15;
            } 
		}
	}
}

