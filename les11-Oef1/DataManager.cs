using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les11_Oef1
{
    class DataManager
    {
        public List<Publisher> GetAllPublishers()
        {
            try
            {
                using (var entities = new PublisherModel())
                {
                    var query = from Publisher in entities.Publishers.Include("Employees")
                                select Publisher;

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Job GetJobByID(int job_id)
        {

            try
            {
                using (var entities = new PublisherModel())
                {
                    foreach (var job in entities.Jobs)
                    {
                        if (job.job_id == job_id) { return job; }
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return null;
        }

        public List<Job> GetAllJob()
        {
            try
            {
                using (var entities = new PublisherModel())
                {
                    return entities.Jobs.ToList();
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public int InsertEmployee(Employee e)
        {
            return 0;
        }

        public int UpdateEmployee(Employee e)
        {
            try
            {
                using (var entities = new PublisherModel())
                {
                    foreach (var employee in entities.Employees)
                    {
                        if (employee.Equals(e))
                        {
                           
                        }
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return 0;
        }

        public int DeleteEmployee(Employee e)
        {
            return 0;
        }

    }
}
