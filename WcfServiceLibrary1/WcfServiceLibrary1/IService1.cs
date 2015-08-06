using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceLibrary1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
        [WebGet(UriTemplate = "AZwcfXML", ResponseFormat = WebMessageFormat.Xml, RequestFormat = WebMessageFormat.Xml,BodyStyle=WebMessageBodyStyle.Bare)]
        List<User> AZwcfXML();

        [OperationContract]
        [WebGet(UriTemplate = "AZwcfJson", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json,BodyStyle = WebMessageBodyStyle.Bare)]
        List<User> AZwcfJson();

        [OperationContract]
        [WebGet(UriTemplate = "AZwcfStr/{Str},{Str1}", ResponseFormat = WebMessageFormat.Json, RequestFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        List<Vide> AZwcfStr(string Str,string Str1);

        // TODO: 在此添加您的服务操作
    }

    // 使用下面示例中说明的数据协定将复合类型添加到服务操作
    [DataContract]
    public class CompositeType
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

    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Age { get; set; }
        [DataMember]
        public string Addr { get; set; }
    }

    [DataContract]
    public class Vide
    {
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public string JumpTime { get; set; }
    }  
}
