using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Timer
{
    [ServiceContract]
    public interface ITimerService
    {
        [OperationContract]
        void StartTimer(int miliseconds);
    }
}
