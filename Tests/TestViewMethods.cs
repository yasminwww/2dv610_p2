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


    }
}