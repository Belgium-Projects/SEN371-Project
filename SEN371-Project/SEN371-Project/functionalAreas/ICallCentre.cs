using SEN371_Project.dataHandler;
using System.Collections.Generic;

namespace SEN371_Project.FunctionalAreas
{
    internal interface ICallCentre
    {
        void deleteFromDB();
        void saveToDB();
        List<client> selectFromDB();
        void updateFromDB();
    }
}