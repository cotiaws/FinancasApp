using AutoMapper;
using FinancasApp.Domain.Dtos.Requests;
using FinancasApp.Domain.Dtos.Responses;
using FinancasApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Domain.Mappings
{
    /// <summary>
    /// Configuração dos mapeamentos do AutoMapper
    /// </summary>
    public class ProfileMap : Profile
    {
        public ProfileMap()
        {
            CreateMap<CategoriaRequest, Categoria>();
            CreateMap<MovimentacaoRequest, Movimentacao>();

            CreateMap<Categoria, CategoriaResponse>();
            CreateMap<Movimentacao, MovimentacaoResponse>();
        }
    }
}
