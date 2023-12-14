using System.Runtime.InteropServices;

namespace User0332.IntTypes.Tests;

class Program
{
	static int Main()
	{
		StackEvenInt num = new(uint.MaxValue-1);
		
		Console.WriteLine($"{num.ConvertTo<long>()}");

		unsafe
		{
		
			Console.WriteLine(
				$"int size: {Marshal.SizeOf<int>()}\nevenint size: {Marshal.SizeOf<EvenInt>()}\nstackevenint size: {sizeof(StackEvenInt)}"
			);
		}

		return 0;
	}
}