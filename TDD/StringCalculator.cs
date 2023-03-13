
namespace TDD
{
	public class StringCalculator
	{
		public int Calculate(string arg)
		{
			if (arg == "") return 0;

			var isNumeric = int.TryParse(arg, out int n);
			if(isNumeric && n>=0 && n<=1000) return n;
			if (isNumeric && n > 1000) return 0;
			if(isNumeric && n<0) throw new ArgumentOutOfRangeException();

			char[] delimiters = { ',', '\n' };
			if (arg[0] == '/' && arg[1] == '/')
			{
				delimiters.Append(arg[2]);
				arg = arg.Remove(0, 3);
			}

			var words = arg.Split(delimiters);
			int[] values = new int[words.Length];

			int finalValue = 0;
			for (int i = 0; i < words.Length; i++)
			{
				int.TryParse(words[i], out values[i]);
				if (values[i] <= 1000)
				{
					finalValue += values[i];
				}
			}

			return finalValue;
		}
	}
}
