Exercício: Classe Produto
Este projeto em C# tem como objetivo praticar a criação de classes com propriedades, validação de valores e exibição de dados formatados e coloridos no console.

🧠 Objetivo
Criar uma classe Produto com os seguintes atributos:

nome

marca

preco

estoque

Garantir que:

O preço seja sempre um valor positivo (ou definido como 10 por padrão, caso negativo ou zero).

O estoque também seja sempre um valor positivo (ou 10 por padrão).

Criar uma propriedade de leitura que exiba as informações do produto de forma organizada e legível.

No Program.cs, instanciar a classe, atribuir valores e exibir as informações no console com cores diferentes para cada campo, usando Console.ForegroundColor.

🛠️ Tecnologias Usadas
Linguagem: C#

Plataforma: .NET Console Application

📦 Estrutura
Produto.cs: Define a classe Produto, com validação e exibição das propriedades.

Program.cs: Responsável por criar o objeto Produto e exibir os dados formatados no console.

💡 Exemplo de Saída
makefile
Copiar
Editar
Nome: Notebook Inspiron 15
Marca: Dell
Preço: 5000
Estoque: 20
(Cada linha acima é exibida com uma cor diferente no console)

✅ Aprendizado
Este exercício ajuda a reforçar conceitos de:

Encapsulamento e validação com get e set

Propriedades personalizadas (get => ...)

Formatação de saída no console

Uso do Console.ForegroundColor e Console.ResetColor
