
//using DesingPattern.DependencyInjection;
using DesingPattern.Builder;
using DesingPattern.Factory;
using DesingPattern.Models;
using DesingPattern.Repository;
using DesingPattern.Singleton;
using DesingPattern.State;
using DesingPattern.Strategy;
using DesingPattern.UnitOfWork;

/////////SINGLETON
//////////////////
//var singleton =  Singleton.Instance;

//var log = Log.Instance;
//log.Save("a");
//log.Save("b");
//log.Saludo();

//var a = Singleton.Instance;
//var b = Singleton.Instance;

//Console.WriteLine(a==b);

//////////FACTORY
//////////////////
//SaleFactory storeSale = new StoreSaleFactory(10);  
//SaleFactory internetSale = new InternetSaleFactory(2);

//ISale sale1 = storeSale.GetSale();
//sale1.Sell(15);

//ISale sale2 = internetSale.GetSale();
//sale2.Sell(15);

//////////DEPENDENCYINJECTION
//////////////////
//var beer = new Beer("Pikantus", "Erdinger");
//var drinkWithBeer = new DrinkWithBeer(10, 1, beer);
//drinkWithBeer.Build();

/////////////REPOSITORY
//////////////////

//using (var context=new DesignPatternsContext())
//{
//    var lst = context.Beers.ToList();
//    foreach (var beer in lst)
//    {
//        Console.WriteLine(beer.Name);   
//    }
//}
//////
//using (var context=new DesignPatternsContext())
//{
//    var beerRepository = new BeerRepository(context);  
//    var beer=new Beer();
//    beer.Name = "Corona";
//    beer.Style = "Pilsner";
//    beerRepository.Add(beer);
//    beerRepository.Save();

//    foreach (var b in beerRepository.Get())
//    {
//        Console.WriteLine(b.Name);
//    }

//}

///REPOSITORY CON GENERICS
/////////////////////
//using (var context = new DesignPatternsContext())
//{
//    var beerRepository = new Repository<Beer>(context);
//    //var beer = new Beer() {Name="Fuller",Style="Strong Ale"};
//    //beerRepository.Add(beer);   
//    beerRepository.Delete(4);
//    beerRepository.Save();

//    foreach (var b in beerRepository.Get())
//    {
//        Console.WriteLine($"{b.BeerId}{b.Name}");
//    }

//    var brandRepository = new Repository<Brand>(context);

//    var brand = new Brand() { Name = "Fuller" };
//    brandRepository.Add(brand);
//    brandRepository.Save();
//    foreach (var b in brandRepository.Get())
//    {
//        Console.WriteLine(b.Name);
//    }



//}


//UNIT OF WORK
//////////////////
//using (var context = new DesignPatternsContext())
//{

//    var unitOfWork = new UnitOfWork(context);
//    var beers = unitOfWork.Beers;
//    var beer = new Beer() { Name = "Fuller", Style = "Porter" };
//    beers.Add(beer);

//    var brands = unitOfWork.Brands;
//    var brand = new Brand() { Name = "Fuller" };
//    brands.Add(brand);

//    unitOfWork.Save();

//}

//STRATEGY
//////////////////
///
//var context = new Context(new CarStrategy());
//context.Run();
//context.Strategy=new MotoStrategy();
//context.Run();
//context.Strategy = new BiciStrategy();
//context.Run();

//BUILDER
//////////////////

//var builder=new PrepareAlcoholicDrinkConcreteBuilder();
//var barman=new BarmanDirector(builder);
//barman.PrepareMargarita();  
//barman.PreparePinaColada();  

//var preparedDrink =builder.GetPrepareDrink();

//Console.WriteLine(preparedDrink.Result);


//STATE
///////////////////

var customerContext=new CustomerContext();
Console.WriteLine(customerContext.GetState());
customerContext.Request(100);
Console.WriteLine(customerContext.GetState());
customerContext.Request(50);
Console.WriteLine(customerContext.GetState());
customerContext.Request(50);
Console.WriteLine(customerContext.GetState());
customerContext.Request(50);
Console.WriteLine(customerContext.GetState());


Console.Read();