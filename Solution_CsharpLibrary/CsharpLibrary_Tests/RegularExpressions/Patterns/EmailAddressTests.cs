using NUnit.Framework;

namespace CsharpLibrary_Tests.RegularExpressions.Patterns
{
    [TestFixture]
    public class EmailAddressTests
    {
        // Example email addresses from https://blogs.msdn.microsoft.com/testing123/2009/02/06/email-address-test-cases/

        [Test]
        public void ValidEmail_Standard()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain.com"));
        }

        [Test]
        public void ValidEmail_DotAddressField()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("firstname.lastname@domain.com"));
        }

        [Test]
        public void ValidEmail_DotSubDomain()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@subdomain.domain.com"));
        }

        [Test]
        public void ValidEmail_Plus()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("firstname+lastname@domain.com"));
        }

        [Test]
        public void ValidEmail_IPDomain()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@123.123.123.123"));
        }

        [Test]
        public void ValidEmail_IPDomainSquareBrackets()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@[123.123.123.123]"));
        }

        [Test]
        public void ValidEmail_QuoteAddressField()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("\"email\"@domain.com"));
        }

        [Test]
        public void ValidEmail_DigitsAddressField()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("1234567890@domain.com"));
        }

        [Test]
        public void ValidEmail_DashDomainName()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain-one.com"));
        }

        [Test]
        public void ValidEmail_UnderscoreAddressField()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("_______@domain.com"));
        }

        [Test]
        public void ValidEmail_4LetterTLD()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain.name"));
        }

        [Test]
        public void ValidEmail_DotTLD()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain.co.jp"));
        }

        [Test]
        public void ValidEmail_DashAddressField()
        {
            Assert.IsTrue(CsharpLibrary.Validation.Check.IsEmailAddress("firstname-lastname@domain.com"));
        }

        [Test]
        public void InvalidEmail_Plain()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("plainaddress"));
        }
        
        [Test]
        public void InvalidEmail_Garbage()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("#@%^%#$@#$@#.com"));
        }

        [Test]
        public void InvalidEmail_MissingAddressField()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("@domain.com"));
        }

        [Test]
        public void InvalidEmail_Encoded()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("Joe Smith <email@domain.com>"));
        }

        [Test]
        public void InvalidEmail_MissingAt()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email.domain.com"));
        }

        [Test]
        public void InvalidEmail_MultipleAt()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain@domain.com"));
        }

        [Test]
        public void InvalidEmail_LeadingDot()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress(".email@domain.com"));
        }

        [Test]
        public void InvalidEmail_TrailingDotAddressField()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email.@domain.com"));
        }

        [Test]
        public void InvalidEmail_ConsecutiveDotsAddressField()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email..email@domain.com"));
        }

        [Test]
        public void InvalidEmail_UnicodeAddressField()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("あいうえお@domain.com"));
        }

        [Test]
        public void InvalidEmail_AppendedText()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain.com (Joe Smith)"));
        }

        [Test]
        public void InvalidEmail_MissingTLD()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain"));
        }

        [Test]
        public void InvalidEmail_DomainLeadingDash()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@-domain.com"));
        }

        // Removed, too many TLD's to check against
        //[Test]
        //public void InvalidEmail_InvalidTLD()
        //{
        //    Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain.web"));
        //}

        [Test]
        public void InvalidEmail_InvalidIPFormat()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@111.222.333.44444"));
        }

        [Test]
        public void InvalidEmail_ConsecutiveDotsDomain()
        {
            Assert.IsFalse(CsharpLibrary.Validation.Check.IsEmailAddress("email@domain..com"));
        }
    }
}
