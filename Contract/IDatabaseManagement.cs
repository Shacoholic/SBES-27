using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace Contract
{
    [ServiceContract]
    public interface IDatabaseManagement
    {
        [OperationContract]
        String CreateDatabase(String DatabaseName);

        [OperationContract]
        String DeleteDatabase(String DatabaseName);
        [OperationContract]
        string Read(string DatabaseName,string region,string grad);
        [OperationContract]
        string Write(string DatabaseName, string region, string grad, int godina, int potrosnja);

        [OperationContract]
        String ArchiveDatabases(String DatabaseName);

        [OperationContract]
        String ModifyData(String DatabaseName, int id, string region, string grad, int godina, int potrosnja);

        [OperationContract]
        Dictionary<String, Dictionary<int, Data>> ReadData();

        [OperationContract]
        void WriteData(Dictionary<String, Dictionary<int, Data>> data);





    }
}
