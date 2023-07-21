using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

// referencias necesarias
using Ecommerce.Repositorio.Contrato;
using Ecommerce.Repositorio.DBContext;

namespace Ecommerce.Repositorio.Implementacion {
    public class GenericoRepositorio<TModelo> : IGenericoRepositorio<TModelo> where TModelo : class {
        private readonly DbecommerceContext _dbContext;

        public GenericoRepositorio(DbecommerceContext dbContext) {
            _dbContext = dbContext;
        }

        public IQueryable<TModelo> Consultar(Expression<Func<TModelo, bool>>? filtro = null) {
            throw new NotImplementedException();
        }

        public Task<TModelo> Crear(TModelo modelo) {
            throw new NotImplementedException();
        }

        public Task<bool> Editar(TModelo modelo) {
            throw new NotImplementedException();
        }

        public Task<bool> Eliminar(TModelo modelo) {
            throw new NotImplementedException();
        }
    }
}
