using System;

public class task2_1
{
    public delegate double DiscountStrategy(double price);

    public double FestivalDiscount(double price) => price - (price * 0.20);

    public double SeasonalDiscount(double price) => price - (price * 0.10);

    public double NoDiscount(double price) => price;

    public double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy)
        => strategy(originalPrice);
}
