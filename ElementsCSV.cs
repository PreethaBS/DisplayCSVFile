using System;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace DisplayCSVFile
{
    /// <summary>
    /// Class for data csv
    /// </summary>
    class ElementsCSV
    {
        [Name("StationName")]
        public string StationName { get; set; }

        [Name("screen_id")]
        public int ScreenID { get; set; }

        [Name("date")]
        public DateTime Date { get; set; }

        [Name("depth_to_water_level")]
        public double DepToWaterLvl { get; set; }

        [Name("comment")]
        public string Comment { get; set;}
    }
    /// <summary>
    /// class for combo_example
    /// </summary>
    class ElementsCombo
    {
        [Name("Name")]
        public string Name { get; set; }

        [Name("Id")]
        public int Id { get; set; }        
    }
}
