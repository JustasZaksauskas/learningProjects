using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Calculator2
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        //public double num, ans;
        //public int count;
        public double rez;
        


        [WebMethod]
        public double Add(string getTextboxInfo)
        {

            rez = rez + Convert.ToDouble(getTextboxInfo);
            
            return rez;
        }
        [WebMethod]
        public double Sub(double getTextboxInfo)
        {
            rez = rez - getTextboxInfo;
            return rez;
        }
        [WebMethod]
        public double Mul(double getTextboxInfo)
        {
            rez = rez * getTextboxInfo;
            return rez;
        }
        [WebMethod]
        public double Dev(double getTextboxInfo)
        {
            rez = rez / getTextboxInfo;
            return rez;
        }

        //[WebMethod]
        //public double Compute(int count, float getNumber)
        //{
        //    switch (count)
        //    {
        //        case 1:
        //            ans = num + getNumber;
                    
        //            break;
        //        case 2:
        //            ans = num - getNumber;
                   
        //            break;
        //        case 3:
        //            ans = num * getNumber;
                    
        //            break;
        //        case 4:
        //            ans = num / getNumber;
                    
        //            break;
        //        default:
        //            break;

        //    }

        //    return ans;

        //}

    }
}
