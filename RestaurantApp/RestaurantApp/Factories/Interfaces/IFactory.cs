using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantApp.Factories.Interfaces
{
    public interface IFactory<TEntity>
        where TEntity : class
    {
        TEntity Create(params string[] tokens);
    }
}
