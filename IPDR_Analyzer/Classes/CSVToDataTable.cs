using Microsoft.VisualBasic.FileIO;
using System.Data;

namespace IPDR_Analyzer.Classes
{
    public class CSVToDataTable
    {
        public DataTable ReadCsvFile(string filePath)
        {
            DataTable dt = new DataTable();

            using (TextFieldParser csvParser = new TextFieldParser(filePath))
            {
                csvParser.SetDelimiters(new string[] { "," }); // Define delimiter
                csvParser.HasFieldsEnclosedInQuotes = true; // Assume data fields can be enclosed in quotes

                // Read the columns from the first line and add them to the DataTable.
                string[] colFields = csvParser.ReadFields();
                foreach (string column in colFields)
                {
                    DataColumn datecolumn = new DataColumn(column);
                    datecolumn.AllowDBNull = true;
                    dt.Columns.Add(datecolumn);
                }

                // Read the remaining rows and add them to the DataTable.
                while (!csvParser.EndOfData)
                {
                    string[] fieldData = csvParser.ReadFields();
                    // Make sure the number of fields matches the number of columns.
                    if (fieldData.Length == dt.Columns.Count)
                    {
                        dt.Rows.Add(fieldData);
                    }
                }
            }

            return dt;
        }
    }
}
