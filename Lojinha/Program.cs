using Lojinha.Banco;

var context = new LojinhaContext(); // Inicializa o contexto do banco de dados
var clienteDAL = new ClienteDAL(context);
var listaClientes = clienteDAL.Listar();
foreach (var cliente in listaClientes)
{
    Console.WriteLine($"ID: {cliente.Id} - Nome: {cliente.Nome} - Email: {cliente.Email}");
}
