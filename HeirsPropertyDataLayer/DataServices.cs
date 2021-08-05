using System.Data.Common;
using System.Collections.Generic;
using System.Configuration;
using System;

namespace HeirsPropertyDataLayer
{
    public static class DataServices
    {
        public static string[] GetTestConfigurationSet()
        {
            List<string> myretlist = new List<string>();
            ConnectionStringSettingsCollection myappsettings = ConfigurationManager.ConnectionStrings;
            foreach(ConnectionStringSettings conset in myappsettings)
            {
                myretlist.Add(conset.ConnectionString);
                  

                

            }


            return myretlist.ToArray();


        }

        public static string[] GetTestConfigurationKeySet()
        {
            List<string> myretlist = new List<string>();
            ConnectionStringSettingsCollection myappsettings = ConfigurationManager.ConnectionStrings;
            foreach (ConnectionStringSettings conset in myappsettings)
            {
                myretlist.Add(conset.Name);




            }


            return myretlist.ToArray();


        }
    }
}