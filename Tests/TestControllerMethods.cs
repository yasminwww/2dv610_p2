using System;
using Xunit;
using Moq;
using App;

namespace Tests
{
	public class UnitTestController 
	{
		private Mock<View> mockView;
		private Mock<GuessModel> mockModel;
		private Mock<TestConsole> i_console;
		private Mock<Controller> mockController;

    	public void SetUpMockObjects()
		{
			i_console = new Mock<TestConsole>("test", new string[] {"test"});
			mockModel = new Mock<GuessModel>(9);
			mockView = new Mock<View>(i_console.Object, mockModel.Object);
			mockController = new Mock<Controller>(mockView.Object, mockModel.Object);
		}


		[Fact]
		public void ShouldPrintMenuMessage_ActionController()
		{
			SetUpMockObjects();
			var sut = new Controller(mockView.Object, mockModel.Object);
			sut.ActionController();
			mockView.Verify(v => v.ShowMenu(), Times.Once());
		}

		[Fact]
		public void ShouldPrintStartGameMessage_ActionController()
		{
			SetUpMockObjects();
			mockView.Setup(m => m.AskForAction()).Returns(View.StartMenuAction.StartNew);
			var sut = new Controller(mockView.Object, mockModel.Object);
			sut.ActionController();
			mockView.Verify(v => v.ShowStartGuessingMessage(), Times.Once());			
		}

		[Fact]
		public void ShouldReturnTrueWhenStartNewIsChosen_ActionController()
		{
			SetUpMockObjects();
			mockView.Setup(m => m.AskForAction()).Returns(View.StartMenuAction.StartNew);

			var sut = new Controller(mockView.Object, mockModel.Object);
			Assert.True(sut.ActionController());
		}

		[Fact]
		public void ShouldReturnFalseWhenExitIsChosen_ActionController()
		{
			SetUpMockObjects();
			mockView.Setup(v => v.AskForAction()).Returns(View.StartMenuAction.Exit);

			var sut = new Controller(mockView.Object, mockModel.Object);
			Assert.False(sut.ActionController());
		}

		[Fact]
		public void ShouldReturn_ActionController()
		{
			SetUpMockObjects();
			mockView.Setup(m => m.GetGuessedNumber()).Returns(8);
			var sut = new Controller(mockView.Object, mockModel.Object);
			
			Assert.False(sut.PlayGame());			
		}
  	}
}