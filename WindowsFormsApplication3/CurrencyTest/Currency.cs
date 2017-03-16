using System;

namespace CurrencyTest
{
    public class Currency
    {
        public decimal Amount { get; private set; }
        public string CurrencyName { get; private set; }
        public decimal ChangeRate { get; private set; }

        public Currency(decimal amount,
            string currencyName,
            decimal changeRate)
        {
            ChangeRate = changeRate;
            CurrencyName = currencyName;
            Amount = amount;
        }

        public Currency Times(int times)
        {
            return new Currency(Amount * times, CurrencyName, ChangeRate);
        }

        public static Currency Dollar(decimal amount)
        {
            return new Currency(amount, "USD", 1);
        }

        public static Currency Frank(decimal amount)
        {
            return new Currency(amount, "CHF", 0.5m);
        }

        public bool Equal(Currency currency)
        {
            return Amount == currency.Amount && CurrencyName == currency.CurrencyName;
        }

        public Currency Sum(Currency currency)
        {
            var newAmount = Amount + currency.Amount * currency.ChangeRate;
            return new Currency(newAmount, CurrencyName, ChangeRate);
        }
    }
}
