using System;
using System.Numerics;
class Order
{
    public static void Create_Order()
    {
        Console.Clear();
        Customer customer = new Customer("David", "123 Adress Ln", "Madeupsville UT", "America");

        string full_Adress = Adress.Combine_Full_Adress(customer._adress, customer._city, customer._country);
        bool is_america = Adress.Check_Country(customer._country);
        int shipping = 0;

        System.Console.WriteLine("Shipping Label:");
        System.Console.WriteLine("-----------------");
        System.Console.WriteLine($"Name: {customer._name}");
        System.Console.WriteLine($"Adress: {full_Adress}");
        System.Console.WriteLine("Products: ");
        List<object[]> orders = Product.Get_Products();
        foreach (object[] order in orders)
        {
            System.Console.WriteLine("Product: ");
            foreach (object item in order)
            {
                System.Console.WriteLine($" {item}");
            }
            System.Console.WriteLine();
        }

        if (is_america == true)
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        System.Console.WriteLine($"${Get_Total() + shipping}");
    }
    static float Get_Total()
    {
        List<object[]> products = Product.Get_Products();


        float total = 0;

        foreach (var product in products)
        {
            double price = Convert.ToDouble(product[2]);
            int quantity = Convert.ToInt32(product[3]);

            total += (float)(price * quantity);
        }
        return (float)total;
    }
}