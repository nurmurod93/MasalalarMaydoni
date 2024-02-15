namespace MasalalarMaydoni
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //InitExample initExample = new InitExample();
            //Console.WriteLine(initExample.YearOfBirth);

            //Person person = new Person { Name = "Nurmurod", Age = 31 };
            //Console.WriteLine($" Ismi: {person.Name}, Yosh: {person.Age}");

            //Myclass myclass = new Myclass();

            //myclass.Name = "Farangiz";
            //myclass.Initializer("Qalandar", 20);

            //myclass.DisplayInfo();

            //Console.WriteLine(myclass.Name);

            //Student student = new Student(registrationNumber: 234 ) { Name = "Gaga"};

            //student.DisplayInfo();


            //int[] sonlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            //foreach (int i in sonlar)
            //{
            //    Console.WriteLine(i);
            //}
            //string[] gaplar = { "C#", "Tilida", "massivlar", "juda", " keng", " qollaniladi" };
            //foreach(string s in gaplar)
            //{
            //    Console.WriteLine(s);
            //}
            //bool[] Javoblar = { true, false, false, false, };
            //foreach(bool s in Javoblar)
            //{
            //    Console.WriteLine(s); 
            //}

            //// Sonli massiv o'zgaruvchilar bilan
            //int[] sonlar1 = new int[5] { 56, 76, 25, 84, 43 };
            //foreach(int raqam in sonlar1)
            //{
            //    Console.WriteLine(raqam);
            //}

            //Jaggad massiv

            //int satr = Convert.ToInt32(Console.ReadLine());
            //int ustun = Convert.ToInt32(Console.ReadLine());

            //int[,] ikiolchovli = new int[satr, ustun];

            //for (int i = 0; i < satr; i++)
            //{
            //    for (int j = 0; j < ustun; j++)
            //    {
            //        Console.Write($"[{i}, {j}] element qiymatini kiriting");
            //        ikiolchovli[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //for (int i = 0; i < satr; i++)
            //{
            //    for (int j = 0; j < ustun; j++)
            //        Console.Write(ikiolchovli[i, j] + "\t");
            //}
            //Console.WriteLine();

            //int[] raqam = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int yigindi = 0;
            //foreach(int son in raqam) 
            //{
            //    yigindi += son;
            //}
            //Console.WriteLine(yigindi);
            List<List<string>> list = new List<List<string>>();
            list.Add(new List<string> { "int", "short", "long", "double", });
            foreach (var item in list) { Console.(item); }

        }
    }
}