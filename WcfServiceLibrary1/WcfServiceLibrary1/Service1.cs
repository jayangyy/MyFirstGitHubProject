using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;

namespace WcfServiceLibrary1
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的类名“Service1”。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Vide> AZwcfStr(string Str,string Str1)
        {
            string stri = Str;
            string stri1 = Str1;
            if (stri == "123")
            {
                List<Vide> list = new List<Vide>();
                list.Add(new Vide { FileName = "\\\\10.201.18.232\\e\\2014-11\\2014-11-28\\2014-11-28 044435\\2014-11-28 044435_1.Mp4", JumpTime = "0" });
                return list;
            }
            else
            {
                List<Vide> list = new List<Vide>();
                list.Add(new Vide { FileName = "\\\\10.201.18.232\\e\\2014-11\\2014-11-28\\2014-11-28 044435\\2014-11-28 044435_1.Mp4", JumpTime = "30" });
                return list;
            }
        }

        public List<User> AZwcfXML()
        {
            List<User> list = new List<User>();
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "123"});
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "234" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "345" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "456" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "567" });
            return list;
        }

        public List<User> AZwcfJson()
        {
            List<User> list = new List<User>();
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "567" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "456" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "345" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "234" });
            list.Add(new User { Name = "Bill Gates", Age = "YouYi East Road", Addr = "123" });
            return list;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
