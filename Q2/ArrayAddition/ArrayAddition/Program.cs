using System;

namespace ArrayAddition
{
	class ArrayAdd
	{
		int[] arr = new int[10];

		public ArrayAdd(int[] arr1)
		{
			arr = arr1;
		}

		public int iAdd()
		{
			int iSum = 0, iCnt = 0;

			for (iCnt = 0; iCnt < arr.Length; iCnt++)
			{
				iSum = iSum + arr[iCnt];
			}
            
			return iSum;
		}
	}
	class MainClass
	{

		public static void Main(string[] args)
		{
			
			int iVar;
			int iRet;
			Console.WriteLine("Enter size of arr");
			iVar = Convert.ToInt32(Console.ReadLine());
			int[] arr2 = new int[iVar];
			Console.WriteLine("Enter elements of array");
			for (int iCnt = 0; iCnt < iVar;iCnt++)
			{
				arr2[iCnt] = Convert.ToInt32(Console.ReadLine());   	
			}
            
			ArrayAdd aObj = new ArrayAdd(arr2);
			iRet = aObj.iAdd();
			Console.WriteLine("Addition of array elements: "+iRet);
		}
	}
}