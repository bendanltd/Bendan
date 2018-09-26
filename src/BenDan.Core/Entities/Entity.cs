using BenDan.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BenDan.Core.Entities
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
