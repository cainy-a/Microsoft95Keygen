using System;
using System.Diagnostics;

namespace Microsoft95Keygen
{
	public class CdKey
	{
		public CdKey(string start = "000", string last = "0000000")
			=> SetKey(start, last);

		private string _firstSection;
		private string _lastSection;

		public void SetKey(string first, string last)
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

		public string GetFirst()
			=> _firstSection;

		public string GetLast()
			=> _lastSection;
	}
}