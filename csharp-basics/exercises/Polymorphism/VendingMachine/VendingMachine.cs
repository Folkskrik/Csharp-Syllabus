using System;

namespace VendingMachine
{
    public class VendingMachine : IVendingMachine
    {
        public Product[] _products;
        private Money _amount;

        public VendingMachine(string manufacturer)
        {
            Manufacturer = manufacturer;
            _products = new Product[0];
        }

        public string Manufacturer { get; }

        public bool HasProducts => _products.Length > 0;

        public Money Amount => _amount;

        public Product[] Products
        {
            get { return _products; }
            set { _products = value; }
        }

        public Money InsertCoin(Money amount)
        {
            _amount.Euros += amount.Euros;
            _amount.Cents += amount.Cents;

            if (_amount.Cents >= 100)
            {
                _amount.Euros += _amount.Cents / 100;
                _amount.Cents %= 100;
            }


            return new Money(_amount.Euros, _amount.Cents);

        }


        public Money ReturnMoney()
        {
            if (_amount.Euros == 0 && _amount.Cents == 0)
            {
                return new Money();
            }

            var moneyToReturn = new Money(_amount.Euros, _amount.Cents);
            _amount = new Money();

            return moneyToReturn;
        }

        public bool AddProduct(string name, Money price, int count)
        {
            if (string.IsNullOrEmpty(name) || !IsValidMoney(price) || count <= 0)
            {
                return false;
            }

            var product = new Product
            {
                Name = name,
                Price = price,
                Available = count
            };

            Array.Resize(ref _products, _products.Length + 1);
            _products[_products.Length - 1] = product;

            return true;
        }

        public bool UpdateProduct(int productNumber, string name, Money? price, int amount)
        {
            if (productNumber < 0 || productNumber >= _products.Length)
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

        public bool IsValidMoney(Money money)
        {
            bool isValid = (money.Euros >= 0 && money.Euros <= 2) &&
                           (money.Cents == 0 || money.Cents == 10 || money.Cents == 20 || money.Cents == 50);
            return isValid;
        }
    }
}