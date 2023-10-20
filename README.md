# 💻 Programando em 'C#'

![Logo CSharp](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white "Logo CSharp")

> _Material de estudos para desenvolvimento na linguagem C#_

[Fundamentos do C#](https://balta.io/player/assistir/5ef614da-366d-6156-d049-694800000000) por [Andre Baltieri](https://github.com/andrebaltieri) da [balta.io](https://github.com/balta-io)

## 🪛 Estrutura base 👇

```csharp
using System;

namespace MeuApp
{
  class Program
  {
    static void Main(string[] args)
    {
      console.WriteLine('Hello, World!');
    }
  }
}
```

## 📙 Definições

### • Importações

_Utilizamos a palavra chave `using` para definir as importações que serão feitas dentro de um arquivo._

### • Namespace

_Serve para criar uma divisão lógica dentro de um arquivo. Geralmente os `Namespaces` acompanham o nome da página. Assim como não podemos ter dois arquivos com o mesmo nome dentro de uma pasta, também não podemos ter dois `Namespaces` com o  mesmo nome dentro de um arquivo._

### • Variáveis

_É um dado que é instanciado (criado, inicializado, etc), e do qual atribuímos um valor para depois utilizar em algum trecho do nosso código. Por "variável" entendemos que seu valor não é imutável, portanto pode ser alterado._

↓ Exemplo ↓

```csharp
int idade;
int idade = 25;
var idade = 25;
var idade; // esse exemplo está errado, pois não atribuímos um valor nem inferimos o tipo da variável. devemos sempre inferir o tipo, ou no caso de "var", atribuir um valor.
```

### • Constantes

_Diferente de uma variável, os valores das constantes são inalteráveis. Uma vez que a gente atribui um valor à constante em sua inicialização, o valor dela não pode mais ser alterado. Elas não funcionam com a palavra chave `var` e são mais otimizadas que as variáveis._

_Por convenção é comum vermos as constantes sempre escritas com letras maiúsculas separadas por undescore. Ex: `"IDADE_MINIMA"`._

```csharp
const int IDADE_MINIMA = 25;
```

### 🍰 Tipos Primitivos (built-in types)

_Os tipos primitivos possuem uma capacidade. Por exemplo, os tipos `int` vão do número `-2.147.483.648` até o número `2.147.483.647` (caso a gente atribua um valor que fuja desse intervalo receberemos um erro)._

#### São classificados em 👇

* Tipos simples (simple types);
* Enumeradores (enums);
* Estruturas (structs);
* Tipos nulos (nullable types)

#### → System

_No .NET tudo começa de um tipo base chamado `system`. Todos os tipos derivam dele. Seu uso já é implicito e todos os objetos, variáveis e constantes._

#### → Byte

_O tipo `byte` é usado para representar um byte de fato. Seu valor vai de 0 até 255 (8-bit)._

#### → Números Inteiros

_São números sem pontuação podendo ser curtos, médios ou longos. Utilizamos a notação `unsigned` para definir que as variáveis não podem receber valores negativos._

* short/ushort (16-bit)
* int/uint (32-bit)
* long/ulong (64-bit)

#### → Número Reais

_São números que possuem casas decimais. Para isso usamos o float, o double ou o decimal._

* float (32-bit | notação F)
* double (64-bit)
* decimal (128-bit | notação M)

_A diferença entre o uso dos tipos acima está na precisão de casas decimais._

#### → Boolean

_Utiliza `8-bits` de memória e armazena `true` ou `false`. Usamos a palavra chave `bool` para inferir este tipo._

#### → Char

_Utilizado para armazenarmos um único caractere (unicode). É definido pela palavra chave `char` e a inferência de valor se dá pelas aspas simples. Ocupa 16-bit de memória._

#### → String

_Armazena uma cadeia de caracteres (um conjunto de chars). É definido pela palavra chave `string` e a inferência de valor se dá pelas aspas duplas. O espaço em memória é definido pelo tamanho da `string`._

#### → Var

_Infere dinamicamente o tipo da variável de acordo com o valor atribuído à ele. Por exemplo, se atribuírmos o valor `25` à uma variável, logo o tipo inferido será `int`. Logo após essa definição dinâmica, não é possível alterar o tipo da variável._

#### → Object

_É similar ao `"any"` do `Typescript`. É um tipo genérico que recebe qualquer valor ou objeto e que não ativa o `intelisense` dos editores por ser um tipo desconhecido. Na dúvida, evite usa-lo._

#### → Nullable Types

_Diferente de uma string vazia, o `null` significa vazio, nada. Todo tipo primitivo ou complexo pode receber o valor `null`. Para isso deverá ser marcado como `Nullable Type` 👇._

```csharp
int? idade = null;
```

#### → Alias

_Alias é o apelido que todo tipo .NET tem. Por exemplo, `System.String` tem o alias `string`._

```csharp
int idade = 25; // Alias
Int32 idade = 25; // Tipo
```

#### → Valores padrão (built-in)

_Todo tipo `built-in` já possui um valor padrão. Caso não seja atribuído nenhum valor à variável, ela adoratá os valores abaixo 👇_

* int → 0
* float → 0
* decimal → 0
* bool → false
* char → '\0'
* string → ""

### 🦎 Conversões

#### → Conversão Implícita

_É comum transformarmos os tipos de uma determinada variável. Para isso podemos usar as `Conversões Implícitas` que podem ser executadas com passagem de dados dos quais os tipos são compatíveis. Por exemplo:_

```csharp
float valor = 25.8F;
int outro = 25
valor = outro // Conversão Implícita

```

_Essa conversão acima só ocorre pois um número real pode receber um número inteiro. Porém o contrário não aconteceria._

#### → Conversão Explícita

_Ocorre quando os tipos não são compatíveis. É dada pelo uso do tipo entre parênteses antes da atribuição. Segue as mesmas regras anteriores._

```csharp
int inteiro = 100;
uint inteiroSemSinal = (uint)inteiro; // Conversão Explícita

```

#### → Parse

_Toda variável do tipo `built-in` possui métodos chamados de `Parse`. Esses métodos são usados para converter um caractere ou string para um outro tipo qualquer. Caso haja alguma incompatibilidade, gerará um erro._

> Obs.: O `Parse` converte somente strings

```csharp
string valor = "100";
int inteiro = int.Parse(valor);

```

#### → Convert

_Ao contrário do `Parse`, o `Convert` é um objeto que possui métodos próprios de conversão, podendo converter vários tipos de valores e não apenas strings._

```csharp
string valor = "100";
int inteiro = Convert.ToInt32(valor);

```

### 🩺 Operações

#### → Operadores Aritméticos

* Soma → +
* Subtração → -
* Multiplicação → *
* Divisão → /
* Resto → %

_Aceitam todos os valores numéricos (short, int, decimal, float e double)._

> Obs.: Caso eu realize uma operação onde minha variável é do tipo `int`, porém o resultado da minha operação possui números decimais, meu resultado desconsiderará os valores depois da vírgula. Para ter precisão em minhas operações é preciso estar atento ao tipo da variável.

#### → Operadores de Atribuição

_Utilizamos `"="` para atribuir um valor à uma variável ou constante, porém, podemos utilizar uma combinação de `"="` junto de um operador aritmético, como por exemplo:_
> `x += 5` é o mesmo que `x = x + 5`

```csharp
int x = 0; // Inicialização e atribuição
x += 5; // resultado → 5
x -= 1; // resultado → 4
x *=10; // resultado → 40
x /= 2; // resultado → 20 
x++; // resultado → 21 (incremento)
x--; // resultado → 20 (decremento)
x % 3; // resultado → 2
```

#### → Operadores de Comparação

_Podemos comparar qualquer tipo de dados. A comparação sempre retorna `true` ou `false`_

* Igual `==`
* Diferente `!=`
* Maior que `>`
* Menor que `<`
* Maior ou igual que `>=`
* Menor ou igual que `<=`

#### → Operadores Lógicos

_Sempre retorna `verdadeiro` ou `falso`._

* AND → &&
* OR → ||
* NOT → !

#### → Operadores Condicionais

_Utilizado o `if` e `else` para tomadas de decisões. Utilizamos os operadores lógicos para compor uma condição._

_Podemos também utilizar o `switch`, conforme exemplo abaixo 👇_

```csharp
/*
• utilizado quando temos muitas decisões
• executado em cascata
• devemos parar a execução com o break
• possui uma execução padrão chamada default
*/

int valor = 1;
switch (valor)
{
  case 1: Console.WriteLine("1"); break;
  case 2: Console.WriteLine("2"); break;
  case 3: Console.WriteLine("3"); break;
  default: Console.WriteLine("4"); break;
}
```

### ➰ Laços de Repetição

_Servem para percorrermos uma determinada lista e criar manipulações, utilizar os dados ou criar novas listas._

#### → For

```csharp
for (var i = 0; i <= 5; i++)
```

#### → While

```csharp
while (valor <= 5)
{
  Console.WriteLine(valor);
  valor++;
}
```

#### → Do/While

```csharp
do
{
  Console.WriteLine(valor);
  valor++;
} while (valor < 5);
```

### 🐕‍🦺 Funções e Métodos

_Podemos segmentar nosso programa em `functions` também conhecidos como `methods`. O `main` é um exemplo de `method`. As funções e métodos possuem retorno, nome e parâmetros._

```csharp
static void Main(string[] args)
{
  // Invocação do método
  MeuMetodo("C# is nice");
}

// Definição do método
static void MeuMetodo(string parametro)
{
  Console.WriteLine(parametro);
}
```

**Obs.:**

1. Não conseguimos criar um método dentro de uma outra função em `C#`. Caso queiramos executar um método dentro de uma função, precisamos criar ela fora do escopo e depois instanciá-lo (caso ele não seja `static`).
2. Quando identificamos um método como `static` estamos dizendo que ele não precisa ser instanciado, podendo então ser chamado diretamente.
3. Quando criamos uma função, sempre colocamos o retorno dela no início do método:

```csharp
// nesse caso o método não retornará nada
static void MeuMetodo() {...}

// nesse caso o método retornará uma string
static string RetornaString() {...}

// nesse caso o método retorna um número e precisa ser instanciado

int RandomNumber() {...}
```

### Value Types e Reference Types

_A memória é dividida entre `Stack` e  `Heap`._

[Artigo - Gerenciamento de memória no C#: stack, heap, value-types e reference-types](https://www.treinaweb.com.br/blog/gerenciamento-de-memoria-no-c-stack-heap-value-types-e-reference-types)

#### → Stack

> Porção de memória pequena onde os value-types e os `ponteiros` ficam;

#### → Heap

> Porção maior de memória onde os reference-types ficam de fato alocados… Para se fazer o acesso a eles, precisamos de um `ponteiro` na stack que indique a posição de memória na heap onde o objeto está de fato alocado.

#### → Value-Types

> São tipos leves (como os tipos primitivos e structs) que ficam armazenados diretamente na memória stack. Os valores das variáveis ficam armazenados juntamente com as próprias variáveis, sendo o acesso ao seu conteúdo feito de maneira direta

#### → Reference-Types

> Tipos pesados (objetos criados a partir de classes, etc.) que ficam armazenados na heap. Para não sacrificar a performance, é criada uma referência (`ponteiro`) na `stack` que aponta para qual posição de memória o objeto está armazenado na `heap`. O acesso é feito via essa referência na `stack`. Sendo assim, o acesso ao conteúdo é indireto, dependendo dessa referência;

```bash
→ Resumidamente, Built-in, Structs e Enuns são salvos na Stack. Objetos, Classes e Arrays são salvos no Heap, porém são consultados através de uma referência salva na Stack.

→ Quando atribuímos uma variável à outra varíavel de tipo primitivo, criamos uma cópia do valor naquele momento da respectiva variável.

→ Quando criamos uma instância ou atribuímos um valor à outro array ou objeto, atribuímos o valor à referência. Sendo assim, se meu valor do objeto ou array ser alterado, a variável atribuída também será alterada pois estou usando sua referência.
```

```csharp
// Value-Types

static void Main(string[] args)
{
  int x = 25;
  int y = x;

  Console.WriteLine(x); // 25
  Console.WriteLine(y); // 25

  x = 32

  Console.WriteLine(x); // 32
  Console.WriteLine(y); 
  
  // ☝️ o valor continua 25 pois foi realizada uma cópia do valor da variável x naquele momento, e não uma referência
}

```

```csharp
// Reference-Types

static void Main(string[] args)
{
  var arr = new string[2];
  arr[0] = "Item 1";

  var arr2 = arr;

  Console.WriteLine(arr[0]); // "Item 1"
  Console.WriteLine(arr2[0]); // "Item 1"

  arr[0] = "Item 0";

  Console.WriteLine(arr[0]); // "Item 0"
  Console.WriteLine(arr2[0]); // "Item 0"

/*

Ambas as listas foram alteradas pois ambas estão apontando para uma mesma referência de memória

*/
}

```

### 🦴 Structs

* Tipos de dados estruturados
* Apenas a estrutura, o esqueleto
* Value-Type
* Definido pela palavra `struct`
* Composto de propriedades e métodos
* Criado a partir da palavra `new`

```csharp
struct Product
{
  // Props
  public int Id;
  public string Title;
  public float Price;

  // Methods
  public float PrinceInDolar(float dolar)
  {
    return Price * dolar
  }
}

// Para criar uma nova estrutura basta usar a palavra "new" seguido da chamada da chamada do structure
static void Main(string[] args)
{
  Product product = new Product()
  // ou assim 👇
  var product = new Product()
  // nesse caso o tipo é opcional

  product.Id = 1;
  product.Title = "Mouse Gamer";
  product.Price = 100;

  Console.WriteLine(product.Id);
  Console.WriteLine(product.Title);
  Console.WriteLine(product.Price);
}
```

> Obs.: Podemos criar uma `struct` usando também um método construtor. A diferença é que ao instanciar já devemos passar as propriedades.

```csharp
struct Product
{
  public Product(int id, string title, float price)
  {
    Id = id;
    Title = title;
    Price = price;
  }
}
```

### 🔢 Enumeradores

_Usado para fornecer uma melhor visualização do código. Substituem o uso de inteiros e são usados em listas curtas e dados fixos._

```csharp
enum EEstadoCivil
{
  Solteiro = 1,
  Casado = 2,
  Divorciado = 3
}

struct Cliente
{
  public string Nome;
  public EEstadoCivil EstadoCivil;
}

var cliente = new Cliente("João Silva", EEstadoCivil.Casado);

Console.WriteLine(cliente.EstadoCivil) // Casado
Console.WriteLine((int)cliente.EstadoCivil) // 2

```

### ✏️ Strings

> Strings são o que? São "_letras, são números, são caracteres, e tudo mais que cabe em aspas_".

#### → GUID

> São sequências de caracteres randomicas utilizadas como identificação única de um registro, usuário, produto, etc.

```csharp
using System;
var id = Guid.NewGuid();
```

Se precisarmos usar um valor randômico basta instanciar o `Guid`. Se precisarmos que o `id` possua menos caracteres, basta usar o método `Substring`.

```csharp
id.ToString().Substring(i,q);
// sendo "i" a posição inicial e "q" a quantidade total de caracteres.
// ex: Substring(0, 8)
```

#### → Interpolação de strings

> Conseguimos unir strings para que uma determinada mensagem seja passada de forma legível para o usuário. Podemos fazer essa interpolação de várias maneiras:

```csharp
// usando o operador +
var presentation = "Meu nome é";
var name = "João da Couve";
var myPresentation = "Meu nome é" + " " + name;

// usando string.Format()
var price = 15.99;
var finalPrice = string.Format("O preço final é {0}", price);

// usando $
// obs.: podemos usar @ para escrever multiplas linhas
var helloWorld = $"Olá mundo, meu nome é {name}."
var text = $@"Era uma vez...
E a chapeuzinho vermelho...
E por fim matou o lobo...
FIM."
```

___

## 💣 Execução do programa

> A execução de um programa em C# funciona da seguinte maneira:

* O programa busca o `Program.cs`
* Lê a classe `Program`
* Lê e executa o método `Main`
* Durante a execução, todos os arquivos serão unificados em uma `DLL`
* A divisão física se perderá
* Sobrará apenas a divisão lógica, que são os `Namespaces`

___

## 🖱️ Criando um novo projeto

`dotnet new console -o MyNewProject`
