using AutoMapper;
using FinancasApp.Domain.Dtos.Requests;
using FinancasApp.Domain.Dtos.Responses;
using FinancasApp.Domain.Interfaces.Repositories;
using FinancasApp.Domain.Interfaces.Services;
using FinancasApp.Domain.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Services
{
    /// <summary>
    /// Implementação dos serviços de domínio da entidade Categoria
    /// </summary>
    public class CategoriaService (IUnitOfWork unitOfWork, IMapper mapper) : ICategoriaService
    {
        public Task<CategoriaResponse> AdicionarAsync(CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse> Modificar(Guid id, CategoriaRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<CategoriaResponse>> ConsultarAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<CategoriaResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
