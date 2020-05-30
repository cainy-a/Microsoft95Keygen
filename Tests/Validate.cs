using System;
using Microsoft95Keygen;

namespace Tests
{
	public partial class Tests
	{
		private bool Validate(CdKey key)
		{
			var total = 1;
			
			foreach (var num in key.GetLast())
				total *= Convert.ToInt32(num.ToString());

			var valid = key.GetFirst() != "333" && key.GetFirst() != "444" && key.GetFirst() != "555" &&
					key.GetFirst() != "666" && key.GetFirst() != "777" && key.GetFirst() != "888" &&
					key.GetFirst() != "999" && (key.GetFirst().Length == 3 && key.GetLast().Length == 7) &&
					total % 7 == 0 && (key.GetLast()[6] != '0' && key.GetLast()[6] != '8' && key.GetLast()[6] != '9');

			return valid;
		}

		private bool Validate(OemKey key)
		{
			var year = Convert.ToInt32(key.GetFirst().Substring(3, 2));
			var day = Convert.ToInt32(key.GetFirst().Substring(0, 3));

			var midProduct = 1;

			foreach (var num in key.GetMid())
				midProduct *= Convert.ToInt32(num.ToString());

			var valid = ((year > 94 && year < 100) || (year < 5 && year >= 0)) &&
							(day >= 0 && day < 367 && ((midProduct % 7 == 0) && key.GetMid()[6] != '0' &&
													key.GetMid()[6] != '8' &&
													key.GetMid()[6] != '9' && key.GetLast().Length == 5));
			return valid;
		}
	}
}