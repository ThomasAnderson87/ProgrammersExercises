/*
int a = 10;
int b = 20;
int c = 30;

Console.WriteLine($"a é igual a b? {a == b}");
Console.WriteLine($"a é diferente a b? {a != b}");
Console.WriteLine($"a é maior que b? {a > b}");
Console.WriteLine($"a é menor que b? {a < b}");
Console.WriteLine($"a é maior ou igual a b? {a >= b}");
Console.WriteLine($"a é menor ou igual a b? {a <= b}");
Console.WriteLine($"a e b são maiores que c? {(a && b) > c}");
*/

/*
int age = int.Parse(Console.ReadLine());

Console.WriteLine($"É permitido tirar a habilitação? {age >= 18}")
*/


/*
int age = 1;

while(age < 18)
{
    Console.WriteLine($"Sua idade é {age}, você ainda não pode tirar sua habilitação.");
    age++;
}

Console.WriteLine($"Sua idade é {age}, agora você pode tirar sua habilitação");
*/

Console.WriteLine("Digite a nota que deseja consultar");
float score = float.Parse(Console.ReadLine());

if (score < 5)
{
    Console.WriteLine($"Sua nota é {score}, você está reprovado.");
}
else if(score >= 5 && score < 7)
{
    Console.WriteLine($"Sua nota é {score}, você está em recuperação.");
}
else
{
    Console.WriteLine($"Sua nota é {score}, você está aprovado.");
}

var result = score > 7 ? "aprovado" : "reprovado";
Console.WriteLine($"Você está {result}");