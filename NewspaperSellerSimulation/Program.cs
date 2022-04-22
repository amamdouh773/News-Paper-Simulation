using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewspaperSellerTesting;

namespace NewspaperSellerSimulation
{
    static class Program
    {
        public static NewspaperSellerModels.SimulationSystem simSys = new NewspaperSellerModels.SimulationSystem();
        public static NewspaperSellerModels.PerformanceMeasures PerformanceMeasure = new NewspaperSellerModels.PerformanceMeasures();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogicUnit datafile = new LogicUnit(@"D:\College\NewspaperSellerSimulation_Students\NewspaperSellerSimulation\TestCases\TestCase2.txt");
            
            datafile.get_data();
            simSys.NumOfNewspapers = datafile.numOfNewspaper;
            simSys.NumOfRecords = datafile.numOfRecords;
            simSys.PurchasePrice = datafile.purchasePrice;
            simSys.ScrapPrice = datafile.scrapPrice;
            simSys.SellingPrice = datafile.sellingPrice;
            simSys.DayTypeDistributions = datafile.generateDayTypeDist(datafile.day_type_dist);
            simSys.DemandDistributions = datafile.generateDemandDist(datafile.demand_dist);
            simSys.SimulationTable = datafile.generateSimTable(simSys);
            PerformanceMeasure =  datafile.calcPerformanceMeassures(simSys);
            string testingResult = TestingManager.Test(simSys, Constants.FileNames.TestCase2);
            MessageBox.Show(testingResult);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
