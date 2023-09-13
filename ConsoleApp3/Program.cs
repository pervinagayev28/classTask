using ConsoleApp3.Hospitals;

namespace ConsoleApp3
{
    internal class Program
    {
          static   Patient patient = new Patient();
        static void Main(string[] args)
        {
            Pediatriya.doctors.Add(new Doctor("Pervin", "Agayev", 3));
            Pediatriya.doctors.Add(new Doctor("Isa", "Aliyev", 5));
            Pediatriya.doctors.Add(new Doctor("Rubail", "Rehmanli", 2));
            Travmatologiya.doctors.Add(new Doctor("Mehemmed", "Hemzeyev", 7));
            Travmatologiya.doctors.Add(new Doctor("Fazil", "Nebiyev", 6));
            Stamotologiya.doctors.Add(new Doctor("Firudin", "Genceli", 12));
            Stamotologiya.doctors.Add(new Doctor("Bayram", "Nurlu", 9));
            Stamotologiya.doctors.Add(new Doctor("Cahid", "Kaya", 14));
            Stamotologiya.doctors.Add(new Doctor("Kelce", "Kelewov", 5));
            start();
        }
        static void FixWorkHours()
        {
            foreach (var item in Pediatriya.doctors)
                item.show();
            foreach (var item in Travmatologiya.doctors)
                item.show();
            foreach (var item in Stamotologiya.doctors)
                item.show();

            Console.Write("enter doctor Id ");
            int Id = int.Parse(Console.ReadLine());
            Doctor doctor = new();
            foreach (var item in Pediatriya.doctors)
            {
                if (item.Id == Id)
                    doctor = item;
            }
            foreach (var item in Travmatologiya.doctors)
            {
                if (item.Id == Id)
                    doctor = item;
            }
            foreach (var item in Stamotologiya.doctors)
            {
                if (item.Id == Id)
                    doctor = item;
            }
            Console.Write("1 - 09 : 00 - 12 : 00\n2 - 13 : 00 - 15 : 00\n3 - 17 : 00 - 19 : 00\nenter choice: ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                if (doctor.WorkHours.Morning.Name != default)
                {
                    Console.WriteLine("is full");
                    Thread.Sleep(1000);
                    FixWorkHours();
                }
                doctor.WorkHours.Morning= new Patient(patient);
                Console.WriteLine("added");
                Thread.Sleep(1000);
                start();
            }
            else if (choice == 2)
            {
                if (doctor.WorkHours.Afternon.Name != default)
                {
                    Console.WriteLine("is full");
                    Thread.Sleep(1000);
                    FixWorkHours();
                }
                doctor.WorkHours.Afternon = new Patient(patient);
                Console.WriteLine("added");
                Thread.Sleep(1000);
                start();
            }
            else if (choice == 3)
            {
                if (doctor.WorkHours.Evening.Name != default)
                {
                    Console.WriteLine("is full");
                    Thread.Sleep(1000);
                    FixWorkHours();
                }
                doctor.WorkHours.Evening = new Patient(patient);
                Console.WriteLine("added");
                Thread.Sleep(1000);
                start();
            }
        }
        static void start()
        {
            Console.Write("enter name: ");
            patient.Name = Console.ReadLine();
            Console.Write("enter surname: ");
            patient.Surname = Console.ReadLine();
            Console.Write("enter gmail: ");
            patient.Gmail = Console.ReadLine();
          
            FixWorkHours();
            start();


        }
    }
}