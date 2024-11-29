

List<int> scores = [4522,55,66,88,99,01,3333,67];

//IEnumerable<string> scoreQuery = 
//  from score in scores
//   where score > 80
//    orderby score descending
//    select  $"La puntuacion es {score}";

var scoreQuery2 = scores.Where(score => score > 80).OrderByDescending(s => s);
//Console.WriteLine(scoreQuery.Count());

List<int> miPuntuacion = scoreQuery2.ToList();

foreach (var score in miPuntuacion){
    Console.WriteLine(score + " "); 
}


Console.WriteLine();
