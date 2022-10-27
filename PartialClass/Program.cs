using PartialClass;

Product product = new Product("Pencil",100,23,10);

// Comes from Product.cs
Console.WriteLine(product.Name);

// Comes from Product2.cs
Console.WriteLine($"{product.Name} price : {product.UnitPrice}");
Console.WriteLine($"{product.Name} discounted price : {product.GetDiscountedPrice()}");


