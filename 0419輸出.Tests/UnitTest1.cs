namespace _0419輸出.Tests
{
	public class Tests
	{
		
		[Test]
		public void GetLeaveTime_9_12()
		{
			int expected = 3;
			var LeaveTime1 = new LeaveTime(9, 12);
			int actual = LeaveTime1.GetLeaveTime(9,12);

			Assert.AreEqual(expected , actual);

		}
		[Test]
		public void GetLeaveTime_8_12()
		{
			int expected = 3;
			var LeaveTime1 = new LeaveTime(8, 12);
			int actual = LeaveTime1.GetLeaveTime(8, 12);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_9_13()
		{
			int expected = 3;
			var LeaveTime1 = new LeaveTime(9, 13);
			int actual = LeaveTime1.GetLeaveTime(9, 13);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_9_14()
		{
			int expected = 4;
			var LeaveTime1 = new LeaveTime(9, 14);
			int actual = LeaveTime1.GetLeaveTime(9, 14);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_8_14()
		{
			int expected = 4;
			var LeaveTime1 = new LeaveTime(8, 14);
			int actual = LeaveTime1.GetLeaveTime(8, 14);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_9_18()
		{
			int expected = 8;
			var LeaveTime1 = new LeaveTime(9, 18);
			int actual = LeaveTime1.GetLeaveTime(9, 18);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_9_20()
		{
			int expected = 8;
			var LeaveTime1 = new LeaveTime(9, 20);
			int actual = LeaveTime1.GetLeaveTime(9, 20);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_18_20()
		{
			int expected = 0;
			var LeaveTime1 = new LeaveTime(18, 20);
			int actual = LeaveTime1.GetLeaveTime(18, 20);

			Assert.AreEqual(expected, actual);

		}
		[Test]
		public void GetLeaveTime_1_5()
		{
			int expected = 0;
			var LeaveTime1 = new LeaveTime(1, 5);
			int actual = LeaveTime1.GetLeaveTime(1, 5);

			Assert.AreEqual(expected, actual);

		}
	}
}