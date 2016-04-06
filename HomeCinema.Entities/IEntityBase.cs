using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeCinema.Entities
{
    /**
     * All of our entities will implement an IEntityBase interface 
     * which means that will have an ID property mapping to their primary key in the database
     */
    public interface IEntityBase
    {
        int ID { get; set; }
    }
}
