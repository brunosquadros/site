using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ExampleService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ExampleService.svc or ExampleService.svc.cs at the Solution Explorer and start debugging.
    public class ExampleService : IExampleService
    {
        public string DoTest(string param)
        {
            return "You have typed: " + param;
        }

        public TestReturn DoTestWithEntity()
        {
            return new TestReturn();
        }
    }
}
