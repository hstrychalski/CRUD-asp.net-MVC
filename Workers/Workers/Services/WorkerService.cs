using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Workers.Models;

namespace Workers.Services
{
    public class WorkerService : IWorkerService
    {
        private WorkersDbContext dbcontext;

        public WorkerService(WorkersDbContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public void Add(Worker workerToAdd)
        {
            dbcontext.Set<Worker>().Add(workerToAdd);
            dbcontext.SaveChanges();
        }

        public List<Worker> GetAll()
        {
            return dbcontext.Set<Worker>().ToList();              
        }

        public Worker GetById(int id)
        {
            return dbcontext.Set<Worker>().Where(x => x.ID == id).FirstOrDefault();
        }

        public void Remove(int id)
        {
            Worker workerToRemove = GetById(id);
            dbcontext.Set<Worker>().ToList().Remove(workerToRemove);
            dbcontext.Entry(workerToRemove).State = EntityState.Deleted;
            dbcontext.SaveChanges();
        }

        public void Update(int id, Worker workerUpdated)
        {
            if (workerUpdated.Name != null) GetById(id).Name = workerUpdated.Name;
            if (workerUpdated.LastName != null)  GetById(id).LastName = workerUpdated.LastName;
            if (workerUpdated.Age.ToString() != null) GetById(id).Age = workerUpdated.Age;
            if (workerUpdated.Salary.ToString() != null) GetById(id).Salary = workerUpdated.Salary;
            dbcontext.SaveChanges();
        }
        
        

        
    }
}