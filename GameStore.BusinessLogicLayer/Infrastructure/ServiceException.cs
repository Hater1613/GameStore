using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.BusinessLogicLayer.Infrastructure
{
    public class ServiceException : Exception
    {
        public ServiceException(string message, string property) : base(message)
        {
            Property = property;
        }

        public string Property { get; protected set; }
    }
}