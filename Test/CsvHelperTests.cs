using Helpers;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using Test.Models;

namespace Test
{
    public class CsvHelperTests
    {
        string address;
        CsvHelpers<Book> helper;

        [SetUp]
        public void Init()
        {
            var dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            address = dir + @"\assets\books.csv";
            helper = new CsvHelpers<Book>();
        }

        [Test]
        public void Reads_CSV_File_As_Enumerable()
        {
            var enumerable = helper.ReadAsEnumerable(address);

            Assert.That(enumerable.Count(), Is.EqualTo(4));
            Assert.That(enumerable.First().Title == "American Dirt (Oprah's Book Club): A Novel");
        }
    }
}
