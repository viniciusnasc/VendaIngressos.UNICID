﻿using Microsoft.EntityFrameworkCore;
using VendaIngressos.Produto.Domain.Entities;
using VendaIngressos.Produto.Domain.Interfaces.Repository;

namespace VendaIngressos.Produto.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly ProdutoContexto _context;

        public BaseRepository(ProdutoContexto context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public virtual async Task Incluir(T entity)
        {
            entity.CreateAt = DateTime.Now;
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task Alterar(T entity)
        {
            //_context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<T> SelecionarPorId(Guid id)
        {
            return await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual async Task<List<T>> SelecionarTudo()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Dispose()
        {
            await _context.DisposeAsync();
        }
    }
}