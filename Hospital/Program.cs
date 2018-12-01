using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
   
    class Program
    {
        static void Main(string[] args)
        {
            Action obj = new Action();

            obj.ActPatientChoice();








        }

    }

    class Action
    {
        public void ActPatientChoice()
        {

            Sector Pediatria = new Sector();
            Sector Travmato = new Sector();
            Sector Stomo = new Sector();

            Doctors objDoc = new Doctors();

            int shiftStatus1 = 0;
            int shiftStatus2 = 0;
            int shiftStatus3 = 0;



            Pediatria.Dlist.Add(new Doctors("Aga", "Agayev", 10));
            Pediatria.Dlist.Add(new Doctors("Tarlan", "Shahinov", 11));
            Pediatria.Dlist.Add(new Doctors("Murtuz", "Pulsuzov", 12));

            Travmato.Dlist.Add(new Doctors("Ali", "Aliyev", 10));
            Travmato.Dlist.Add(new Doctors("Vali", "Valiyev", 11));
            Travmato.Dlist.Add(new Doctors("Quli", "Quliyev", 12));

            Stomo.Dlist.Add(new Doctors("Haji", "Hajiyev", 10));
            Stomo.Dlist.Add(new Doctors("Parviz", "Pulvarov", 11));
            Stomo.Dlist.Add(new Doctors("Kamran", "Karvanov", 12));

            for (; ; )
            {
                Console.WriteLine();
                Console.Clear();
                Console.WriteLine("Please choose SECTOR of doctor");
                Console.WriteLine();
                Console.WriteLine("Press 1 - for Pediatry");
                Console.WriteLine();
                Console.WriteLine("Press 2 - for Travmatology");
                Console.WriteLine();
                Console.WriteLine("Press 3 - for Stomotology");
                Console.WriteLine();
                Console.WriteLine("Press any other figure to leave site");
                Console.WriteLine();

                int sectorChoice = Int32.Parse(Console.ReadLine());

                switch (sectorChoice)
                {
                    case 1:

                        Console.Clear();
                        Console.WriteLine();

                        for (int i = 0; i < Pediatria.Dlist.Count; i++)
                        {
                            Console.WriteLine($" {i + 1}. { Pediatria.Dlist[i].Name}  { Pediatria.Dlist[i].Surname} , { Pediatria.Dlist[i].Experience}");
                        }


                        Console.WriteLine();
                        Console.WriteLine("Chose the Doctor you want by pressing 1 , 2 or 3");

                        int doktorChoice = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Please choose the shift of doctor you want from the list");
                        Console.WriteLine();
                        Console.WriteLine();
                      
                       
                        if (shiftStatus1 == 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , NOT RESERVED");
                        }
                        else if (shiftStatus1 > 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus2 == 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , NOT RESERVED");
                        }
                        else if (shiftStatus2 > 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus3 == 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , NOT RESERVED");
                        }
                        else if (shiftStatus3 > 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        Console.WriteLine("Chose the Shift you want by pressing 1 , 2 or 3");
                        Console.WriteLine();
                        int shiftChoice = Int32.Parse(Console.ReadLine());

                        switch (shiftChoice)
                        {
                            case 1:

                                shiftStatus1++;

                                break;

                            case 2:

                                shiftStatus2++;

                                break;

                            case 3:

                                shiftStatus3++;

                                break;

                            default:

                                Console.WriteLine("Wrong shift choice"); Console.ReadKey();
                                break;

                        }

                        if (shiftStatus1 ==1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is {Pediatria.Dlist[0].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[0]}");
                            Console.WriteLine();
                            Console.ReadKey();
                        
                        }

                        else if (shiftStatus2 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Pediatria.Dlist[1].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[1]}");
                            Console.WriteLine();
                            Console.ReadKey();
                     
                        }

                        else if (shiftStatus3 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Pediatria.Dlist[2].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[2]}");
                            Console.WriteLine();
                            Console.ReadKey();
                        
                        }

                        break;

                    case 2:

                        Console.Clear();
                        Console.WriteLine();

                        for (int i = 0; i < Travmato.Dlist.Count; i++)
                        {
                            Console.WriteLine($" {i + 1}. { Travmato.Dlist[i].Name}  { Travmato.Dlist[i].Surname} , {Travmato.Dlist[i].Experience}");
                        }


                        Console.WriteLine();
                        Console.WriteLine("Chose the Doctor you want by pressing 1 , 2 or 3");

                        int doktor2Choice = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Please choose the shift of doctor you want from the list");
                        Console.WriteLine();
                        Console.WriteLine();


                        if (shiftStatus1 == 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , NOT RESERVED");
                        }
                        else if (shiftStatus1 > 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus2 == 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , NOT RESERVED");
                        }
                        else if (shiftStatus2 > 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus3 == 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , NOT RESERVED");
                        }
                        else if (shiftStatus3 > 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        Console.WriteLine("Chose the Shift you want by pressing 1 , 2 or 3");
                        Console.WriteLine();
                        int shiftChoice2 = Int32.Parse(Console.ReadLine());

                        switch (shiftChoice2)
                        {
                            case 1:

                                shiftStatus1++;

                                break;

                            case 2:

                                shiftStatus2++;

                                break;

                            case 3:

                                shiftStatus3++;

                                break;

                            default:

                                Console.WriteLine("Wrong shift choice"); Console.ReadKey();
                                break;

                        }

                        if (shiftStatus1 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is {Travmato.Dlist[0].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[0]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        else if (shiftStatus2 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Travmato.Dlist[1].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[1]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        else if (shiftStatus3 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Travmato.Dlist[2].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[2]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        break;

                    case 3:

                        Console.Clear();
                        Console.WriteLine();

                        for (int i = 0; i < Pediatria.Dlist.Count; i++)
                        {
                            Console.WriteLine($" {i + 1}. { Stomo.Dlist[i].Name}  {Stomo.Dlist[i].Surname} , { Stomo.Dlist[i].Experience}");
                        }


                        Console.WriteLine();
                        Console.WriteLine("Chose the Doctor you want by pressing 1 , 2 or 3");

                        int doktorChoice3 = Int32.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Please choose the shift of doctor you want from the list");
                        Console.WriteLine();
                        Console.WriteLine();


                        if (shiftStatus1 == 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , NOT RESERVED");
                        }
                        else if (shiftStatus1 > 0)
                        {
                            Console.WriteLine($" {1}. {objDoc.WorkingHours[0]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus2 == 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , NOT RESERVED");
                        }
                        else if (shiftStatus2 > 0)
                        {
                            Console.WriteLine($" {2}. {objDoc.WorkingHours[1]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        if (shiftStatus3 == 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , NOT RESERVED");
                        }
                        else if (shiftStatus3 > 0)
                        {
                            Console.WriteLine($" {3}. {objDoc.WorkingHours[2]} , RESERVED");
                            Console.WriteLine("Please choose another shift, this Shift is Busy");
                        }

                        Console.WriteLine("Chose the Shift you want by pressing 1 , 2 or 3");
                        Console.WriteLine();
                        int shiftChoice3 = Int32.Parse(Console.ReadLine());

                        switch (shiftChoice3)
                        {
                            case 1:

                                shiftStatus1++;

                                break;

                            case 2:

                                shiftStatus2++;

                                break;

                            case 3:

                                shiftStatus3++;

                                break;

                            default:

                                Console.WriteLine("Wrong shift choice"); Console.ReadKey();
                                break;

                        }

                        if (shiftStatus1 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is {Stomo.Dlist[0].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[0]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        else if (shiftStatus2 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Stomo.Dlist[1].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[1]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        else if (shiftStatus3 == 1)
                        {
                            Console.WriteLine("You have registered successfully");
                            Console.WriteLine($"Your doctor is { Stomo.Dlist[2].Name}");
                            Console.WriteLine($"Your doctor is {objDoc.WorkingHours[2]}");
                            Console.WriteLine();
                            Console.ReadKey();

                        }

                        break;

                    default:

                        goto Label;
            
                }

            }
        Label: Console.WriteLine("Thanks for choosing us");

        }




        class Doctors
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Experience { get; set; }

            public Doctors() { }

            public List<string> WorkingHours = new List<string>()
        {
            "09:00-11:00","12:00-14:00","15:00-17:00"
        };

            public Doctors(string name, string surname, int experience)
            {
                Name = name;
                Surname = surname;
                Experience = experience;
            }

            public Doctors(string name, string surname, int experience, List<string> workingHours) : this(name, surname, experience)
            {
                WorkingHours = workingHours;
            }
        }

        class Patient
        {
            public string Pname { get; set; }
            public string Psurname { get; set; }
            public string Pemail { get; set; }
            public string Ptelefon { get; set; }

            Patient(string pname, string psurname, string pemail, string ptelefon)
            {
                Pname = pname;
                Psurname = psurname;
                Pemail = pemail;
                Ptelefon = ptelefon;
            }

        }

        class Sector
        {
            public List<Doctors> Dlist = new List<Doctors>();
        }

    }
}


