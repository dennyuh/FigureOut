using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AutoFigPro
{
    class DataParse
    {
//        private int size;
//        private List<double> xdata;
//        private List<double> ydata;
//        private List<double> ypercetagedata;
//        private double ymax;
//        private double xmin;
//        private double xmax;
        public int Size { private set; get; }
        public List<double> XData { private set; get; }
        public List<double> YData { private set; get; }
        public List<double> YPercentageData { private set; get; }
        public List<double> XExtremeData { private set; get; }
        public List<double> YExtremeData { private set; get; } 
        public double YMax { private set; get; }
        public double XMin { private set; get; }
        public double XMax { private set; get; }
        public String StrSourceData { get; set; }

        public bool Good
        {
            get { return (XData != null && YData != null && YPercentageData != null); }
        }

        public bool Parse()
        {
            string[] splitStr = StrSourceData.Split(new char[]{'\r','\n'});
            string pattern = @"^(-?\d+)(\.\d+)?\t(-?\d+)(\.\d+)?$";
            var RetData = splitStr.Where(n => Regex.IsMatch(n, pattern));
            if (XData == null)
                XData = new List<double>();
            else
                XData.Clear();
            if (YData == null)
                YData = new List<double>();
            else
                YData.Clear();
            foreach (var strLine in RetData)
            {
                string[] tmp = strLine.Split('\t');
                XData.Add(Convert.ToDouble(tmp[0]));
                YData.Add(Convert.ToDouble(tmp[1]));
            }
            XMin = XData.Min();
            XMax = XData.Max();
            YMax = YData.Max();
            calPercentageData();
            calExtremePoints();
            return true;
        }
        private void calPercentageData()
        {
            if (YPercentageData == null)
                YPercentageData = new List<double>();
            else
                YPercentageData.Clear();
            foreach (double d in YData)
            {
                YPercentageData.Add(d*100/YMax);
            }
        }
        private void calExtremePoints()
        {
            
        }
    }
}
