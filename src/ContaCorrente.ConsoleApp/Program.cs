﻿using System.Security.Cryptography;

namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.NumeroConta = 1001;
            conta1.LimiteConta = 250;
            conta1.Saldo = 2500;

            conta1.dadosUsuario = new DadosUsuario()
            {
                CPF = "10155226898",
                NomeUsuario = "Lucas Thiesen"
            };

            Conta conta2 = new Conta();
            conta2.NumeroConta = 1002;
            conta2.LimiteConta = 6000;
            conta2.Saldo = 1000;

            conta2.dadosUsuario = new DadosUsuario()
            {
                CPF = "20255226898",
                NomeUsuario = "Maria Eduarda"
            };

            Console.WriteLine($"Bem vindo de volta: {conta1.dadosUsuario.NomeUsuario}");
            Console.WriteLine($"Confirme o seu CPF: {conta1.dadosUsuario.CPF}");
            Console.WriteLine($"O status da sua conta é: {conta1.Ehespecial}");
            Console.WriteLine($"O saldo atual é de: {conta1.Saldo}");
            Console.WriteLine("Realizando um depósito de R$500,00");
            conta1.Depositar(500);
            Console.WriteLine($"O saldo atual é de:  {conta1.Saldo}");
            Console.WriteLine("Realizando um saque de 1354");
            conta1.Sacar(3000);
            Console.WriteLine($"O saldo atual é de: {conta1.Saldo}");
            Console.WriteLine("Sacando acima do limite: ");
            conta1.Sacar(200);
            Console.WriteLine($"O saldo atual é de: {conta1.Saldo}");
            //ver se a conta 2 acima do valor especial retorna que é especial...
            Console.WriteLine($"Bem vindo de volta: {conta2.dadosUsuario.NomeUsuario}");
            Console.WriteLine($"Confirme o seu CPF: {conta2.dadosUsuario.CPF}");
            Console.WriteLine($"O status da sua conta é: {conta2.Ehespecial}");
            Console.WriteLine($"O saldo atual da ac1 é de:  {conta1.Saldo}");
            Console.WriteLine($"O saldo atual da ac2 é de:  {conta2.Saldo}");
            Console.WriteLine("Maria transferiu 500 para Lucas: ");
            conta2.Transferir(conta1, 500);
            Console.WriteLine($"O saldo atual de Lucas é de:  {conta1.Saldo}");
            Console.WriteLine($"O saldo atual da Maria é de:  {conta2.Saldo}");
            Console.ReadKey();


        }
    }
}
