using System;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WXManagement.CommonUtility;

namespace WXManagementUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            wxapi apWxapi = new wxapi();
            //HttpRequest request = new HttpRequest("","www.baidu.com","");
            //apWxapi.ProcessRequest(new HttpContext(request,new HttpResponse()));
        }
    }
}
