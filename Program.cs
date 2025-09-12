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


            for (int i = 0; i < pyramid.Length; i++)//Array-filling loop
            {
                pyramid[i] = stars++;
                pyramid[i] = (2 * stars) - 1; //Math turns rows given by user into number of stars per row.
            }

            foreach (int i in pyramid) //performs the loop underneath for every value in "pyramid".
            {
                for (int starRow = 0; starRow < i; starRow++) 
                //Writes out no. of stars to the corresponding number in array. 
                //As long as starRow is less than the value in pyramid (i) it will write a star.
                //Example: vaule in pyramid=3. starRow will loop 3 times and write a star each time.
                    
                {
                    Console.Write("*"); //writes the stars on one line instead of making a new one
                    
                }
                Console.WriteLine("");//Needs to be here or else all the stars ends up on one long line.
                
            }

            
                

            



        }
    }
}
