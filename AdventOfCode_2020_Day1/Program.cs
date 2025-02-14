﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode_2020_Day1
{
    class Program
    {
        private static List<int> InitializeDataset()
        {
            return new List<int>
            {
                1833,
                1949,
                1745,
                1863,
                1422,
                1980,
                1695,
                1233,
                1407,
                1971,
                1486,
                1922,
                1802,
                1689,
                214 ,
                1864,
                1091,
                1395,
                1772,
                1901,
                1542,
                1730,
                1782,
                1815,
                1818,
                1236,
                1604,
                1219,
                1834,
                1813,
                1532,
                1963,
                2003,
                1149,
                1577,
                1408,
                1871,
                1417,
                1727,
                1155,
                1953,
                1287,
                1259,
                1548,
                1126,
                1927,
                1225,
                1172,
                11  ,
                1301,
                1869,
                1808,
                1238,
                1989,
                1027,
                321 ,
                1564,
                636 ,
                1847,
                1877,
                1716,
                1275,
                1738,
                1054,
                1966,
                1019,
                1256,
                1940,
                1821,
                1914,
                1556,
                1389,
                1020,
                1293,
                1935,
                1804,
                1945,
                508 ,
                1856,
                1674,
                1721,
                1541,
                1435,
                1852,
                1394,
                2006,
                1366,
                1473,
                1274,
                623 ,
                1701,
                1842,
                1954,
                1999,
                1195,
                1246,
                1967,
                1153,
                1851,
                1294,
                1152,
                1812,
                1732,
                1030,
                1956,
                1132,
                1948,
                1865,
                1835,
                1231,
                1975,
                1759,
                1843,
                1379,
                1657,
                1267,
                1062,
                1850,
                1817,
                1543,
                1805,
                1252,
                1974,
                1161,
                876 ,
                1647,
                1796,
                1634,
                1177,
                1519,
                1527,
                1249,
                1158,
                2007,
                1702,
                1714,
                1040,
                1826,
                1837,
                1361,
                1814,
                1858,
                1828,
                1951,
                1140,
                1845,
                1476,
                1337,
                1262,
                1923,
                1397,
                1025,
                1412,
                1930,
                1164,
                1300,
                1369,
                1777,
                1591,
                1919,
                1874,
                1482,
                2010,
                1957,
                1897,
                1854,
                1992,
                1735,
                1786,
                1661,
                1404,
                1254,
                1803,
                1794,
                1614,
                1711,
                1007,
                1979,
                1928,
                1505,
                2001,
                1094,
                2005,
                1297,
                1933,
                1976,
                1104,
                1279,
                1012,
                1943,
                1679,
                1958,
                1841,
                1623,
                1809,
                1800,
                919 ,
                1620,
                1936,
                1209,
            };
        }

        static void Main(string[] args)
        {
            Part1();

            Part2();

            Console.ReadLine();
        }

        private static void Part2()
        {
            var dataset = InitializeDataset();
            bool found = false;

            foreach(var num1 in dataset)
            {
                foreach(var num2 in dataset)
                {
                    foreach(var num3 in dataset)
                    {
                        if( num1 + num2 + num3 == 2020)
                        {
                            Console.WriteLine($"{num1} and {num2} and {num3} equal 2020 and the answer is {num1 * num2 * num3}");
                            found = true;
                        }
                        if (found) break;
                    }
                    if (found) break;
                }
                if (found) break;
            }
        }


        private static void Part1()
        {
            var dataset = InitializeDataset();

            foreach (var number in dataset)
            {
                var numberToSearchFor = 2020 - number;

                if (dataset.Any(p => p == numberToSearchFor && p != number))
                {
                    Console.WriteLine($"{number} and {numberToSearchFor} equal 2020 and teh answer is {number * numberToSearchFor}");

                    break;
                }
            }
        }
    }
}