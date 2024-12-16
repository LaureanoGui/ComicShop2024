using ComicShop.Domain.Entities;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace ComicShop.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        DateTime data = new DateTime(2024, 12, 14, 14, 0, 0);
        [TestMethod]
        public void TestFornecedor()
        {
            Fornecedor fornecedor = new Fornecedor(1, "Distribuidora Nacional", "contato@distribuidoranacional.com.br", "Rua das Páginas, 123");
            Debug.Write(JsonSerializer.Serialize(fornecedor));
            Assert.AreEqual(fornecedor.Nome, "Distribuidora Nacional");
            Assert.AreEqual(fornecedor.Contato, "contato@distribuidoranacional.com.br");
            Assert.AreEqual(fornecedor.Endereco, "Rua das Páginas, 123");
        }
        [TestMethod]
        public void TestCategoria()
        {
            Categoria categoria = new Categoria(1, "Super-Heróis", "Quadrinhos de super-heróis e universos fantásticos.");
            Debug.Write(JsonSerializer.Serialize(categoria));
            Assert.AreEqual(categoria.Nome, "Super-Heróis");
            Assert.AreEqual(categoria.Descricao, "Quadrinhos de super-heróis e universos fantásticos.");
        }
        [TestMethod]
        public void TestProduto()
        {
            Fornecedor fornecedor = new Fornecedor(1, "Distribuidora Nacional", "contato@distribuidoranacional.com.br", "Rua das Páginas, 123");
            Categoria categoria = new Categoria(1, "Super-Heróis", "Quadrinhos de super-heróis e universos fantásticos.");
            Produto produto = new Produto(1, "Batman: Ano Um - Edição Absoluta", "Graphic Novel de Luxo do Batman", 1, 300, "Frank Miller", "Panini Comics", 2024, 100, fornecedor, categoria);
            Debug.Write(JsonSerializer.Serialize(produto));
            Assert.AreEqual(produto.Nome, "Batman: Ano Um - Edição Absoluta");
            Assert.AreEqual(produto.Descricao, "Graphic Novel de Luxo do Batman");
            Assert.AreEqual(produto.Edicao, 1);
            Assert.AreEqual(produto.Preco, 300);
            Assert.AreEqual(produto.Autor, "Frank Miller");
            Assert.AreEqual(produto.Editora, "Panini Comics");
            Assert.AreEqual(produto.AnoPublicacao, 2024);
            Assert.AreEqual(produto.QuantidadeEstoque, 100);
            Assert.AreEqual(produto.Fornecedor, fornecedor);
            Assert.AreEqual(produto.Categoria, categoria);
        }
        [TestMethod]
        public void TestUsuario()
        {
            Usuario usuario = new Usuario(1, "Guilherme", "12345678", "Guizim", "guitlaureano@gmail.com", data, data, true);
            Debug.Write(JsonSerializer.Serialize(usuario));
            Assert.AreEqual(usuario.Nome, "Guilherme");
            Assert.AreEqual(usuario.Senha, "12345678");
            Assert.AreEqual(usuario.Login, "Guizim");
            Assert.AreEqual(usuario.Email, "guitlaureano@gmail.com");
            Assert.AreEqual(usuario.DataCadastro, data);
            Assert.AreEqual(usuario.DataLogin, data);
            Assert.AreEqual(usuario.Ativo, true);
        }
        [TestMethod]
        public void TestCliente()
        {
            Cliente cliente = new Cliente(1, "Guilherme Laureano", "guilaureanoalves.san@gmail.com", "18991512734", "Rua Doralice Botteon Carpintere, 405, Monte Libano", data, "123.123.123.12");
            Debug.Write(JsonSerializer.Serialize(cliente));
            Assert.AreEqual(cliente.Nome, "Guilherme Laureano");
            Assert.AreEqual(cliente.Email, "guilaureanoalves.san@gmail.com");
            Assert.AreEqual(cliente.Telefone, "18991512734");
            Assert.AreEqual(cliente.Endereco, "Rua Doralice Botteon Carpintere, 405, Monte Libano");
            Assert.AreEqual(cliente.DataCadastro, data);
            Assert.AreEqual(cliente.Documento, "123.123.123.12");
        }

        [TestMethod]
        public void TestDataPedido()
        {
            Fornecedor fornecedor = new Fornecedor(1, "Distribuidora Nacional", "contato@distribuidoranacional.com.br", "Rua das Páginas, 123");
            Categoria categoria = new Categoria(1, "Super-Heróis", "Quadrinhos de super-heróis e universos fantásticos.");
            Produto produto = new Produto(1, "Batman: Ano Um - Edição Absoluta", "Graphic Novel de Luxo do Batman", 1, 300, "Frank Miller", "Panini Comics", 2024, 100, fornecedor, categoria);
            List<ItensPedido> Itens = new List<ItensPedido>();
            ItensPedido itensPedido = new ItensPedido(1, 2, 300, produto, null);
            Assert.AreEqual(itensPedido.Quantidade, 2);
            Assert.AreEqual(itensPedido.PrecoUnitario, 300);
            Assert.AreEqual(itensPedido.Produto, produto);
            Pedido pedido = new Pedido();
        }
    }
}