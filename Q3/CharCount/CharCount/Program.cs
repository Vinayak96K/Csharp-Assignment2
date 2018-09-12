using System;

namespace CharCount
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			int iCapitalCount = 0, iSmallCount =0, iSymbolCOunt=0;
			Console.WriteLine("Enter total number of characters:");
			int iNO = 0;
			iNO = Convert.ToInt32(Console.ReadLine());
			char[] ch = new char[iNO];
			Console.WriteLine("Enter name");
			for (int iCnt = 0; iCnt < ch.Length;iCnt++)
			{
				ch[iCnt] = Convert.ToChar(Console.Read());
			}
			Console.WriteLine("");
			for (int iCnt = 0; iCnt < ch.Length; iCnt++)
			{
				if (ch[iCnt] >= 'A' && ch[iCnt] <= 'Z')
				{
					iCapitalCount++;
				}
				else if (ch[iCnt] >= 'a' && ch[iCnt] <= 'z')
				{
					iSmallCount++;
				}
				else
				{
					iSymbolCOunt++;
				}

			}
			Console.WriteLine("Capital characters: " + iCapitalCount + " Small characters: " + iSmallCount + " Other Symbols: " + iSymbolCOunt);

        }
    }
}
