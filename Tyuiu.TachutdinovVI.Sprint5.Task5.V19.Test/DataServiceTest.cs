using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task5.V19.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task5.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_UsesOnlySingleDigitIntegers()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllText(path, "14\n-9;8,5\n-3\n7\n-12\n4\n99");

                double difference = ds.LoadFromDataFile(path);

                Assert.AreEqual(16.0, difference);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
