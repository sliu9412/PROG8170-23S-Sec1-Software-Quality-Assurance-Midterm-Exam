using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PROG8170Midterm;

namespace TestTemp
{
    [TestFixture]
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        [Test]
        public void Temp_Input0f_ExpectCold()
        {
            // Arrage
            float inputTemp = 0;
            string expectOutcome = "Brrr...it is cold.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input5f_ExpectCold()
        {
            // Arrage
            float inputTemp = 5;
            string expectOutcome = "Brrr...it is cold.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input9dot9f_ExpectCold()
        {
            // Arrage
            float inputTemp = 9.9f;
            string expectOutcome = "Brrr...it is cold.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input10f_ExpectNice()
        {
            // Arrage
            float inputTemp = 10;
            string expectOutcome = "It is nice outside.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input15f_ExpectNice()
        {
            // Arrage
            float inputTemp = 15;
            string expectOutcome = "It is nice outside.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input19dot9f_ExpectNice()
        {
            // Arrage
            float inputTemp = 19.9f;
            string expectOutcome = "It is nice outside.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input20f_ExpectComfortable()
        {
            // Arrage
            float inputTemp = 20;
            string expectOutcome = "It is very comfortable.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input25f_ExpectComfortable()
        {
            // Arrage
            float inputTemp = 25;
            string expectOutcome = "It is very comfortable.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input29dot9f_ExpectComfortable()
        {
            // Arrage
            float inputTemp = 29.9f;
            string expectOutcome = "It is very comfortable.";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input30f_ExpectHot()
        {
            // Arrage
            float inputTemp = 30;
            string expectOutcome = "It is boling hot outside!";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input35f_ExpectHot()
        {
            // Arrage
            float inputTemp = 35;
            string expectOutcome = "It is boling hot outside!";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input40f_ExpectHot()
        {
            // Arrage
            float inputTemp = 40;
            string expectOutcome = "It is boling hot outside!";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_InputMinus1f_ExpectInvalid()
        {
            // Arrage
            float inputTemp = -1;
            string expectOutcome = "Invalid Temperature";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input41f_ExpectInvalid()
        {
            // Arrage
            float inputTemp = 41;
            string expectOutcome = "Invalid Temperature";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }

        [Test]
        public void Temp_Input45dot5f_ExpectInvalid()
        {
            // Arrage
            float inputTemp = 45.5f;
            string expectOutcome = "Invalid Temperature";

            // Act
            string actualOutcome = Temp.TemperatureConverter(inputTemp);

            // Assert
            Assert.AreEqual(expectOutcome, actualOutcome);
        }
    }
}
