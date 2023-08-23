//Instanciar uma ContaCorrente
using Fiap.Banco.Model;
using Fiap.Exercicio01.Exceptions;

var cc = new ContaCorrente()
{
    Agencia = 112,
    Numero = 311,
    Saldo = 0,
    Tipo = TipoConta.Comum,
    DataAbertura = DateTime.Now,

};


//Instanciar uma ContaPoupanca
var cp = new ContaPoupanca(0.6m)
{
    Agencia = 222,
    Numero = 698,
    Saldo = 0121,
    Taxa = 1,
    DataAbertura = DateTime.Now,



};

//Chamar os métodos Depositar

cc.Depositar(1000);
cp.Depositar(5);



Console.WriteLine($"Saldo da conta corrente: {cc.Saldo}");
Console.WriteLine($"Saldo da conta Poupança: {cp.Saldo}");



//Chamar os métodos Retirar

Console.WriteLine("Digite um valor para saque: ");



try
{
var valor = Convert.ToDecimal(Console.ReadLine());

}
catch(SaldoInsuficienteException e)
{
    Console.WriteLine(e.Message);
}
catch(ArgumentException e)
{
    Console.WriteLine(e.Message);
}

cp.Retirar(4);


Console.WriteLine($"Saldo da conta corrente: {cc.Saldo}");
Console.WriteLine($"Saldo da conta Poupança: {cp.Saldo}");