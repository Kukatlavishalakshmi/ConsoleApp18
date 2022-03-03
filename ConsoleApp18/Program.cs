using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
	internal class queue
	{
		public static void Main()
		{
			Queue<int> callerIds = new Queue<int>();
			callerIds.Enqueue(1);
			callerIds.Enqueue(2);
			callerIds.Enqueue(3);
			callerIds.Enqueue(4);

			foreach (var id in callerIds)
				Console.WriteLine(id);
			Console.ReadLine();
		}
	}
}











