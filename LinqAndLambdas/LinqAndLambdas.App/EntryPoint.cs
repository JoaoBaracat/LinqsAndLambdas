using LinqAndLambdas.App;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqAndLambdas
{
    public class EntryPoint
    {
        static void Main (string[] args)
        {
            string sentence = "I love cats";
            string[] catNames = { "Lucky", "Bella", "Luna", "Orea", "Simba", "Toby", "Loki", "Oscar" };
            List<int> numbers = new List<int>() { 1, 2, 5, 3, 5, 2, 5, 7, 87, 2, 3, 4, 35, 6, 1, 1, 7, 5, 2, 4, 54, 2, 2, 1 };
            object[] mix = { 1, "string", new List<int>() { 1, 2, 3, 4, 5 }, "dd", 5, new int[5] { 1, 2, 3, 4, 5 }, 4, 5, 6, 2, 4, 54, 2, 2, 1, new List<int>() { 100, 22, 33, 4, 45 } };

            List<Warrior> warriors = new List<Warrior>()
            {
                new Warrior(){ Height = 100},
                new Warrior(){ Height = 80},
                new Warrior(){ Height = 100},
                new Warrior(){ Height = 70},
                new Warrior(){ Height = 170}
            };

            List<Person> people = new List<Person>()
            {
                new Person("Hai", 120, 70, Gender.Male, 15),
                new Person("Fey", 110, 60, Gender.Female, 15),
                new Person("Kira", 130, 30, Gender.Female, 23),
                new Person("Luna", 140, 90, Gender.Female, 23),
                new Person("Anna", 150, 100, Gender.Female, 26),
                new Person("Kyle", 160, 120, Gender.Male, 25),
                new Person("John", 170, 77, Gender.Male, 26)
            };

            List<Buyer> buyers = new List<Buyer>()
            {
                new Buyer(1, "Cliente ", 1, 22),
                new Buyer(1, "Cliente 2", 1, 22),
                new Buyer(1, "Cliente 3", 5, 22),
                new Buyer(1, "Cliente 4", 1, 44),
                new Buyer(1, "Cliente 5", 1, 23),
                new Buyer(1, "Cliente 5", 2, 23),
                new Buyer(1, "Cliente 5", 3, 23),
                new Buyer(1, "Cliente 5", 3, 23),
                new Buyer(1, "Cliente 5", 1, 23),
            };

            List<Supplier> suppliers = new List<Supplier>()
            {
                new Supplier(1, "Fornecedor", 1, 22),
                new Supplier(1, "Fornecedor2", 1, 22),
                new Supplier(1, "Fornecedor3", 3, 23),
                new Supplier(1, "Fornecedor4", 5, 31),
            };


            var allStrings = mix.OfType<string>().Where(str => str.Length > 2);
            //var allStrings = from m in mix
            //                  where m is string //&& (m as string).Length > 2
            //                  let str = m as string
            //                 where str.Length > 2
            //                 //where (m as string).Length > 2
            //                  select m;

            foreach (var item in allStrings)
            {
                Console.WriteLine($"   {item.GetType()} ");
                Console.WriteLine($"   {item} ");
            }

            //var allIntegers = mix.OfType<int>();
            //foreach (var item in allIntegers)
            //{
            //    Console.WriteLine($"   {item} ");
            //}




            //var innerJoin = from s in suppliers
            //                orderby s.District
            //                join b in buyers on s.District equals b.District
            //                select new
            //                {
            //                    SupplierName = s.Name,
            //                    BuyerName = b.Name,
            //                    District = s.District // pode ser apenas s.Distric, pois eles tem o mesmo nome nas tabelas

            //                };


            //foreach (var item in innerJoin)
            //{
            //    Console.WriteLine($"   {item.District} {item.SupplierName} {item.BuyerName}");
            //}

            //var innerJoin = suppliers.Join(buyers, s => s.District, b => b.District,
            //    (s, b) => new
            //    {
            //        SupplierName = s.Name,
            //        BuyerName = b.Name,
            //        District = s.District
            //    });


            //foreach (var item in innerJoin)
            //{
            //    Console.WriteLine($"   {item.District} {item.SupplierName} {item.BuyerName}");
            //}


            //var compositeJoin = suppliers.Join(buyers,
            //    s => new { s.District, s.Age },
            //    b => new { b.District, b.Age},
            //    (s, b) => new
            //    {
            //        SupplierName = s.Name,
            //        BuyerName = b.Name,
            //        District = s.District,
            //        Age = s.Age
            //    });


            //foreach (var item in compositeJoin)
            //{
            //    Console.WriteLine($"   {item.District} {item.SupplierName} {item.BuyerName} {item.Age}");
            //}








            //var simpleGroup = people.GroupBy(p => p.Gender);

            ////var genderGroup = from p in people
            ////                  group p by p.Gender;

            //foreach (var person in simpleGroup)
            //{
            //    Console.WriteLine($"{person.Key}");
            //    foreach (var p in person)
            //    {
            //        Console.WriteLine($"   {p.Name} {p.Gender}");
            //    }

            //}

            //var simpleGroupWithCondidtion = people.Where(p=> p.Age > 20)
            //                                        .GroupBy(p => p.Gender);
            ////var groupWithCondition = from p in people
            ////                         where p.Age > 20
            ////                         group p by p.Age;

            //foreach (var key in simpleGroupWithCondidtion)
            //{
            //    Console.WriteLine($"{key.Key}");
            //    foreach (var p in key)
            //    {
            //        Console.WriteLine($"   {p.Name} {p.Age}");
            //    }

            //}

            //var simpleGrupoPrimeiraLetra = people.OrderBy(p=> p.Name)
            //                                        .GroupBy(p => p.Name[0]);
            ////var groupPrimeiraLetraGroup = from p in people
            ////                              orderby p.Name
            ////                         group p by p.Name[0];

            //foreach (var key in simpleGrupoPrimeiraLetra)
            //{
            //    Console.WriteLine($"{key.Key}");
            //    foreach (var p in key)
            //    {
            //        Console.WriteLine($"   {p.Name}");
            //    }

            //}

            //var multiKey = people
            //                    .GroupBy(p => new { p.Gender, p.Age })
            //                    .OrderBy(p => p.Count());
            ////var groupPrimeiraLetraGroup = from p in people
            ////                              orderby p.Name
            ////                         group p by p.Name[0];

            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            //foreach (var key in multiKey)
            //{
            //    Console.WriteLine($"{key.Key}");
            //    foreach (var p in key)
            //    {
            //        Console.WriteLine($"   {p.Name} {p.Gender} {p.Age}");
            //    }

            //}


            //warriors.ForEach(w => Console.WriteLine(w.Height));

            ////exemplo Join >> ta pela altura e nao por ID pq nao criei ID
            //var warriorJoinPeople = warriors
            //                        .Join(people, w => w.Height, p => p.Height, (warriors, people) => new { warriors, people })
            //                        .Select(x => new
            //                        {
            //                            x.warriors.Height,
            //                            x.people.Name,
            //                            x.people.Gender,
            //                            x.people.Weight
            //                        });


            //var shortWarrior = warriors.Select(w => w.Height); // Select returns a new collection from another collection. Cannot apply conditions on its own
            //var shortWarrior1 = warriors.Where(w => w.Height == 100); // Where returns items from the same collection that match a given condition

            //// Can combine those two to get where height = 100 and to return a new collection with it
            //List<int> shortwarrior2 = warriors.Where(w => w.Height == 100)
            //                            .Select(w => w.Height).ToList();
            //Console.WriteLine();
            //shortwarrior2.ForEach(sw => Console.WriteLine(sw));



            //// ----------------------------------------------------------------------------------------------------------------------------
            //// Lets say we want to extract all odd numbers from numbers list, and add it to a new collection. With 1 line of code, we can do that using lambda expressions.
            //List<int> oddNumbers = numbers                            
            //    .Where(n => (n % 2 == 1)).ToList();
            //Console.WriteLine("OddNumbers");
            //Console.WriteLine(string.Join(", ", oddNumbers));


            //// Lets say we want to extract all integers from our mix array
            //var allIntegers = mix.OfType<int>().Where(i => i < 3);
            //Console.WriteLine(string.Join(", ", allIntegers));

            //var allIntLists = mix.OfType<List<int>>().ToList(); // Extracting all lists of int and then displaying them
            //for (int i = 0; i < allIntLists.Count; i++)
            //{
            //    Console.WriteLine($"Int lists[{i}]: " + string.Join(", ", allIntLists[i]));
            //}



            //// ----------------------------------------------------------------------------------------------------
            //// LINQ Queries on Objects
            //// Lets say we want people who's name is 4 characters long, and we want them in a new collection
            //var fourCharPeople = from p in people
            //                     where (p.Name.Length == 4)
            //                     orderby p.Name descending, p.Height
            //                     select p;


            ////var nomeEAltura = fourCharPeople.Select(x => $"Name: {x.Name}, Weight: {x.Weight}");
            ////Console.WriteLine(string.Join(", ", nomeEAltura));

            //foreach (var item in fourCharPeople)
            //{
            //    Console.WriteLine($"Name: {item.Name}, Weight: {item.Weight}");
            //}






            //var catsWithA = from cat in catNames
            //                where cat.Contains("a")
            //                where cat.Length < 5
            //                select cat;
            //System.Console.WriteLine(string.Join(",", catsWithA));


            //var getTheNumbers = from number in numbers
            //                    where number > 5 
            //                    && number < 10
            //                    orderby number descending
            //                    select number                                ;

            ////List<int> newNumbers = new List<int>();
            ////foreach(var number in numbers)
            ////{
            ////    if (number < 5)
            ////    {
            ////        newNumbers.Add(number);
            ////    }
            ////}
            //System.Console.WriteLine(string.Join(",", getTheNumbers));
            ////System.Console.WriteLine(string.Join(",", newNumbers));

            ////1 Simple LINQ ex
            //var simpleLinq = from s in sentence
            //                 select s;
            //System.Console.WriteLine(string.Join(" ", simpleLinq));




        }
    }
}
