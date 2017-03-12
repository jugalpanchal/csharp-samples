using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovarianceContravarianceInvariance
{
    /// <summary>
    /// https://msdn.microsoft.com/en-us/library/dd799517(v=vs.110).aspx
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            List<Entity> entities = new List<Entity>();
            entities.Add(new Entity() { Id = 1 });

            List<Company> companies = new List<Company>();
            companies.Add(new Company() { Id =2, Name="Ford" });

            Get(entities);
            Get(companies);
        }

        /// <summary>
        /// IEnumerable is covariant so it takes any collection which derivates from T
        /// It cannot add in collection and it's readonly.
        /// </summary>
        static void Get(IEnumerable<Entity> entities)
        {
            foreach (var entity in entities)
            {
                int id = entity.Id;
            }
        }
    }

    class Entity
    {
        public int Id { get; set; }
    }

    class Company : Entity
    {
        public String Name { get; set; }
    }
}
