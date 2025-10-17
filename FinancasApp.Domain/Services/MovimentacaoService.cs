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
    /// Implementação dos serviços de domínio da entidade Movimentação
    /// </summary>
    public class MovimentacaoService (IUnitOfWork unitOfWork, IMapper mapper) : IMovimentacaoService
    {
        public Task<MovimentacaoResponse> AdicionarAsync(MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse> Modificar(Guid id, MovimentacaoRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse> Excluir(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PageResult<MovimentacaoResponse>> ConsultarAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<MovimentacaoResponse?> ObterPorIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
