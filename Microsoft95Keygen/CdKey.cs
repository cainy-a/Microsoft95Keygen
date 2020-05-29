using System;
using System.Diagnostics;

namespace Microsoft95Keygen
{
	public class CdKey
	{
		public CdKey(int start = 000, int last = 0000000)
			=> SetKey(start, last);

		private int _firstSection;
		private int _lastSection;

		public void SetKey(int first, int last)
		{
			if (first.ToString().Length == 3)
				_firstSection = first;
			else
				throw new ArgumentOutOfRangeException(nameof(first), "wrong amount of numbers!");

			if (last.ToString().Length == 7)
				_lastSection = last;
			else
				throw new ArgumentOutOfRangeException(nameof(last), "wrong amount of numbers!");
		}

		public override string ToString()
			=> $"{_firstSection.ToString()}-{_lastSection.ToString()}";

		public int GetFirst()
			=> _firstSection;

		public int GetLast()
			=> _lastSection;

		public int GetNumeric()
			=> Convert.ToInt32(_firstSection.ToString() + _lastSection.ToString());
	}
}