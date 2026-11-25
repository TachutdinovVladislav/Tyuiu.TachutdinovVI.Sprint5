using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task6.V17.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromDataFile_CountsAllSpacesInRuns()
        {
            DataService ds = new DataService();
            string path = Path.GetTempFileName();

            try
            {
                File.WriteAllText(path, "  а б   в\t г  \n д");

                int count = ds.LoadFromDataFile(path);

                Assert.AreEqual(7, count);
            }
            finally
            {
                File.Delete(path);
            }
        }
    }
}
