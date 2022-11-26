/* Задача 62. Напишите метод, который заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
/*string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
 
// создаем новый список для результатов

var selectedPeople = from p in people // передаем каждый элемент из people в переменную p
                    where p.ToUpper().StartsWith("T") //фильтрация по критерию
                    orderby p  // упорядочиваем по возрастанию
                    select p; // выбираем объект в создаваемую коллекцию
 
foreach (string person in selectedPeople)
    Console.WriteLine(person);
    */
  string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
 
var selectedPeople = people.Where(p => p.ToUpper().StartsWith("T")).OrderBy(p => p);
 
foreach (string person in selectedPeople)
    Console.WriteLine(person);
    