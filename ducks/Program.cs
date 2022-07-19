namespace ducks
{
    internal class Program
    {
        public static void Main()
        {
            DuckComparerBySize duckComparerBySize = new DuckComparerBySize();
            DuckComparerByKind duckComparerByKind = new DuckComparerByKind();
            DuckComparer duckComparer = new DuckComparer() { SortBy = DuckComparer.SortCriteria.KindThenSize };
            var ducks = new List<Duck>()
            {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14},
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13},
            };
            
            
            IEnumerable<Bird> upcastDucks = ducks;
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(upcastDucks);
            birds.Add(new Bird() { Name = "George" });
            foreach(var bird in birds)
            {
                Console.WriteLine(bird);
            }
            Console.WriteLine();
            
            PrintDucks(ducks);
            //ducks.Sort();
            //ducks.Sort(duckComparerBySize);
            //ducks.Sort(duckComparerByKind);
            ducks.Sort(duckComparer);
            PrintDucks(ducks);
            duckComparer.SortBy = DuckComparer.SortCriteria.SizeThenKind;
            ducks.Sort(duckComparer);
            PrintDucks(ducks);
            Console.WriteLine();
            Console.ReadKey();
        }

        public static void PrintDucks(List<Duck> ducks)
        {
            Console.WriteLine("\tLista kaczek:");
            /*            foreach (var duck in ducks)
                        {
                            Console.WriteLine($"* {duck}");
                        }*/
            IEnumerator<Duck> enumerator = ducks.GetEnumerator();
            while(enumerator.MoveNext())
            {
                Duck duck = enumerator.Current;
                Console.WriteLine(duck);
            }
            IDisposable disposable = enumerator as IDisposable;
            if(disposable != null) disposable.Dispose();
            Console.WriteLine();
        }
    }
}