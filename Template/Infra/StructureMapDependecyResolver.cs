using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using StructureMap;


namespace Infra
{
    public class StructureMapDependecyResolver : IDependencyResolver
    {
        public object GetService(Type serviceType)
        {
            if (serviceType == null)
                return null;

            return serviceType.IsAbstract || serviceType.IsInterface
                ? ObjectFactory.Container.TryGetInstance(serviceType)
                : ObjectFactory.GetInstance(serviceType);

        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return ObjectFactory.GetAllInstances(serviceType).Cast<object>();
        }
    }
}
