using CadastroDeClientes.Data;
using CadastroDeClientes.Models;

namespace CadastroDeClientes.Repositorio
{
    public class ClienteRepositorio : IClienteRepositorio
    {
        private readonly BancoContext _context;
        public ClienteRepositorio(BancoContext bancoContext)
        {
            this._context = bancoContext;
        }
        public ClienteModel ListarPorId(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.Id == id);
        }
        public List<ClienteModel> BuscarTodos()
        {
            return _context.Clientes.ToList();
        }
        public ClienteModel Adicionar(ClienteModel cliente)
        {
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
            return cliente;
        }

        public ClienteModel Atualizar(ClienteModel cliente)
        {
            ClienteModel clienteDb = ListarPorId(cliente.Id);

            if (clienteDb == null) throw new System.Exception("Houve um erro na atualização do cliente!");

            clienteDb.Nome = cliente.Nome;
            clienteDb.DataDeNascimento = cliente.DataDeNascimento;
            clienteDb.RG = cliente.RG;
            clienteDb.CPF = cliente.CPF;
            clienteDb.Celular = cliente.Celular;
            clienteDb.TelefoneResidencial = cliente.TelefoneResidencial;
            clienteDb.TelefoneComercial = cliente.TelefoneComercial;
            clienteDb.Cep = cliente.Cep;
            clienteDb.Rua = cliente.Rua;
            clienteDb.Bairro = cliente.Bairro;
            clienteDb.Cidade = cliente.Cidade;
            clienteDb.Estado = cliente.Estado;
            clienteDb.CepSec = cliente.CepSec;
            clienteDb.RuaSec = cliente.RuaSec;
            clienteDb.BairroSec = cliente.BairroSec;
            clienteDb.CidadeSec = cliente.CidadeSec;
            clienteDb.EstadoSec = cliente.EstadoSec;
            clienteDb.Facebook = cliente.Facebook;
            clienteDb.Twitter = cliente.Twitter;
            clienteDb.Instagram = cliente.Instagram;
            clienteDb.Linkedin = cliente.Linkedin;
            clienteDb.UpdatedAt = cliente.UpdatedAt;

            _context.Clientes.Update(clienteDb);
            _context.SaveChanges();

            return clienteDb;
        }

        public bool Apagar(int id)
        {
            ClienteModel clienteDb = ListarPorId(id);

            if (clienteDb == null) throw new System.Exception("Houve um erro na exclusão do cliente!");

            _context.Clientes.Remove(clienteDb);
            _context.SaveChanges();

            return true;
        }
    }
}
