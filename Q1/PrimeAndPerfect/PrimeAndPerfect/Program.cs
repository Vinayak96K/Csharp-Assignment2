using System;

namespace PrimeAndPerfect
{
	class Check
	{


		public bool bCheckPrime(int iNo)
		{
			int iCnt = 0;
			uint iFlag = 1;
			for (iCnt = iNo / 2; iCnt >= iNo / 2; iCnt--)
			{
				if (iNo % iCnt == 0)
				{
					iFlag = 0;
					break;
				}
             }
			if (iFlag == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public bool bCheckPerfect(int iNo)
		{
			uint iCnt = 0,iSum=0;
			bool bFlag=true;
			for (iCnt = 1; iCnt <= iNo / 2;iCnt++)
			{
				if(iNo%iCnt==0)
				{
					iSum = iSum + iCnt;
				}
				
			}
			if (iSum==iNo)
			{
				bFlag = true;
			}
			else
			{
				bFlag = false;
			}
			return bFlag;
		}
	}


	class MainClass
	{
		public static void Main(string[] args)
		{
			int iValue = 0;
			bool bRet = false;
			try
			{
				Console.WriteLine("Enter a positive integer number");
				iValue = Convert.ToInt32(Console.ReadLine());
			}
			catch (FormatException)
			{
				Console.WriteLine("Incorrect input!");
				try
				{
					Console.WriteLine("Enter a positive integer number");
					iValue = Convert.ToInt32(Console.ReadLine());

				}
				catch (FormatException)
				{
					Console.WriteLine("Incorrect input!");
				}
			}

			Check ch = new Check();

			bRet=ch.bCheckPrime(iValue);

			if(bRet)
			{
				Console.WriteLine(""+iValue+" is a prime number.");
			}
			else
			{
				Console.WriteLine("" + iValue + " is not a prime number.");				
			}

			bRet = ch.bCheckPerfect(iValue);
			if (bRet)
            {
                Console.WriteLine("" + iValue + " is a perfect number.");
            }
            else
            {
                Console.WriteLine("" + iValue + " is not a perfect number.");
            }
		}
	}
}