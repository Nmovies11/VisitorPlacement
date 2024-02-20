using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPlacementLibrary;

namespace VisitorPlacementTests
{
    public class SectionTests
    {
        [Test]
        public void Section_Constructor_ValidParameters()
        {
            // Arrange
            string sectionLetter = "A";
            int numOfRows = 3;

            // Act
            Section section = new Section(sectionLetter, numOfRows, 4);

            // Assert
            Assert.AreEqual(sectionLetter, section.SectionLetter);
            Assert.AreEqual(numOfRows, section.NumOfRows);
        }

        [Test]
        public void Section_Constructor_InvalidParametersMinRows()
        {
            // Arrange
            string sectionLetter = "B";
            int numOfRows = 0; // setting numOfRows to a value less than MinRows

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new Section(sectionLetter, numOfRows, 4));
        }

        [Test]
        public void Section_Constructor_InvalidParametersMaxrows()
        {
            // Arrange
            string sectionLetter = "B";
            int numOfRows = 4; // setting numOfRows to a value less than MinRows

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => new Section(sectionLetter, numOfRows, 4));
        }
    }
}
