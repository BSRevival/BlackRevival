using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackRevivalServer.Common.Services
{
    public delegate IService IServiceConstructor();
    public interface IService
    {
        public Task Start();
        public void Stop();
        public void Configure(object config);
    }
}
