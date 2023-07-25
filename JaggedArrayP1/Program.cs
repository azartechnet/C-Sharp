class Sample
{
    static void Main()
    {
        int[][] arr = new int[2][];//declare of the array
        arr[0] =new int[]{ 10,20,30};//Initialize the array
        arr[1] = new int[] { 11, 12, 13, 15 };

        //Travers array elements
        for (int i=0; i < arr.Length;i++)
            {
            for(int j=0; j < arr[i].Length;j++)
            {
                Console.WriteLine(arr[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
  
