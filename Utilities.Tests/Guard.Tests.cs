using NUnit.Framework;
using System;

namespace Utilities.Tests
{
    [TestFixture]
    public class GuardTest
    {
        [Test]
        public void AgainstInvalidId_GivenNegativeNumberAsLong_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidId((long)(-1), "Test"));
        }

        [Test]
        public void AgainstInvalidId_GivenZeroAsLong_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidId((long)0, "Test"));
        }
        
        [Test]
        public void AgainstInvalidId_GivenPositiveNumberAsLong_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidId((long)1, "Test");
        }

        [Test]
        public void AgainstInvalidId_GivenNegativeNumberAsInt_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidId(-1, "Test"));
        }

        [Test]
        public void AgainstInvalidId_GivenZeroAsInt_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidId(0, "Test"));
        }

        [Test]
        public void AgainstInvalidId_GivenPositiveNumberAsInt_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidId(1, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenNegativeNumberAsDecimal_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNegativeValue((decimal)(-1), "Test"));
        }

        [Test]
        public void AgainstNegativeValue_GivenZeroAsDecimal_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((decimal)0, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenPositiveNumberAsDecimal_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((decimal)1, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenNegativeNumberAsInt_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNegativeValue((int)(-1), "Test"));
        }

        [Test]
        public void AgainstNegativeValue_GivenZeroAsInt_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((int)0, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenPositiveNumberAsInt_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((int)1, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenNegativeNumberAsShort_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNegativeValue((short)(-1), "Test"));
        }

        [Test]
        public void AgainstNegativeValue_GivenZeroAsShort_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((short)0, "Test");
        }

        [Test]
        public void AgainstNegativeValue_GivenPositiveNumberAsShort_DoesNotThrowArgumentException()
        {
            Guard.AgainstNegativeValue((short)1, "Test");
        }

        [Test]
        public void AgainstInvalidXmlString_GivenInvalidXml_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidXmlString("Test", "Test"));
        }

        [Test]
        public void AgainstInvalidXmlString_GivenEmptyXml_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidXmlString(string.Empty, "Test"));
        }

        [Test]
        public void AgainstInvalidXmlString_GivenNullXml_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidXmlString(null, "Test"));
        }

        [Test]
        public void AgainstInvalidXmlString_GivenWhitespaceXml_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstInvalidXmlString(" ", "Test"));
        }

        [Test]
        public void AgainstInvalidXmlString_GivenValidXml_DoesNotThrowArgumentException()
        {
            Guard.AgainstInvalidXmlString("<test>Valid!</test>", "Test");
        }

        [Test]
        public void AgainstNullEmptyOrWhitespaceString_GivenEmptyString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNullEmptyOrWhitespaceString(string.Empty, "Test"));
        }

        [Test]
        public void AgainstNullEmptyOrWhitespaceString_GivenNullString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNullEmptyOrWhitespaceString(null, "Test"));
        }

        [Test]
        public void AgainstNullEmptyOrWhitespaceString_GivenWhitespaceString_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Guard.AgainstNullEmptyOrWhitespaceString(" ", "Test"));
        }

        [Test]
        public void AgainstNullEmptyOrWhitespaceString_GivenStringWithContents_DoesNotThrowArgumentException()
        {
            Guard.AgainstNullEmptyOrWhitespaceString("Test", "Test");
        }

        [Test]
        public void AgainstNullObject_GivenNull_ThrowsArgumentNullException()
        {
            object test = null;

            Assert.Throws<ArgumentNullException>(() => Guard.AgainstNullObject(test, nameof(test)));
        }

        [Test]
        public void AgainstNullObject_GivenAnyNonNullObject_DoesNotThrowArgumentNullException()
        {
            object test = new { };

            Guard.AgainstNullObject(test, nameof(test));
        }

        [Test]
        public void AgainstEarlyDate_GivenValidDate_DoesNotThrowArgumentException()
        {
            DateTime dateValue = new DateTime(2019, 1, 2);
            DateTime earliestValidDate = new DateTime(2019, 1, 1);

            Guard.AgainstEarlyDate(dateValue, earliestValidDate, nameof(dateValue));
        }

        [Test]
        public void AgainstEarlyDate_GivenSameDateAsLimit_DoesNotThrowArgumentException()
        {
            DateTime dateValue = new DateTime(2019, 1, 1);
            DateTime earliestValidDate = new DateTime(2019, 1, 1);

            Guard.AgainstEarlyDate(dateValue, earliestValidDate, nameof(dateValue));
        }

        [Test]
        public void AgainstEarlyDate_GivenDateEarlierThanLimit_ThrowsArgumentException()
        {
            DateTime dateValue = new DateTime(2018, 12, 31);
            DateTime earliestValidDate = new DateTime(2019, 1, 1);

            Assert.Throws<ArgumentException>(() => Guard.AgainstEarlyDate(dateValue, earliestValidDate, nameof(dateValue)));
        }

        [Test]
        public void AgainstFutureDate_GivenValidDate_DoesNotThrowArgumentException()
        {
            DateTime dateValue = new DateTime(2019, 1, 1);
            DateTime latestValidDate = new DateTime(2019, 1, 2);

            Guard.AgainstFutureDate(dateValue, latestValidDate, nameof(dateValue));
        }

        [Test]
        public void AgainstFutureDate_GivenSameDateAsLimit_DoesNotThrowArgumentException()
        {
            DateTime dateValue = new DateTime(2019, 1, 1);
            DateTime latestValidDate = new DateTime(2019, 1, 1);

            Guard.AgainstFutureDate(dateValue, latestValidDate, nameof(dateValue));
        }

        [Test]
        public void AgainstFutureDate_GivenDateLaterThanLimit_ThrowsArgumentException()
        {
            DateTime dateValue = new DateTime(2019, 1, 1);
            DateTime latestValidDate = new DateTime(2018, 12, 31);

            Assert.Throws<ArgumentException>(() => Guard.AgainstFutureDate(dateValue, latestValidDate, nameof(dateValue)));
        }
    }
}
