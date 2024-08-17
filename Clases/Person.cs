using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_2
{
    internal class Person
    {
        private int idPerson;
        private string firstName;
        private string lastName;
        private int age;
        private int phoneNumber;
        private string email;
        private int height;
        private string gender;

        public Person() { }
        public Person(int cedula, string nombre, string apellido)
        {
            this.idPerson = cedula;
            this.firstName = nombre;
            this.lastName = apellido;
        }

        public Person(int idPerson, string firstName, string lastName, int age, int phoneNumber, string email, int height, string gender)
        {
            this.idPerson = idPerson;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.height = height;
            this.gender = gender;
        }

        public Person(string email)
        {
            this.email = email;
        }

        //Encapsulamiento
        public int IdPerson { get => idPerson; set => idPerson = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public int PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Email { get => email; set => email = value; }
        public int Height { get => height; set => height = value; }
        public string Gender { get => gender; set => gender = value; }

        #region Crear metodos 
        public void ViewData()
        {
            Console.WriteLine("┌────────────────────────────┐");
            Console.WriteLine("│ ** Datos de la persona **  │");
            Console.WriteLine("└────────────────────────────┘");
            Console.WriteLine($"\tIdentificacion -> {idPerson}");
            Console.WriteLine($"\tNombre -> {firstName}");
            Console.WriteLine($"\tApellido -> {lastName}");
            Console.WriteLine($"\tEdad -> {age}");
            Console.WriteLine($"\tEstatura -> {height}");
            Console.WriteLine($"\tGenero -> {gender}");
            Console.WriteLine($"\tCelular -> {phoneNumber}");
            Console.WriteLine($"\tCorreo -> {email}");
            Console.WriteLine("└───────────────────────────────┘");

        }
        public void UpdateGender(string genero)
        {
            this.gender = genero;
        }
        public void UpdateFirstName(string nombre)
        {
            this.firstName = nombre;
        }
        public void UpdateLastName(string apellido)
        {
            this.lastName = apellido;
        }
        public void UpdateAge(int edad)
        {
            this.age = edad;
        }
        public void UpdateHeight(int altura)
        {
            this.Height = altura;
        }
        public void UpdatePhone(int numero)
        {
            this.phoneNumber = numero;
        }
        public void UpdateEmail(string correo)
        {
            this.email = correo;
        }
        public void UpdateId(int id)
        {
            this.idPerson = id;
        }
       
                




        #endregion
    }
}

