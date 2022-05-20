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
            if (person.getName() == null)
            {
                do
                {
                    Console.WriteLine("Ops!Digite seu nome por favor: ");
                    person.setName(Console.ReadLine());
                }while (person.getName() != null);
            }
            Console.WriteLine("Digite seu CPF:");
            person.setCpf(Console.ReadLine());
            if (person.getCpf == null)
            {
                do
                {
                    Console.WriteLine("Ops! Por favor, digite novamente seu Cpf: ");
                    person.setCpf(Console.ReadLine());
                }while (person.getCpf() != null);
            }
            
            float wash = 50;
            Console.WriteLine("Custa 50 reais :D");
            person.setToPay(wash);
            Animal pet = new Animal();
            Console.WriteLine("Qual a raca do seu PET?");
            pet.setSpecies(Console.ReadLine());
            if (pet.getSpecies == null)
            {
                do
                {
                    Console.WriteLine("Ops!Por favor, diga novamente qual a raca do seu animal: ");
                    pet.setSpecies(Console.ReadLine());
                }while(pet.getSpecies() != null);
            }

            Console.WriteLine("Como ele se chama?");
            pet.setName(Console.ReadLine());
            if (pet.getName() == null)
            {
                do
                {
                    Console.WriteLine("Digite o nome do seu pet, por favor...");
                } while (pet.getName() == null); 
            }
            Console.WriteLine("Femea ou Macho?");
            pet.setGender(Console.ReadLine());
            if (pet.getGender() == null)
            {
                do
                {
                    Console.WriteLine("Ops! Por favor informe o sexo do seu animal: ");
                    pet.setGender(Console.ReadLine());
                } while (pet.getGender() == null);
            }
        }
    }
}