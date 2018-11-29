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

  	}

}