using System;
using System.Collections.Generic;
using System.Text;

namespace ProductsApp.Infrastructure.Data
{
    public interface IDbInitializer
    {
        void Initialize(DbContext context);
    }
}
