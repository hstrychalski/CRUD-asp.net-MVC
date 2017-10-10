using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers.Models;

namespace Workers.Services
{
    public interface IWorkerService
    {
        List<Worker> GetAll();
        Worker GetById(int id);
        void Remove(int id);
        void Update(int id, Worker workerUpdated);
        void Add(Worker workerToAdd);

        

    }
}
