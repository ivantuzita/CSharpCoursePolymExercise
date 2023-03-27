using CSharpCoursePolymExercise.Entities;

Console.Write("Enter the number of products: ");
int n = int.Parse(Console.ReadLine());

List<Product> products = new List<Product>();

for (int i = 0; i < n; i++) {
    Console.WriteLine($"Product #{i+1} data:");
    Console.Write("Common, used or imported (c/u/i)? ");
    string type = Console.ReadLine();
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine());

    switch (type) {
        case "c":
            products.Add(new(name, price));
            break;
        case "i":
            Console.Write("Customs fee: ");
            double customs = double.Parse(Console.ReadLine());
            products.Add(new ImportedProduct(name, price, customs));
            break;
        case "u":
            Console.Write("Manufacture data (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            products.Add(new UsedProduct(name, price, date));
            break;
    }
}

Console.WriteLine("PRICE TAGS:");

foreach (Product product in products){
    Console.WriteLine(product.priceTag());
}