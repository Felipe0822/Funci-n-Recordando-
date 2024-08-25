using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> emails = new List<string>();
            Person person1 = new Person(1234, "Pipe", "Rincon", 21, 1312442421, "pipe@gmail.com", 176, "Male");
            ActualizarDatos(person1, emails);
        }
        static void ActualizarDatos(Person person1, List<string> emails)
        {
            int eleccion = 0;
            int actu = 0;

            Console.WriteLine("Desea actulizar datos\n1.Si, 2.No");
                string accion = Console.ReadLine();
                if (int.TryParse(accion, out eleccion))
                {
                    while (eleccion == 1)
                    {
                        person1.ViewData();
                    Console.WriteLine("Otros emails guardados:");
                    foreach (string mails in emails)
                    {
                        Console.WriteLine(mails);
                    }
                    Console.WriteLine("Que desea actualizar? 1:ID, 2:Nombre, 3:Apellido, \n4:Genero, 5:Edad, 6:Numero de telefono," +
                            " 7:Reemplazar Email principal, 8:Agregar Email, 9:Altura");
                        actu = int.Parse(Console.ReadLine());
                        if (actu == 1)
                        {
                            Console.WriteLine("Ingrese la nueva ID");
                            person1.UpdateId(int.Parse(Console.ReadLine()));
                            person1.ViewData();
                        }
                        else if (actu == 2)
                        {
                            Console.WriteLine("Ingrese el nuevo nombre");
                            person1.UpdateFirstName(Console.ReadLine());
                            person1.ViewData();
                        }
                        else if (actu == 3)
                        {
                            Console.WriteLine("Ingrese el nuevo apellido");
                            person1.UpdateLastName(Console.ReadLine());
                            person1.ViewData();
                        }
                        else if (actu == 4)
                        {
                            Console.WriteLine("Ingrese el nuevo genero");
                            person1.UpdateGender(Console.ReadLine());
                            person1.ViewData();
                        }
                        else if (actu == 5)
                        {
                            Console.WriteLine("Ingrese la nueva edad");
                            person1.UpdateAge(int.Parse(Console.ReadLine()));
                            person1.ViewData();
                        }
                        else if (actu == 6)
                        {
                            Console.WriteLine("Ingrese el nuevo numero de telefono");
                            person1.UpdatePhone(int.Parse(Console.ReadLine()));
                            person1.ViewData();
                        }
                        else if (actu == 7)
                        {
                            Console.WriteLine("Ingrese el nuevo email principal, este eliminara el anterior");
                            person1.UpdateEmail(Console.ReadLine());
                            person1.ViewData();
                        }
                        else if (actu == 8)
                        {
                            Console.WriteLine("Ingrese el nuevo email");
                            emails.Add(Console.ReadLine());
                            Console.WriteLine("Tiene los siguientes correos añadidos:");
                            foreach (string mails in emails)
                            {
                                Console.WriteLine(mails);
                            }

                        }
                        else if (actu == 9)
                        {
                            Console.WriteLine("Ingrese la nueva altura");
                            person1.UpdateHeight(int.Parse(Console.ReadLine()));
                            person1.ViewData();
                        }
                        Console.WriteLine("Desea actualizar datos\n1.Si, 2.No");
                        eleccion = int.Parse(Console.ReadLine());
                    }
                }
            
           
        }
    }
}

