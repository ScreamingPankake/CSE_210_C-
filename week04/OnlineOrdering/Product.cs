

class Product
{
    public static List<object[]> Get_Products()
    {
        List<object[]> products = new List<object[]>()
        {
            new object[] { "Flour",    63413, 4.53,  2 },
            new object[] { "Sugar",    43674, 3.25,  1 },
            new object[] { "Salt",     12345, 1.99,  3 },
            new object[] { "Rice",     58921, 6.80,  5 },
            new object[] { "Pasta",    48290, 2.35,  4 },
            new object[] { "Oats",     27560, 3.89,  6 },
            new object[] { "Beans",    36142, 2.99,  2 },
            new object[] { "Milk",     41823, 1.59,  10 },
            new object[] { "Eggs",     50987, 2.79,  12 },
            new object[] { "Butter",   69301, 4.25,  3 }
        };
        return products;
    }
}