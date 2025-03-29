int idade;

Console.WriteLine("Insira sua idade:");
idade = Convert.ToInt32(Console.ReadLine());

if (idade < 18)
{
    Console.WriteLine("Você ainda é muito novo.");
}
else if (idade < 67)
{
    Console.WriteLine("Você está apto a doar");
}
else
{
     Console.WriteLine("Você não pode ser doador");
}