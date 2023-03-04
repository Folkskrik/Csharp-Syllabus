using System;

public class Product
{
    private string name;
    private double price;
    private int amount;

    public Product(string name, double priceAtStart, int amountAtStart)
    {
        this.name = name;
        this.price = priceAtStart;
        this.amount = amountAtStart;
    }

    public void PrintProduct()
    {
        Console.WriteLine($"{name}, price {price}, amount {amount}");
    }

    public void ChangeQuantity(int newQuantity)
    {
        this.amount = newQuantity;
    }

    public void ChangePrice(double newPrice)
    {
        this.price = newPrice;
    }
}