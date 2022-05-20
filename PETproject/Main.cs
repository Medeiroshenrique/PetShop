using System;

namespace Petshop
{
    class Principal
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Bem vindo ao PETProject!");
            Console.WriteLine("Como se chama?");
            Client person = new Client();
            person.setName(Console.ReadLine());
            Console.WriteLine("Digite seu CPF:");
            person.setCpf(Console.ReadLine());           
            float wash = 50;
            Console.WriteLine("Custa 50 reais :D");
            person.setToPay(wash);
            Animal pet = new Animal();
            Console.WriteLine("Qual a raca do seu PET?");
            pet.setSpecies(Console.ReadLine());
            Console.WriteLine("Como ele se chama?");
            pet.setName(Console.ReadLine());
            Console.WriteLine("Femea ou Macho?");
            pet.setGender(Console.ReadLine());
           
        }
    }
}