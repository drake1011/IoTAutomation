using System;
using System.Collections.Generic;
using System.Text;

namespace IoT.Automation.Data.Interfaces
{
    public interface IDbService
    {
        void AddTemperature(double fehrenheight, double celcius, double humidity, DateTime entryDate);
    }
}
