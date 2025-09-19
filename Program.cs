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
            int spaces = levels;
            

            Console.WriteLine("Vill du bygga din pyramid upp-och-ner? [y] [n]");
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




            switch (flipped)//Lets the user choose if they want to have a pyramid upside down or not.
            {
                case "y":

                    Console.Clear();
                    
                    foreach (int i in reverse)
                    {
                        for (int j=0; j<levels; j++)//Here we start by adding correct number of spaces by using a nestled loop.
                        {
                            Console.Write(" ");
                        }
                        levels++;//Will increase by 1 for every lap in the foreach-loop, thus pushing the next row of stars further in. 

                        for (int j = 1; j <= i; j++)//Then we add stars corresponding to the value in reverse-array. High-to-low.
                        {

                            Console.Write("*");
                        }
                        Console.WriteLine("");

                    }


                    break;



                default://User ends up here if choosing anything but "y". 

                    Console.Clear();//Clears the screen.
                    foreach (int i in pyramid)
                    {
                        for (int x = 0; x < spaces; x++)//Almost the same nestled loop as the reversed.
                                                   //Here we start from the no. of levels given by user and work our way down to zero.
                        {
                            Console.Write(" ");
                        }
                        spaces--;//After every row is written with correct spaces, the next lap will result in one less spacing.

                        for (int j = 1; j <= i; j++)
                        {

                            Console.Write("*");
                        }
                        Console.WriteLine("");

                    }

                    break;

               
                    


            }

            








          





        }
    }
}
