using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IIncludeAggregator
    {
        string IncludeString { get; }

        void AddNavigationPropertyName(string? navigationPropertyName);
    }
}
