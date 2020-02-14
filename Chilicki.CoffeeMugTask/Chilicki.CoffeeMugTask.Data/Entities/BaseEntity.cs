using System;
using System.Collections.Generic;
using System.Text;

namespace Chilicki.CoffeeMugTask.Data.Entities
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
