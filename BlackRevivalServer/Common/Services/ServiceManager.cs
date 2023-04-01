using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Services
{
    public class ServiceManager
    {
        public Dictionary<string, IServiceConstructor> RegisteredServices;
        public Dictionary<IService, Task> RunningServices;

        public ServiceManager()
        {
            RegisteredServices = new Dictionary<string, IServiceConstructor>();
            RunningServices = new Dictionary<IService, Task>();
        }

        public void RegisterService(string name, IServiceConstructor create)
        {
            this.RegisteredServices[name] = create;
        }

        public void UnregisterService(string name)
        {
            this.RegisteredServices.Remove(name);
        }

        public IService StartService(string name, object config = null)
        {
            if (!this.RegisteredServices.ContainsKey(name))
                throw new ArgumentException("No such service registered: " + name, "name");

            IService svc = this.RegisteredServices[name]();
            svc.Configure(config);
            this.RunningServices[svc] = svc.Start();
            return svc;
        }

        public void StopService(IService instance)
        {
            lock (this.RunningServices)
            {
                if (!this.RunningServices.ContainsKey(instance))
                    throw new ArgumentException("No such service running", "instance");

                instance.Stop();
            }
        }

        public void StopService(Task task)
        {
            lock (this.RunningServices)
            {
                if (!this.RunningServices.ContainsValue(task))
                    throw new ArgumentException("No such service running that corresponds with specified task", "task");

                this.RunningServices.First(x => x.Value == task).Key.Stop();
            }
        }

        public async Task WhenAll()
        {
            await Task.WhenAll(RunningServices.Values.ToArray());
        }

        public void WaitAll()
        {
            Task.WaitAll(WhenAll());
        }
    }
}
