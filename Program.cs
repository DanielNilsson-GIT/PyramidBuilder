namespace PyramidBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till PyramidBuilder2000!\nDu ska nu få ange hur många rader din pyramid ska ha.\nAnge en siffra:");
            int levels = Convert.ToInt32(Console.ReadLine());
            int stars = 0;
            int[] pyramid = new int[levels];
            int[] reverse = new int[levels];
            int k = levels;

            Console.WriteLine("Vill du bygga din pyramid upp-och-ner? [Y] [N]");
            string flipped = Console.ReadLine();

          




            for (int i = 0; i < pyramid.Length; i++)//first we fill up the pyramid array with the correct number of stars on each level of the pyramid
            {
                stars++;
                pyramid[i] = (2 * stars) - 1;


            }
            for (int i = 0; i < pyramid.Length; i++)
            {

                reverse[i] = pyramid[levels - 1];//Then we fill the next array backwards by starting in the end of "pyramids" and working our way down to slot "0"
                levels--;
            }

            foreach (int i in pyramid)
            {
                for (int x = 0; x < k; x++)
                {
                    Console.Write(" ");
                }
                k--;

                for (int j=1; j<=i; j++)
                {
                   
                    Console.Write("*");
                }
                Console.WriteLine("");
              
                
            }

            Console.WriteLine("Progarmmet slut.");







          








        }
    }
}
