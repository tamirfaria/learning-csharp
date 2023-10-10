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

_Utilizamos a palavra chave ``using`` para definir as importações que serão feitas dentro de um arquivo._

### • Namespace

_Serve para criar uma divisão lógica dentro de um arquivo. Geralmente os ``Namespaces`` acompanham o nome da página. Assim como não podemos ter dois arquivos com o mesmo nome dentro de uma pasta, também não podemos ter dois ``Namespaces`` com o  mesmo nome dentro de um arquivo._

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

_Diferente de uma variável, os valores das constantes são inalteráveis. Uma vez que a gente atribui um valor à constante em sua inicialização, o valor dela não pode mais ser alterado. Elas não funcionam com a palavra chave ``var`` e são mais otimizadas que as variáveis._

_Por convenção é comum vermos as constantes sempre escritas com letras maiúsculas separadas por undescore. Ex: ``"IDADE_MINIMA"``._

```csharp
const int IDADE_MINIMA = 25;
```

### 🍰 Tipos Primitivos (built-in types)

_Os tipos primitivos possuem uma capacidade. Por exemplo, os tipos ``int`` vão do número ``-2.147.483.648`` até o número ``2.147.483.647`` (caso a gente atribua um valor que fuja desse intervalo receberemos um erro)._

#### São classificados em 👇

* Tipos simples (simple types);
* Enumeradores (enums);
* Estruturas (structs);
* Tipos nulos (nullable types)

#### → System

_No .NET tudo começa de um tipo base chamado ``system``. Todos os tipos derivam dele. Seu uso já é implicito e todos os objetos, variáveis e constantes._

#### → Byte

_O tipo ``byte`` é usado para representar um byte de fato. Seu valor vai de 0 até 255 (8-bit)._

#### → Números Inteiros

_São números sem pontuação podendo ser curtos, médios ou longos. Utilizamos a notação ``unsigned`` para definir que as variáveis não podem receber valores negativos._

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

_Utiliza ``8-bits`` de memória e armazena ``true`` ou ``false``. Usamos a palavra chave ``bool`` para inferir este tipo._

#### → Char

_Utilizado para armazenarmos um único caractere (unicode). É definido pela palavra chave ``char`` e a inferência de valor se dá pelas aspas simples. Ocupa 16-bit de memória._

#### → String

_Armazena uma cadeia de caracteres (um conjunto de chars). É definido pela palavra chave ``string`` e a inferência de valor se dá pelas aspas duplas. O espaço em memória é definido pelo tamanho da ``string``._

#### → Var

_Infere dinamicamente o tipo da variável de acordo com o valor atribuído à ele. Por exemplo, se atribuírmos o valor ``25`` à uma variável, logo o tipo inferido será ``int``. Logo após essa definição dinâmica, não é possível alterar o tipo da variável._

#### → Object

_É similar ao ``"any"`` do ``Typescript``. É um tipo genérico que recebe qualquer valor ou objeto e que não ativa o ``intelisense`` dos editores por ser um tipo desconhecido. Na dúvida, evite usa-lo._

#### → Nullable Types

_Diferente de uma string vazia, o ``null`` significa vazio, nada. Todo tipo primitivo ou complexo pode receber o valor ``null``. Para isso deverá ser marcado como ``Nullable Type`` 👇._

```csharp
int? idade = null;
```

#### → Alias

_Alias é o apelido que todo tipo .NET tem. Por exemplo, ``System.String`` tem o alias ``string``._

```csharp
int idade = 25; // Alias
Int32 idade = 25; // Tipo
```

#### → Valores padrão (built-in)

_Todo tipo ``built-in`` já possui um valor padrão. Caso não seja atribuído nenhum valor à variável, ela adoratá os valores abaixo 👇_

* int → 0
* float → 0
* decimal → 0
* bool → false
* char → '\0'
* string → ""

### 🦎 Conversões

#### → Conversão Implícita

_É comum transformarmos os tipos de uma determinada variável. Para isso podemos usar as ``Conversões Implícitas`` que podem ser executadas com passagem de dados dos quais os tipos são compatíveis. Por exemplo:_

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

_Toda variável do tipo ``built-in`` possui métodos chamados de ``Parse``. Esses métodos são usados para converter um caractere ou string para um outro tipo qualquer. Caso haja alguma incompatibilidade, gerará um erro._

> Obs.: O ``Parse`` converte somente strings

```csharp
string valor = "100";
int inteiro = int.Parse(valor);

```

#### → Convert

_Ao contrário do ``Parse``, o ``Convert`` é um objeto que possui métodos próprios de conversão, podendo converter vários tipos de valores e não apenas strings._

```csharp
string valor = "100";
int inteiro = Convert.ToInt32(valor);

```

___

## 💣 Executando o programa

> A execução de um programa em C# funciona da seguinte maneira:

* O programa busca o ``Program.cs``
* Lê a classe ``Program``
* Lê e executa o método ``Main``
* Durante a execução, todos os arquivos serão unificados em uma ``DLL``
* A divisão física se perderá
* Sobrará apenas a divisão lógica, que são os ``Namespaces``

___
