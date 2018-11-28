using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;
using Moq;
using App;

namespace Tests
{
    public class TestViewMethods
    {
        [Fact]
        public void ShouldReturnEnumStartNew_AskForAction()
        {
            var testConsole = new TestConsole("p", new [] { "" });
            View sut = new View(testConsole, null);
            Assert.Equal(View.StartMenuAction.StartNew, sut.AskForAction());
        }


        [Fact]
        public void ShouldReturnEnumExit_AskForAction()
        {
            var testConsole = new TestConsole("e", new [] { "" });
            View sut = new View(testConsole, null);
            Assert.Equal(View.StartMenuAction.Exit, sut.AskForAction());
        }


		[Fact]
        public void ShouldPrintErrorMessage_AskForAction()
        {
            var testConsole = new TestConsole("jhkjh", new [] { "" });
            var expected = "Invalid choice, try again.";

            View sut = new View(testConsole, null);
            sut.AskForAction();
            Assert.EndsWith(expected + "\n", testConsole.GetOutput());
        }

    }
}