using System;
using System.Linq;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetFirstLettersPerNameHeatmap(NameData[] names)
        {
            var minYear = int.MinValue;
            var maxYear = int.MaxValue;

            foreach (var item in names)
            {
                minYear = (minYear > item.BirthDate.Year) ? item.BirthDate.Year : minYear;
                maxYear = (maxYear > item.BirthDate.Year) ? item.BirthDate.Year : maxYear;
            }

            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            var letters = new char[33];
            for (int i = 0; i < 33; i++)
                cahr[i] = alphabet[i];

            var years = new string[maxYear - minYear + 1];
            for (int i = 0; i < years.Length; i++)
                years[i] = Convert.ToString(i + minYear);

            var table = new double[33,maxYear - minYear + 1];
            foreach (var item in names)
                foreach (var elem in letters)
                    if (item.Name[0] == elem)
                        table[letters - 1, item.BirthDate.Year - 1]++;

            return new HeatmapData("Amount of people with a same first letter have burned in one year", table, (string)alphabet, years);
        }
    }
}