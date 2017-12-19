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
            List<Publisher> publishers = new List<Publisher>();

            try
            {
                using (var entities = new PublisherModel())
                {
                    var query = from Publisher in entities.Publishers.Include("Employees")
                                select Publisher;

                    foreach (var publisher in query)
                    {
                        publishers.Add(publisher);
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return publishers;
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
    }
}
