namespace task_ref_and_out
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, -2, 3, 23, 0, -12, 5, -10 }; //menfi musbete cevirme
            NegativeNumber(ref numbers);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //////////////////////////////////////////////////////////////////

            string text = "bu taskda a herfini tapmaq"; //a herfini tapmaq
            Console.WriteLine(A_Sentence(text));

            ////////////////////////////////////////////////////////////////////

            int[] SmallArray = { 3, -12, 4, 5, 6, 7, 8, }; // kicik eded tapmaq
            Console.WriteLine("Kicik eded " + Min(SmallArray));

            ////////////////////////////////////////////////////////////////////

            int num = 4302340;
            NumLenght(num);

            ////////////////////////////////////////////////////////////////////

            string said = "bu taskda saitleri tapmaqli"; // saitleri tapmaq
            VowelLetter(said);

            ///////////////////////////////////////////////////////////////////

            int[] reqemler = { 2, 4, 6, 8, 10 };
            NumericalAverage( reqemler);



        }
        static void NegativeNumber(ref int[] n)//menfi musbete cevirme
        {
            for (int i = 0; i < n.Length; i++)
            {
                if (n[i] < 0)
                {
                    n[i] *= -1;
                }
            }
        }



        static bool A_Sentence(string text) // a herfini tapmaq
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'a')
                {
                    return true;
                }
            }
            return false;
        }


        static int Min(int[] SmallArray) // kicik ededi tapmaq
        {
            int minimum = SmallArray[0];
            for (int i = 0; i < SmallArray.Length; i++)
            {
                if (SmallArray[i] < minimum)
                {
                    minimum = SmallArray[i];
                }
            }
            return minimum;
        }

        static void NumLenght(int num)
        {
            int count = 0;
            while (num > 0)
            {
                count++;
                num /= 10;
            }
            Console.WriteLine("daxil olan ededin reqemlerinin sayi " + count);
        }

        static void VowelLetter(string said) // saitleri tapmaq 
        {
            int count = 0;
            for (int i = 0; i < said.Length; i++)
            {
                if (said[i] == 'a' || said[i] == 'ı' || said[i] == 'o' || said[i] == 'u' || said[i] == 'e' || said[i] == 'ə' || said[i] == 'i' || said[i] == 'ö' || said[i] == 'ü')
                {
                    count++;
                }
            }
            Console.WriteLine("saidlerin sayi " +count);
        }

        static void NumericalAverage( int[] reqemler)
        {
            int count = 0;
            int sum = 0;
            for (int i = 0; i < reqemler.Length; i++)
            {
                sum = sum + reqemler[i];
                count++;
            }
            int edediorta = sum / count;
            Console.WriteLine( "reqemlerin ededi ortasi " + edediorta);

        }
    }
}
