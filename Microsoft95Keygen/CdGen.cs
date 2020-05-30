using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft95Keygen
{
	public static class CdGen
	{
		private static Random _rand = new Random();
		public static List<CdKey> Keygen(int count, bool saveToFile = false, string pathToSave = null)
		{
			var toReturn = new List<CdKey>();
			for (int i = 0; i < count; i++)
			{
				toReturn.Add(new CdKey(GenStart(), GenLast()));
			}

			if (saveToFile)
			{
				pathToSave ??= Directory.GetCurrentDirectory();
				using (StreamWriter sw = File.CreateText(pathToSave))
				{
					StringBuilder sb = new StringBuilder();
					foreach (var key in toReturn)
						sb.AppendLine(key.ToString());
					
					sw.Write(sb.ToString());
					sw.Flush();
					sw.Dispose();
				}
			}
			
			return toReturn;
		}

		public static CdKey Keygen() => new CdKey(GenStart(), GenLast());

		private static string GenStart()
		{
			string randNum = string.Empty;
			tryAgain:
			for (int i = 0; i < 3; i++)
			{
				randNum += _rand.Next(0,10).ToString();
			}

			if (randNum == "333" || randNum == "444" || randNum == "555" || randNum == "666" || randNum == "777" || randNum == "888" || randNum == "999")
			{
				randNum = String.Empty;
				goto tryAgain;
			} // try again if bad combo
			return randNum;
		}

		private static string GenLast()
		{
			string randNum = string.Empty;
			tryFullAgain:
			for (int i = 0; i < 7; i++)
			{
				randNum += _rand.Next(0,10).ToString();
			}
			var testProduct = 1;
			foreach (var num in randNum)
			{
				testProduct *= Convert.ToInt32(num.ToString());
				if (testProduct % 7 == 0) continue;
				randNum = String.Empty;
				goto tryFullAgain;
			}

			if (randNum[randNum.Length - 1] == '0' || randNum[randNum.Length - 1] == '8' || randNum[randNum.Length - 1] == '9')
			{
				randNum = string.Empty;
				goto tryFullAgain;
			}
			
			return randNum;
		}
	}
}