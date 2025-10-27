using Tyuiu.KadralinovaAT.Sprint3.Task3.V4.Lib;

namespace Tyuiu.KadralinovaAT.Sprint3.Task3.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidDeleteCharInString()
        {
            DataService ds = new DataService();
            string str = "plkjjdw cvjkl";
            char chr = 'j';

            string res = ds.DeleteCharInString(str, chr);

            string wait = "plkdw cvkl";
            Assert.AreEqual(wait, res);
        }
    }
}
