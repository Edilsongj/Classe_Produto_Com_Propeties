// Objetido do ecercicio:
//Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
//Além disso, garantir que o preço e o estoque do produto sejam valores positivos
//e criar uma propriedade que mostra detalhadamente as informações do produto, para que seja usado pela equipe de vendas.


Produto produto = new Produto();

produto.nome = "Notebook Inspiron 15";
produto.marca = "Dell";
produto.Preco = 5000;
produto.Estoque = 20;
Console.WriteLine(produto.InformacoesDoProduto);
