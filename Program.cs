namespace reversArray
{
    internal class Program
    {
        int[]orginalArray;
        static void Main(string[] args)
        {
            
        }
        private void ReverseArray()
        {
            int start = 0;
            int temp = 0;
            int end = orginalArray.Length;
            while(start < end)
            {
                temp = orginalArray[start];
                orginalArray[start] = orginalArray[end];
                orginalArray[end] = temp;
                start++;
                end--;
            }

        }
        private void PrintArray()
        {
            foreach(int value in orginalArray)
            {
                Console.Write($"{value }");
            }
        }
    }
}