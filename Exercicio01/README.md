# Exercício 01 - Classe Produto

**Aluno:** Leonardo Lescano

## Objetivo
Praticar a criação de uma classe em C# aplicando encapsulamento e boas práticas de programação orientada a objetos.

## Enunciado

Crie uma classe chamada `Produto` que atenda aos seguintes requisitos:

### Atributos / Propriedades:
*   `Id`
*   `Nome`
*   `Preco`

### Regras e Boas Práticas:
*   Construtor privado para evitar instanciamento direto.
*   Use propriedades com `private set` para proteger alterações externas indevidas.

### Desafio:
*   Sobrescreva o método `ToString()` para retornar as informações do produto no formato:
    `Produto: [Id] - Nome: [Nome] - Preço: R$[Preco]`
*   O `Id` deve ser gerado automaticamente no momento da criação (pode usar `Guid` ou um contador estático).

### No `Program.cs`:
*   Crie pelo menos dois produtos e imprima no console.

#### Exemplo esperado no console:
```
Produto: 1 - Nome: Mouse Gamer - Preço: R$150,00
Produto: 2 - Nome: Teclado Mecânico - Preço: R$350,00
```