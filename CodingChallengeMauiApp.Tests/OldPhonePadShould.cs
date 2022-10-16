using CodingChallengeMauiApp.ViewModels;

namespace CodingChallengeMauiApp.Tests
{
    public class OldPhonePadShould
    {
        [Fact]
        public void ReturnLetters()
        {
            //Arrange
            var sut = new OldPhone();
            //Act
            string output = sut.OldPhonePad("4433555 555666");
            //Assert
            Assert.Equal("HELLO", output);
        }

        [Fact]
        public void ReturnEmpty()
        {
            //Arrange
            var sut = new OldPhone();
            //Act
            string output = sut.OldPhonePad(")))000#");
            //Assert
            Assert.Equal("", output);
        }
    }
}