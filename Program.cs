using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace Log4NetSample
{
    class Program
    {

        //private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        //.Net 4.5 has new features to do this in a better way.
        private static readonly log4net.ILog log = LogHelper.GetLogger();

        static void Main(string[] args)
        {
            Console.WriteLine("Getting started with Log4Net");
            log.Error("This is an error message");
            Console.ReadLine();
        }
    }
}
