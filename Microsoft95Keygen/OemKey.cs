using System;

namespace Microsoft95Keygen
{
	public class OemKey
	{
		public OemKey(int start = 00000, int mid = 0000000, int last = 00000)
			=> SetKey(start, mid, last);
		
		private int _firstSection;
		private int _midSection;
		private int _lastSection;

		public void SetKey(int first, int mid, int last)
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

		public int GetFirst()
			=> _firstSection;

		public int GetMid()
			=> _midSection;

		public int GetLast()
			=> _lastSection;

		public int GetNumeric()
			=> Convert.ToInt32(_firstSection.ToString() + _midSection.ToString() + _lastSection.ToString());
	}
}