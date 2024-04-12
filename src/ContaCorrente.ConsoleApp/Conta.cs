using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace ContaCorrente.ConsoleApp
{
    //    Uma conta corrente possui um número, um saldo, um status que informa se ela é especial ou não,
    //    um limite e um conjunto de movimentações.Uma movimentação possui um valor e uma informação se ela é uma movimentação de crédito ou débito. 

    //Cada conta terá operações de saques, depósitos, visualização de saldo, visualização de extrato e transferência entre contas.
    //    Cada conta vai ter o nome, o sobrenome e cpf do cliente dono da conta.

    //Uma conta corrente só pode fazer saques desde que o valor não exceda o limite de saque que é o limite + saldo.
    //    Não precisa implementar a interação com usuário.


    public class Conta
    {
        public double NumeroConta { get; set; }
        public decimal LimiteConta { get; set; }
        public decimal Saldo { get; set; }
        public DadosUsuario dadosUsuario { get; set; }

        public decimal MostrarSaldo()
        {
            return Saldo;
        }
        public void Transferir(Conta destino, decimal ValorTransferencia)
        {
            if (Saldo >= ValorTransferencia)
            {
                destino.Depositar(ValorTransferencia);
                Sacar(ValorTransferencia);
            }
            else Console.WriteLine("Valor Insuficiente!");
        }
        public void Depositar(decimal ValorDeposito)
        {
            Saldo += ValorDeposito;
        }
        public void Sacar(decimal ValorSaque)
        {
            if (ValorSaque <= Saldo)
                Saldo -= ValorSaque;
            else if (ValorSaque <= LimiteConta)
            {
                LimiteConta -= ValorSaque;
                Console.WriteLine($"A operação foi realizada no Crédito, limite atual: {LimiteConta}");
            }
            else
                Console.WriteLine("Limite Insuficiente!");
        }
        public string Ehespecial()
        {
            if (LimiteConta >= 5000)
            {
                return "CONTA ESPECIAL";
            }
            else
                return "CONTA PADRÃO";
        }

    }
}
