using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Microsoft95Keygen
{
	public static class OemGen
	{
		static Random _rand = new Random();
		public static List<OemKey> Keygen(int count, bool saveToFile = false, string pathToSave = null)
		{
			var toReturn = new List<OemKey>();
			for (int i = 0; i < count; i++)
			{
				var key = new OemKey(GenFirst(), GenMid(), GenLast());
				toReturn.Add(key);
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
		
		public static OemKey Keygen() => new OemKey(GenFirst(), GenMid(), GenLast());

		public static string GenFirst()
		{
			var workingString = string.Empty;
			workingString += _rand.Next(001, 367).ToString();

			switch (workingString.Length)
			{
				case 2:
					workingString = workingString.Insert(0, "0");
					break;
				case 1:
					workingString = workingString.Insert(0, "00");
					break;
			}
			
			workingString += _rand.Next(95, 100).ToString(); // could implement numbers 00, 01, 02, 03, and 04 but can't be bothered
			return workingString;
		}
		
		public static string GenMid()
		{
			string randNum = string.Empty;
			tryFullAgain:
			randNum += "0";
			for (int i = 0; i < 6; i++)
			{
				tryNumAgain:
				randNum += _rand.Next(0,10).ToString();

				var product = 0;
				foreach (var num in randNum)
				{
					product *= Convert.ToInt32(num);
					if (product % 7 != 0)
						goto tryNumAgain;
				}
			}

			if (randNum[6] == '0' || randNum[6] == '8' || randNum[6] == '9')
			{
				randNum = string.Empty;
				goto tryFullAgain;
			}
			
			return randNum;
		}
		
		public static string GenLast()
		{
			var workingString = string.Empty;
			for (int i = 0; i < 5; i++)
			{
				workingString += _rand.Next(0, 10);
			}

			return workingString;
		}
	}
}