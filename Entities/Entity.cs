using System;

namespace ReviewsAndRatings.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id {get; set;}
    }
}