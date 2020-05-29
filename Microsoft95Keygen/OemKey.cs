using System;

namespace Microsoft95Keygen
{
	public class OemKey
	{
		public OemKey(string start = "00000", string mid = "0000000", string last = "00000")
			=> SetKey(start, mid, last);
		
		private string _firstSection;
		private string _midSection;
		private string _lastSection;

		public void SetKey(string first, string mid, string last)
		{
			if (first.ToString().Length == 5)
				_firstSection = first;
			else
				throw new ArgumentOutOfRangeException(nameof(first), "wrong amount of numbers!");

			if (mid.ToString().Length == 7)
				_midSection = mid;
			else
				throw new ArgumentOutOfRangeException(nameof(mid), "wrong amount of numbers!");
			
			if (last.ToString().Length == 5)
				_lastSection = last;
			else
				throw new ArgumentOutOfRangeException(nameof(last), "wrong amount of numbers!");
		}

		public override string ToString()
			=> $"{_firstSection.ToString()}-OEM-{_midSection.ToString()}-{_lastSection.ToString()}";

		public string GetFirst()
			=> _firstSection;

		public string GetMid()
			=> _midSection;

		public string GetLast()
			=> _lastSection;
	}
}