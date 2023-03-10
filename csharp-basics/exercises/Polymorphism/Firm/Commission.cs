using System;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;
        private double v;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double v) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            this.v = v;
        }

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate, int v, int v1)
            : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _totalSales = 0;
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            double payment = base.Pay();
            payment += _totalSales * _commissionRate;
            _totalSales = 0;
            return payment;
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += "\nTotal Sales: " + _totalSales;
            return result;
        }
    }
}