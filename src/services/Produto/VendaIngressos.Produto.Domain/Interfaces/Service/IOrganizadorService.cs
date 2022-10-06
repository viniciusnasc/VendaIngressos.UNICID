﻿using VendaIngressos.Produto.Domain.Entities.DTOs;
using VendaIngressos.Produto.Domain.Entities.DTOs.Results;

namespace VendaIngressos.Produto.Domain.Interfaces.Service
{
    public interface IOrganizadorService 
    {
        Task CadastrarOrganizador(OrganizadorDTO dto);
        Task<IEnumerable<OrganizadorResult>> BuscarTodosOrganizadores();
    }
}