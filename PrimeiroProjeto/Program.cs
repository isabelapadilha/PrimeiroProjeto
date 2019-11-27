using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)// declaracao padrao c# ponto de entrada da aplicaçao
        {
            //exemplos de numeros inteiros
            sbyte x = 100;
            byte n1 = 127;
            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            decimal n7 = decimal.MaxValue;// recebe o valor maximo do decimal

            Console.WriteLine(x); //imprime na tela
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n7);


            bool completo = false;// guarda valor true or false
            char generou = 'F';// entre aspas simples ' ' para guardar caractere ((coloquei 'u' na frente pois tava dando conflito de variaveis))  
            float n5 = 4.5f;// quando for ex:4.5 o c# vai entender que é double. Para entender que 4.5 é float precisa por 4.5f.
            double n6 = 4.5;
            string nomeo = "Maria Green"; //representa texto/frase sempre aspas dupla ((coloquei 'o' na frente pois tava dando conflito de variaveis))
            object obj1 = "Alex Brow";// obj é um tipo generico,aceita qualquer coisa

            Console.WriteLine(completo);
            Console.WriteLine(generou);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nomeo);
            Console.WriteLine(obj1);

            //como imprimir variaveis
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); // F2 serve para delimitar o numero de casas, ira imprimir com duas casas decimais
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture));// imprimir com ponto de separacao de decimais ex: 10.3578

            // Placeholders, concatenacao e interpolacao
            //{} são a contagem e as variaveis sao definidas por ordem atraves dessa sequencia placeholders(lugar para entrar variavel)

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo);// placeholders(lugar para entrar variavel)

            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais");// interpolacao

            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais ");// concatenacao

            //EXERCICIO FIXACAO
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";
            //usar variavel idade aqui
            int codigo = 5290;
            //usar variavel genero aqui

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos: " + produto1 + " cuja preco é " + preco1);// concatenacao
            Console.WriteLine($"{produto2}, cuja preco é {preco2}");// interpolacao
            Console.WriteLine("Registro:  {0} anos de idade, codigo {1} e genero {2}:", idade, codigo, genero);//placeholders

            Console.WriteLine("Medida: {0:F8}", medida);// placeholders
            Console.WriteLine($"Arredondado: {medida:F3}");// interpolacao
            Console.WriteLine("Medida:" + medida.ToString("F3", CultureInfo.InvariantCulture));// concatenacao

            //OPERADORES ARITMÉTICOS
            double n10;
            n1 = 3 + 4 * 2;
            n2 = (3 + 4) * 2;
            n3 = 17 % 3;// mostrara o resto da divisao
            n10 = 10.0 / 8.0; // indicar que voce quer uma expressao do tipo double ex:10.0


            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n10);

            //equacao do 2º grau
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;// entendesse os parentes que b será elevado ao quadrado

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);//raiz quadrada de delta, obrigatorio colocar parentese pelo motivo de precedencia da divisao e multiplicacao

            Console.WriteLine(delta);
            Console.WriteLine(x1);

            //OPERADORES DE ATRIBUICAO
            int numero = 10;
            Console.WriteLine(numero);

            numero += 2;// numero somado 2
            Console.WriteLine(numero);

            numero *= 3;// numero * 3
            Console.WriteLine(numero);

            //CONVERSAO E CASTING

            double d;
            float y;

            d = 5.1;
            y = (float)d;//estou fazendo a conversao para float aceitar o conteudo double


            //ENTRADA DE DADOS

            string frase = Console.ReadLine();// espera o usuario digitar e dar o enter
            string letra1 = Console.ReadLine();
            string letra2 = Console.ReadLine();
            string letra3 = Console.ReadLine();

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(frase);//mostra no console oque o usuario digitou
            Console.WriteLine(letra1);
            Console.WriteLine(letra2);
            Console.WriteLine(letra3);

            //COMANDO SPLIT
            string s = Console.ReadLine();// irá ler a linha inteira do que for digitado 

            string[] v = s.Split(' ');// o split ira identificar os espaço entre as palavras e ira alocar nas posicoes do vetor
            string v1 = v[0];
            string v2 = v[1];
            string v3 = v[2];

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(v1);
            Console.WriteLine(v2);
            Console.WriteLine(v3);


            int numero1 = int.Parse(Console.ReadLine());// como o ReadLine lê string, nesse caso teremos que converter
            char ch = char.Parse(Console.ReadLine());// como é char tambem tera que converter
            double numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);// converteu o double

            Console.WriteLine("Voce digitou: ");
            Console.WriteLine(numero1);
            Console.WriteLine(ch);
            Console.WriteLine(numero2.ToString("F2", CultureInfo.InvariantCulture));

            //EXERCICIO DE FIXACAO
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeExec = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int qtdeQuarto = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Entre com o preço do produto: ");
            double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            //SPLIT DO EXERCICIO
            Console.WriteLine("Entre com seu ultimo nome, idade e altura");
            string[] e = Console.ReadLine().Split(' ');// o split ira identificar os espaço entre as palavras e ira alocar nas posicoes do vetor
            string ultimoNome = e[0];
            string cor = e[1];
            int idadeExec = int.Parse(e[2]);
            double altura = double.Parse(e[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nomeExec);
            Console.WriteLine(qtdeQuarto);
            Console.WriteLine(precoProduto.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idadeExec);
            Console.WriteLine(altura.ToString("F2",CultureInfo.InvariantCulture));








        }
    }
}
