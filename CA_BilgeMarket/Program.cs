
using System.Collections;

namespace CA_BilgeMarket
{
    public class Program
    {
        public static void Main(string[] args)
        {





            string[] Categories = { "Kitap", "Elektronik", "Oyuncak" };
            Console.WriteLine($"Katalog seçiniz. \n1-{Categories[0]}\n2-{Categories[1]}\n3-{Categories[2]}");
            string[] Books = { "Literature", "Philosophy", "Science" };
            string[] Electronics = { "TV's", "PC's", "Smartphones" };
            string[] Toys = { "Cars", "Dolls", "Super Hero" };
            try
            {
                int selection = int.Parse(Console.ReadLine());
                selection = selection - 1;

                ArrayList arrayList = new ArrayList();

                if (selection == 0)
                {
                    Book();

                    Console.WriteLine("Kitap alanını seçiniz.");
                    int bSelection = int.Parse(Console.ReadLine());

                    switch (bSelection)
                    {
                        case 1:
                            Book book1 = new Book();
                            book1.Fiyat = 10;
                            book1.Writer = "Mark Twain";
                            book1.Name = "Advice to Youth";
                            arrayList.Add(book1);
                            break;
                        case 2:
                            Book book2 = new Book();
                            book2.Fiyat = 20;
                            book2.Writer = "Fyodor Dostoyevski";
                            book2.Name = "Crime and Punishment";
                            arrayList.Add(book2);
                            break;
                        case 3:
                            Book book3 = new Book();
                            book3.Fiyat = 30;
                            book3.Writer = "Albert Camus";
                            book3.Name = "The Stranger";
                            arrayList.Add(book3);
                            break;




                    }         
                

                }
                else if (selection == 1)
                {
                    Electronic();
                    Console.WriteLine("Elektronik alanını seçiniz.");
                    int eSelection = int.Parse(Console.ReadLine());

                    switch (eSelection)
                    {
                        case 1:
                            Electronic electronic1 = new Electronic();
                            electronic1.Fiyat = 200;
                            electronic1.Brand = "Sony";
                            electronic1.Type = "TV";
                            arrayList.Add(electronic1);
                            break;
                        case 2:
                            Electronic electronic2 = new Electronic();
                            electronic2.Fiyat = 300;
                            electronic2.Brand = "Apple";
                            electronic2.Type = "PC";
                            arrayList.Add(electronic2);
                            break;
                        case 3:
                            Electronic electronic3 = new Electronic();
                            electronic3.Fiyat = 100;
                            electronic3.Brand = "Samsung";
                            electronic3.Type = "Smartphone";
                            arrayList.Add(electronic3);
                            break;



                    }

                              
                                      
                                      
                   
                }
                else if (selection == 2)
                {
                    Toy();
                    Console.WriteLine("Oyuncak alanını seçiniz.");
                    int tSelection = int.Parse(Console.ReadLine());

                    switch (tSelection)
                    {
                        case 1:
                            Toy toy1 = new Toy();
                            toy1.Fiyat = 12;
                            toy1.Type = "Cars";
                            toy1.Material = "Plastic";
                            arrayList.Add(toy1);
                            break;
                        case 2:
                            Toy toy2 = new Toy();
                            toy2.Fiyat = 15;
                            toy2.Type = "Dolls";
                            toy2.Material = "Plastic";
                            arrayList.Add(toy2);
                            break;
                        case 3:
                            Toy toy3 = new Toy();
                            toy3.Fiyat = 18;
                            toy3.Type = "Batman - Super Hero";
                            toy3.Material = "Wood";
                            arrayList.Add(toy3);
                            break;
                    }                 
                                 
                                                       
                }
                foreach (object item in arrayList)
                {
                    if (item is Book)
                    {
                        Book book = (Book)item;
                        Console.WriteLine("Book Name: " +book.Name+" Writer: " + book.Writer +" Price: "+book.Fiyat +" Price with KDV: " +book.KdvFiyat);
                    }
                    else if (item is Electronic)
                    {
                        Electronic elect = (Electronic)item;
                        Console.WriteLine("Brand: " + elect.Brand + " Type: " + elect.Type + " Price: " + elect.Fiyat + " Price with KDV: " + elect.KdvFiyat);
                    }
                    else if(item is Toy)
                    {
                        Toy toy = (Toy)item;
                        Console.WriteLine("Type: " + toy.Type + " Material: " + toy.Material + " Price: " + toy.Fiyat + "Price with KDV: " + toy.KdvFiyat);
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.Read();


            void Book()
            {
                for (int i = 0; i < Books.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-" + Books[i]);
                }
            }
            void Electronic()
            {
                for (int i = 0; i < Electronics.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-" + Electronics[i]);
                }
            }
            void Toy()
            {
                for (int i = 0; i < Toys.Length; i++)
                {
                    Console.WriteLine((i + 1) + "-" + Toys[i]);
                }
            }

        }
    }
}