namespace PyramidBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till PyramidBuilder2000!\nDu ska nu få ange hur många rader din pyramid ska ha.\nAnge en siffra:");
            int levels = Convert.ToInt32(Console.ReadLine());
            int stars = 0;
            int[] pyramid = new int [levels];
            

            for (int i = 0; i < pyramid.Length; i++)
            {
                pyramid[i] = stars++;
                pyramid[i] = (2 * stars) - 1;
            }

            foreach (int i in pyramid)
            {
                for (int starRow=0; starRow<i; starRow++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine("");
            }




           

        }
    }
}
