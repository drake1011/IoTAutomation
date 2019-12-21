using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using IoT.Automation.Data.Interfaces;

namespace IoT.Automation.Data.Services
{
    public class DbService : IDbService
    {
        private readonly string _connectionString = "Server = CARBIDE; Database = IoTAutomation; Trusted_Connection = True;";
        public void AddTemperature(double fehrenheight, double celcius, double humidity, DateTime entryDate)
        {
            using(var conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                conn.Execute("spCreateTemperatureRow", param: new
                {
                    @dFehr = fehrenheight,
                    @dCelc = celcius,
                    @dHumidity = humidity,
                    @dDate = entryDate,
                    @sSensor = "default"
                }, commandType: System.Data.CommandType.StoredProcedure);
            }
        }
    }
}
