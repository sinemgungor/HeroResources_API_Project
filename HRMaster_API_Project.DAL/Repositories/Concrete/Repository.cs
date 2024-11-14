using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.Entities.Abstract;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> _entities;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }


        public async Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);     
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        } 

        public async Task<T> AddAsync(T entity)
        { 
            entity.CreationDate = DateTime.Now;
            entity.Status = Entities.Enums.Status.Active;
            await _entities.AddAsync(entity);
            if(await _context.SaveChangesAsync()>0)
            {
                return entity;
            };
            return null;          
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            entity.UpdatedDate = DateTime.Now;
            _entities.Update(entity);
            var result= await _context.SaveChangesAsync()>0;
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var entity = await GetByIdAsync(id);
            if (entity != null)
            {
                entity.Status = Entities.Enums.Status.Passive;
                return await _context.SaveChangesAsync()>0;
            }
            else
            { return false; }   
        }

      

        
    }
}
