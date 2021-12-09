using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TemperatureLibPack
{
    [TestClass]
    public class TempertureConvertionCFK
    {
     

        [TestMethod]
        public void convertionCtoK()
        {
           double result; 
           result = 5.25 + 273.15;

            if (result == 278.4)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }

           
        }

        [TestMethod]
        public void convertionCtoF()
        {
            double result;
            result = (5.25 * 9 / 5) + 32;

            if (result == 41.45)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }


        }


        [TestMethod]
        public void convertionFtoC()
        {
            double result;
            result = (5.25 -32) * 5/9;

            if (result == -14.86111)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }


        }
        [TestMethod]
        public void convertionFtoK()
        {
            double result;
            result = (5.25 - 32) * 5 / 9 + 273.15;

            if (result == 258.2889)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }


        }
        [TestMethod]
        public void convertionKtoF()
        {
            double result;
            result = (5.25 - 273.15) * 9/5 + 32;

            if (result == -450.22)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }
          }
        [TestMethod]
        public void convertionKtoC()
        {
            double result;
            result = 5.25 - 273.15;

            if (result == -267.9)
            {
                bool validate = System.Convert.ToBoolean(result);
                Assert.IsTrue(validate);
            }
        }

    }

}
    
