namespace homework1_3
{

    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Please input order :");
                string order = Console.ReadLine();
                if (order == "+" || order == "-")
                {
                    while (order == "+" || order == "-")
                    {
                        Console.WriteLine("Please input row  :");
                        int row = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please input collumn :");
                        int col = int.Parse(Console.ReadLine());

                        float[,] number = new float[row, col];
                        for (int rownumber = 0; rownumber < row; ++rownumber)
                        {
                            for (int colnumber = 0; colnumber < col; ++colnumber)
                            {
                                Console.WriteLine("Please input num1 :");
                                number[rownumber, colnumber] = float.Parse(Console.ReadLine());
                            }
                        }

                        float[,] number2 = new float[row, col];
                        for (int rownumber2 = 0; rownumber2 < row; ++rownumber2)
                        {
                            for (int colnumber2 = 0; colnumber2 < col; ++colnumber2)
                            {
                                Console.WriteLine("Please input num2 :");
                                number2[rownumber2, colnumber2] = float.Parse(Console.ReadLine());
                            }
                        }


                        for (int rowcalculate = 0; rowcalculate < row; ++rowcalculate)
                        {

                            for (int colcalculate = 0; colcalculate < col; ++colcalculate)
                            {
                                if (order == "+")
                                {

                                    Console.Write("{0} ", plus(number[rowcalculate, colcalculate], number2[rowcalculate, colcalculate]));
                                }
                                else
                                {

                                    Console.Write("{0} ", minus(number[rowcalculate, colcalculate], number2[rowcalculate, colcalculate]));
                                }


                            }
                            Console.WriteLine(" ");
                            order = "0";
                        }

                    }

                }
                else
                {

                    break;
                }


            }

        }

        static float plus(float number1, float number2)
        {


            float sum = number1 + number2;


            return sum;
        }
        static float minus(float number1, float number2)
        {


            float sum = number1 - number2;


            return sum;
        }









    }
}
