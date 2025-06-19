using GestionDeGastosMensuales.Data;
using GestionDeGastosMensuales.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GestionDeGastosMensuales.Repositories
{
    internal class GastoRepository
    {
        private readonly GastosDbContext _context;

        public GastoRepository()
        {
            _context = new GastosDbContext();
        }

        // Crear
        public void Agregar(Gasto gasto)
        {
            _context.Gastos.Add(gasto);
            _context.SaveChanges();
        }

        // Leer todos
        public List<Gasto> ObtenerTodos()
        {
            return _context.Gastos.ToList();
        }

        // Buscar por categoría o descripción
        public List<Gasto> Buscar(string texto)
        {
            return _context.Gastos
                .Where(g => g.Categoria.Contains(texto) || g.Descripcion.Contains(texto))
                .ToList();
        }

        // Actualizar
        public void Actualizar(Gasto gasto)
        {
            _context.Gastos.Update(gasto);
            _context.SaveChanges();
        }

        // Eliminar
        public void Eliminar(int id)
        {
            var gasto = _context.Gastos.Find(id);
            if (gasto != null)
            {
                _context.Gastos.Remove(gasto);
                _context.SaveChanges();
            }
        }
    }
}
