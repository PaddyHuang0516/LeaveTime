using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _0419輸出
{
	public class Program
	{
		//計算一天總請假時數，每天上班時間9~18點  12~13是休息時間
		//若請假9~18  傳回8(小時)
		//9~17  7
		//9~12  3
		//9~13  3 (午休)
		//12~14 1
		//8~18  8
		//9~23  8
		static void Main(string[] args)
		{
			LeaveTime me = new LeaveTime(13, 18);

            Console.WriteLine($"你請了{me.GetLeaveTime(13,18)}小時的假");
        }

		
	}
	public class LeaveTime
	{
		private int Begin { get; }
		private int End { get; }

		public LeaveTime(int begin, int end)
		{
			if (begin < 0)
			{
				throw new ArgumentOutOfRangeException("時間不可以小於0或大於24");
			}
			if (begin > 24)
			{
				throw new ArgumentOutOfRangeException("時間不可以小於0或大於24");
			}
			if (end < 0)
			{
				throw new ArgumentOutOfRangeException("時間不可以小於0或大於24");
			}
			if (end > 24)
			{
				throw new ArgumentOutOfRangeException("時間不可以小於0或大於24");
			}
			if (begin > end)
			{
				throw new Exception("開始時間不可大於結束時間");
			}

			this.Begin = begin;
			this.End = end;
		}

		public int GetLeaveTime(int begin, int end)
		{
			List<int> work = new List<int>() { 10, 11, 12, 14, 15, 16, 17, 18 };
			//for(int i = startwork; i <= endwork; i++)
			//{
			//	work.Add(i);
			//}
			//work.Remove(13);

			List<int> leave = new List<int>();
			for (int m = begin; m <= end; m++)
			{
				leave.Add(m);
			}

			IEnumerable<int> commonTime = work.Intersect(leave);

			return commonTime.Count() ;


		}
	}
}
