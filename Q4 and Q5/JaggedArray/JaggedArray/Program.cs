using System;

namespace JaggedArray
{

	class Jagged
	{
		public int[][] arr = new int[1][];
		public int iRow1 = 0;
		public Jagged(int iRow)
		{
			if(iRow<0)
			{
				iRow = -iRow;
			}
			iRow1 = iRow;
			arr = new int[iRow][];
		}
        public void accept()
		{
			int iCnt = 0;
			int iCol = 0;
			try
			{
				for (iCnt = 0; iCnt < iRow1; iCnt++)
				{
					Console.WriteLine("Enter number of columns for " + iCnt + "th Row:");
					iCol = Convert.ToInt32(Console.ReadLine());

					if (iCol < 0)
					{
						iCol = -iCol;
					}
					arr[iCnt] = new int[iCol];
				}
				for (int i = 0; i < iRow1; i++)
				{
					for (int j = 0; j < arr[i].Length; j++)
					{
						Console.WriteLine("Enter the element for arr[" + i + "][" + j + "]:");
						arr[i][j] = Convert.ToInt32(Console.ReadLine());
					}
				}
			}
			catch(FormatException)
			{
				Console.WriteLine("Incorrect Input!");
			}
		}

		public void DisplayMax()
		{
			int iMax = 0;
			for (int i = 0; i < iRow1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
					if(iMax<arr[i][j])
					{
						iMax = arr[i][j];
					}
                }
            }
			Console.WriteLine("Maximum number in the Array:"+iMax);
		}
        
		public void DisplayMin()
		{
			int iMin = 999999999;
            for (int i = 0; i < iRow1; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (iMin > arr[i][j])
                    {
                        iMin = arr[i][j];
                    }
                }
            }
			Console.WriteLine("Minimum number in the Array:" + iMin);
		}
	}



    class MainClass
    {
		

        public static void Main(string[] args)
        {
			int iVar = 0;
			try
			{
				Console.WriteLine("Enter number of rows:");
				iVar = Convert.ToInt32(Console.ReadLine());
			}
			catch(FormatException)
			{
				Console.WriteLine("Incorrect Input!");				
			}
			if (iVar!=0)
			{
				Jagged jObj = new Jagged(iVar);

				jObj.accept();
				jObj.DisplayMax();
				jObj.DisplayMin();
			}
			else
			{
				Console.WriteLine("Error: Number of rows=0 according to input!");
			}
        }
    }
}