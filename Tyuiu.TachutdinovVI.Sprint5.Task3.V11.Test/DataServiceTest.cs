using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TachutdinovVI.Sprint5.Task3.V11.Lib;

namespace Tyuiu.TachutdinovVI.Sprint5.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void SaveToFileTextData_WritesRoundedDouble()
        {
            DataService ds = new DataService();

            string path = ds.SaveToFileTextData(3);
            using FileStream stream = File.OpenRead(path);
            using BinaryReader reader = new BinaryReader(stream);

            Assert.AreEqual("OutPutFileTask3.bin", Path.GetFileName(path));
            Assert.AreEqual(sizeof(double), stream.Length);
            Assert.AreEqual(-2.556, reader.ReadDouble(), 0.000001);
        }
    }
}
