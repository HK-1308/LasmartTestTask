using LasmartTestTask.Data.Interfaces;
using LasmartTestTask.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Data.Repositories
{
    public class PointRepository : IPointRepository
    {
        private readonly DataContext dataContext;

        public PointRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<List<Point>> GetAllPoints()
        {
            var points = await dataContext.Points.Include(p => p.Comments).ToListAsync();
            return points;
        }

        public async Task<int> RemovePoint(int id)
        {
            var point = await dataContext.Points.Include(p => p.Comments).FirstOrDefaultAsync(point => point.Id == id);
            dataContext.Points.Remove(point);
            return await dataContext.SaveChangesAsync();
        }
    }
}
