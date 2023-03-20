using System.Threading.Channels;

var g1 = new List<int>() { 10, 25, 20, 30, 4};
var g2 = new List<int>() { 15, 25, 3, 35, 4 };
var g3 = new List<int>() { 10, 15, 20, 25, 40, 50, 4};

// Semih : Tekrar etmeyecek şekilde tüm elemanlar
// dot per line
// O(n) + O(n) + O(n) = c.O(n)
g1
    .Union(g2)
    .Union(g3)
    .ToList();
//.ForEach(n => Console.WriteLine(n));


// Umut Çerkezoğlu: Ortak elemanlar 
// O(n*n*n) = O(n3) 10 * 10 * 10
g1
    .Intersect(g2)
    .Intersect(g3)
    .ToList();
    //.ForEach(n => Console.WriteLine(n));

g1
    .Except(g2)
    .ToList()
    .ForEach(n => Console.WriteLine(n));
   



