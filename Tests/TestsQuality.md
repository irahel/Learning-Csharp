---
weight: 3
title: "Correção automatizada"
---

# Como criar projetos com avaliação automatizada

Este tutorial mostra o passo a passo sobre como criar projetos com avaliação automatizada e segura. Nas Acelerações, chamamos esses projetos de "Desafios".

# Em C#

- Os testes são feitos com o XUnit 2.4.1.
- São testes que garantem que o que o enunciado pede está sendo entregue, podendo ser unitários ou de integração, ficando a critério de quem os faz.
- Cada teste de requisito deve ser precedido pela _data annotation_ `[Fact]` ou `Theory` e ser descrita usando o modificador `DisplayName = "Descrição do requisito para estudante ver aqui"`.
-Ex: 
```C#
[Fact(DisplayName = "Testing Division")]
public void TestDivide()
{
    Assert.Equal(1, Calculator.Divide(10,10));
}
```
- Todas as classes de um projeto devem estar no mesmo pacote, e este pacote deve ter o mesmo nome do diretório do projeto
- Todos os códigos devem ser entregues passando no checador de estilo https://github.com/StyleCop
- Todo desafio deve vir com um arquivo .trybe/requirements.json na raiz da pasta de desafios, mapeados conforme instruções abaixo

## Exemplo

Aqui faremos um exemplo. Para isso, o projeto exemplo de nome `SimpleMathV3` será criado e testado pelo projeto `SimpleMathV3Test`, o qual será criado no modelo XUnit seguindo o comando `dotnet new xunit -o SimpleMathV3Test`.

## Desenvolvendo o projeto

Agora você deve desenvolver o projeto normalmente, adicionando os arquivos, imagens e configurações necessárias para o desenvolvimento do projeto por parte dos estudantes.

Após criar o projeto, por exemplo, criamos 1 classe `SimpleMath`:

- `SimpleMathV3/SimpleMath.cs`
```C#
namespace SimpleMath
{
    public static class SimpleMath
    {
        public static int Add(int number1, int number2) => number1 + number2;
        public static int Subtract(int number1, int number2) => number1 - number2;        
    }
}
```

## Desenvolvendo os testes

Para este exemplo, a ferramenta escolhida para execução dos testes será o [XUnit](https://xunit.net/).

1. Implementei os testes no arquivo `SimpleMathV3Test/SimpleMathTest.cs`
    ```C#
    using Xunit;
    using SimpleMath;

    namespace SimpleMath.Tests
    {
        public class SimpleMathTest
        { 
            [Fact(DisplayName = "testing a single addition")]
            [Trait("Category","Sum")]
            public void TestAdd()
            {        
            Assert.Equal(20, Calculator.Add(10, 10));
            }
            
            [Theory(DisplayName = "Testing multiple subtractions")]
            [Trait("Category","Sub")]
            [InlineData(10,10,20)]
            [InlineData(15,15,30)]
            [InlineData(20,20,40)]
            public void TestSubtract(int n1, int n2, int expected)
            {
                Assert.Equal(expected, Calculator.Add(n1, n2));
            }
        }
            
    }
    ```

> Use Fact para quando a lógica de teste for com exemplo único e Theory quando for multipla.
> Cada função de teste, deve testar apenas 1 funcionalidade/requisito.
> Para o Theory, os _data annotations_ correspondentes a necessidade, fica a critério de quem o faz usar InlineData, MemberData ou ClassData.

## Mapeamento os requisitos do projeto

O mapeamento dos testes para os requisitos é necessário dado que nossa avaliação é baseada em requisitos.
Na prática, os testes unitários avaliam os requisitos, mas é necessário indicar quais testes são relacionados a quais requisitos.

1. Todos os testes unitários devem ser organizados dentro de um bloco `Trait` ou estrutura análoga da sua ferramenta de escrever testes.
2. **Um** bloco `Trait` **deve** ser mapeado para apenas **um** requisito
3. Se **todos** os testes dentro de um bloco `Trait` funcionarem, a pessoa estudante está **aprovada** naquele requisito
4. Se **pelo menos um** teste falhar dentro de um bloco `Trait`, a pessoa estudante está **reprovada** naquele requisito


2. Separando os testes em blocos com `Trait`
    ```C#
    ...
    [Fact(DisplayName = "testing a single addition")]
    [Trait("Category","Sum")]
    public void TestAdd()
    {        
        Assert.Equal(20, Calculator.Add(10, 10));
    }
    [Fact]
    [Trait("Category","Sum")]
    public void TestFailAdd()
    {        
        Assert.NotEqual(20, Calculator.Add(10, 15));
    }  
    ...
    ```

### Arquivo de mapeamento de requisitos

Todos os detalhes relacionados ao mapeamento de testes unitários para requisitos estarão nos `README`s dos avaliadores.

Esse mapeamento é feito através do arquivo `.trybe/requirements.json` que conterá o nome dos requisitos, ou seja, o título utilizado nos blocos `Trait` e se os requisitos são obrigatórios ou não.

O arquivo `.trybe/requirements.json` para esse exemplo:

```json
{
  "requirements": [
    {
      "description": "Sum",
      "bonus": false
    },
    {
      "description": "Sub",
      "bonus": true
    }
  ]
}
```

> O exemplo acima cria o mapeamento do `describe` com nome "Sum" como um requisito obrigatório
>
> O exemplo acima cria o mapeamento do `describe` com nome "Sub" como um requisito opcional
