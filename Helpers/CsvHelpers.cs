using CsvHelper;
using CsvHelper.Configuration;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Helpers
{
    public class CsvHelpers<T>
    {
        public List<T> ReadAsEnumerable(string path, CsvConfiguration config = null)
        {
            if (config == null)
            {
                config = new CsvConfiguration(CultureInfo.CurrentCulture)
                {
                    HasHeaderRecord = true,
                    MissingFieldFound = null,
                    HeaderValidated = null
                };
            }

            TextReader reader = new StreamReader(path);
            using var csvReader = new CsvReader(reader, config);
            var records = csvReader.GetRecords<T>();
            return records.ToList();
        }
    }
}
