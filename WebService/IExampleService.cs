using System.Runtime.Serialization;
using System.ServiceModel;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IExampleService" in both code and config file together.
    [ServiceContract]
    public interface IExampleService
    {
        [OperationContract]
        string DoTest(string param);

        [OperationContract]
        TestReturn DoTestWithEntity();
    }


    [DataContract]
    public class TestReturn
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
