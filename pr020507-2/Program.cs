namespace pr020507_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 0,0, 1, 1, 1, 2, 2, 3, 3, 4,5,5,5,6 };

            Console.WriteLine("Number of Uniqe Items is: "+ CountOfUniqueItems(nums));
        }
    
        public static int CountOfUniqueItems(int[] nums)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(nums[0]);
            int buf= 0;
            for (int i = 1;i<nums.Length;i++)
            {
                if (stack.Peek() != nums[i]) stack.Push(nums[i]);

                

            }

            return stack.Count();
        }
    
    }
}