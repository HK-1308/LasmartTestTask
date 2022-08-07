using LasmartTestTask.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LasmartTestTask.Data.Interfaces
{
    public interface IPointRepository
    {
        public Task<int> RemovePoint(int id);

        public Task<List<Point>> GetAllPoints();
    }
}
