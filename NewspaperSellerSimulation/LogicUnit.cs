using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerSimulation
{
    class LogicUnit
    {
        public int numOfNewspaper { get; set; }
        public int numOfRecords { get;set; }
        public decimal purchasePrice { get; set; }
        public decimal scrapPrice { get; set; }
        public decimal sellingPrice { get; set; }
        public decimal[] day_type_dist { get; set; }
        public decimal[] demand_dist { get; set; }
        string txtfile;
        public LogicUnit( string texf)
        {
            this.txtfile = texf;
            this.day_type_dist = new decimal[3];
            this.demand_dist = new decimal[28];
        }
        
        public void get_data()
        {
            if (File.Exists(this.txtfile))
            {
                string[] dtd = new string[500];
                string[] demand = new string[500];
                string[] lines = File.ReadAllLines(txtfile);
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i] == "NumOfNewspapers")
                    {

                        numOfNewspaper = Convert.ToInt32(lines[++i]);

                    }
                    else if (lines[i] == "NumOfRecords")
                    {
                        numOfRecords = Convert.ToInt32(lines[++i]);

                    }
                    else if (lines[i] == "PurchasePrice")
                    {
                        purchasePrice = Convert.ToDecimal(lines[++i]);

                    }
                    else if (lines[i] == "ScrapPrice")
                    {
                        scrapPrice = Convert.ToDecimal(lines[++i]);

                    }
                    else if (lines[i] == "SellingPrice")
                    {
                        sellingPrice = Convert.ToDecimal(lines[++i]);

                    }
                    else if (lines[i] == "DayTypeDistributions")
                    {
                        int z = 0;
                        try
                        {
                            dtd = lines[++i].Replace(" ", "").Split(',');
                            day_type_dist[z++] = Convert.ToDecimal(dtd[0]);
                            day_type_dist[z++] = Convert.ToDecimal(dtd[1]);
                            day_type_dist[z++] = Convert.ToDecimal(dtd[2]);
                        }
                        catch (Exception err)
                        {
                            break;
                        }
                    }
                    else if (lines[i] == "DemandDistributions")
                    {
                        int z = 0;
                        while (true)
                        {
                            try
                            {
                                demand = lines[++i].Replace(" ", "").Split(',');
                                demand_dist[z++] = Convert.ToDecimal(demand[0]);
                                demand_dist[z++] = Convert.ToDecimal(demand[1]);
                                demand_dist[z++] = Convert.ToDecimal(demand[2]);
                                demand_dist[z++] = Convert.ToDecimal(demand[3]);
                            }
                            catch (Exception err)
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
        public List<NewspaperSellerModels.DayTypeDistribution> generateDayTypeDist(decimal[] dayTypeDist)
        {
            decimal cummProb = 0;
            List<NewspaperSellerModels.DayTypeDistribution> distTable = new List<NewspaperSellerModels.DayTypeDistribution>();
            for(int i = 0; i < dayTypeDist.Length; i++)
            {
                NewspaperSellerModels.DayTypeDistribution row = new NewspaperSellerModels.DayTypeDistribution();
                if (i == 0)
                    row.DayType = NewspaperSellerModels.Enums.DayType.Good;
                else if (i == 1)
                    row.DayType = NewspaperSellerModels.Enums.DayType.Fair;
                else
                    row.DayType = NewspaperSellerModels.Enums.DayType.Poor;

                row.Probability = dayTypeDist[i];
                row.MinRange = Convert.ToInt32(cummProb * 100 + 1);
                cummProb += dayTypeDist[i];
                row.MaxRange = Convert.ToInt32(cummProb * 100);
                row.CummProbability = cummProb;
                distTable.Add(row);
            }

            return distTable;
        }

        public List<NewspaperSellerModels.DemandDistribution> generateDemandDist(decimal[] demandtDist)
        {
            List<NewspaperSellerModels.DemandDistribution> demandTable = new List<NewspaperSellerModels.DemandDistribution>();
            decimal GcummProb = 0;
            decimal FcummProb = 0;
            decimal PcummProb = 0;
            for (int i = 0; i < demandtDist.Length; i+=4)
            {
                NewspaperSellerModels.DemandDistribution row = new NewspaperSellerModels.DemandDistribution();
                row.Demand = Convert.ToInt32(demandtDist[i]);
                for(int y = i + 1; y < i + 4; y++)
                {
                    NewspaperSellerModels.DayTypeDistribution dist = new NewspaperSellerModels.DayTypeDistribution();
                    if (y == i + 1)
                    {
                        dist.DayType = NewspaperSellerModels.Enums.DayType.Good;
                        dist.Probability = demandtDist[y];
                        dist.MinRange = Convert.ToInt32(GcummProb * 100 + 1);
                        GcummProb += dist.Probability;
                        dist.MaxRange = Convert.ToInt32(GcummProb * 100);
                        dist.CummProbability = GcummProb;
                    }
                    else if (y == i + 2)
                    {
                        dist.DayType = NewspaperSellerModels.Enums.DayType.Fair;
                        dist.Probability = demandtDist[y];
                        dist.MinRange = Convert.ToInt32(FcummProb * 100 + 1);
                        FcummProb += dist.Probability;
                        dist.MaxRange = Convert.ToInt32(FcummProb * 100);
                        dist.CummProbability = FcummProb;
                    }
                    else
                    {
                        dist.DayType = NewspaperSellerModels.Enums.DayType.Poor;
                        dist.Probability = demandtDist[y];
                        dist.MinRange = Convert.ToInt32(PcummProb * 100 + 1);
                        PcummProb += dist.Probability;
                        dist.MaxRange = Convert.ToInt32(PcummProb * 100);
                        dist.CummProbability = PcummProb;
                    }
                    row.DayTypeDistributions.Add(dist);
                }
                demandTable.Add(row);
            }
            return demandTable;
        }

        public List<NewspaperSellerModels.SimulationCase> generateSimTable(NewspaperSellerModels.SimulationSystem system)
        {
            Random rnd = new Random();
            List<NewspaperSellerModels.SimulationCase> table = new List<NewspaperSellerModels.SimulationCase>();
            for (int i = 0; i < system.NumOfRecords; i++)
            {
                NewspaperSellerModels.SimulationCase row = new NewspaperSellerModels.SimulationCase();
                row.DailyCost = system.NumOfNewspapers * system.PurchasePrice;  
                row.DayNo = i + 1;
                row.RandomNewsDayType = rnd.Next(1, 101);
                row.RandomDemand = rnd.Next(1, 101);
                foreach (NewspaperSellerModels.DayTypeDistribution dayDist in system.DayTypeDistributions)
                {
                    if (row.RandomNewsDayType >= dayDist.MinRange && row.RandomNewsDayType <= dayDist.MaxRange)
                        row.NewsDayType = dayDist.DayType;
                }
                foreach (NewspaperSellerModels.DemandDistribution demandDist in system.DemandDistributions)
                {
                    if(row.RandomDemand >= demandDist.DayTypeDistributions[(int)row.NewsDayType].MinRange && row.RandomDemand <= demandDist.DayTypeDistributions[(int)row.NewsDayType].MaxRange)
                    {
                        row.Demand = demandDist.Demand;
                    }
                }
                if(row.Demand < system.NumOfNewspapers)
                {
                    row.SalesProfit = row.Demand * system.SellingPrice;
                    row.ScrapProfit = (system.NumOfNewspapers - row.Demand) * system.ScrapPrice;
                    row.LostProfit = 0;
                }
                else if(row.Demand > system.NumOfNewspapers)
                {
                    row.SalesProfit = system.NumOfNewspapers * system.SellingPrice;
                    row.LostProfit = ((row.Demand - system.NumOfNewspapers) * system.SellingPrice) - ((row.Demand - system.NumOfNewspapers) * system.PurchasePrice);
                    row.ScrapProfit = 0;
                }
                else
                {
                    row.SalesProfit = system.NumOfNewspapers * system.SellingPrice;
                    row.ScrapProfit = 0;
                    row.LostProfit = 0;
                }
                row.DailyNetProfit = row.SalesProfit - row.DailyCost - row.LostProfit + row.ScrapProfit;
                table.Add(row);
            }
            return table;
        }
        public NewspaperSellerModels.PerformanceMeasures calcPerformanceMeassures(NewspaperSellerModels.SimulationSystem system)
        {
            NewspaperSellerModels.PerformanceMeasures PM = new NewspaperSellerModels.PerformanceMeasures();
            foreach(NewspaperSellerModels.SimulationCase row in system.SimulationTable)
            {
                if (row.Demand > system.NumOfNewspapers)
                    system.PerformanceMeasures.DaysWithMoreDemand++;
                else if (row.Demand < system.NumOfNewspapers)
                    system.PerformanceMeasures.DaysWithUnsoldPapers++;
                system.PerformanceMeasures.TotalCost += row.DailyCost;
                system.PerformanceMeasures.TotalLostProfit += row.LostProfit;
                system.PerformanceMeasures.TotalNetProfit += row.DailyNetProfit;
                system.PerformanceMeasures.TotalSalesProfit += row.SalesProfit;
                system.PerformanceMeasures.TotalScrapProfit += row.ScrapProfit;
                
            }
            return PM;
        }
    }
}
