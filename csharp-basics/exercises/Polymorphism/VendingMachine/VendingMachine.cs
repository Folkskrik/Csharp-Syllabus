using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        private readonly List<Product> _products;
        private Money _amount;

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            _products = new List<Product>();
        }

        public string Manufacturer { get; }

        public bool HasProducts => _products.Count > 0;

        public Money Amount => _amount;

        public Product[] Products
        {
            get { return _products.ToArray(); }
            set
            {
                _products.Clear();
                _products.AddRange(value);
            }
        }

        public Money InsertCoin(Money amount)
        {
            if (!IsValidMoney(amount))
            {
                return amount;
            }

            _amount.Euros += amount.Euros;
            _amount.Cents += amount.Cents;

            if (_amount.Cents >= 100)
            {
                _amount.Euros += _amount.Cents / 100;
                _amount.Cents %= 100;
            }

            return new Money();
        }

        public Money ReturnMoney()
        {
            Money moneyToReturn = _amount;
            _amount = new Money();
            return moneyToReturn;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (string.IsNullOrEmpty(name) || !IsValidMoney(price) || count <= 0)
            {
                return false;
            }

            _products.Add(new Product
            {
                Name = name,
                Price = price,
                Available = count
            });

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Count)
            {
                return false;
            }

            var productToUpdate = _products[productNumber];

            if (!string.IsNullOrEmpty(name))
            {
                productToUpdate.Name = name;
            }

            if (price.HasValue && IsValidMoney(price.Value))
            {
                productToUpdate.Price = price.Value;
            }

            if (amount >= 0)
            {
                productToUpdate.Available = amount;
            }

            return true;
        }

        private static bool IsValidMoney(Money money)
        {
            switch (money.Euros)
            {
                case 0:
                case 1:
                case 2:
                    break;
                default:
                    return false;
            }

            switch (money.Cents)
            {
                case 10:
                case 20:
                case 50:
                    break;
                default:
                    return false;
            }

            return true;
        }
    }
}