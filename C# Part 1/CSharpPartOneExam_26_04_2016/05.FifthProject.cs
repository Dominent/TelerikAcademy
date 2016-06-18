using System;


namespace FifthProject
{
    class FifthProject
    {
        static void Main()
        {
            uint valP = Convert.ToUInt32(Console.ReadLine());
            int valM = Convert.ToInt32(Console.ReadLine());

            //string valP = Convert.ToString(Convert.ToUInt32(Console.ReadLine()), 2);
            //int valM = Convert.ToInt32(Console.ReadLine());
            //int startpos = 0;
            //string output = "?";
            //char[] tempCh = new char[1];

            #region staro
            int length = Convert.ToString(valP, 2).Length;
            int startPos = 0;

            for (int i = 0; i < valM; i++)
            {
                uint input = Convert.ToUInt32(Console.ReadLine());
                int inputLength = Convert.ToString(input, 2).Length;
                int k = 0;

                for (int j = 0; j < inputLength; j++)
                {
                    uint bit = (((1U << j) & input) >> j);

                    uint perftBit = (((1U << k) & valP) >> k);

                    if (perftBit == bit)
                    {
                        if (k == 0)
                        {
                            startPos = j;
                            ++k;
                        }

                        for (int l = 1; l < length; l++)
                        {
                            bit = (((1U << (j + l)) & input) >> (j + l));

                            perftBit = (((1U << k) & valP) >> k);

                            if (perftBit == bit)
                            {
                                if (k < length - 1)
                                {
                                    ++k;
                                }
                                else
                                {
                                    for (int z = startPos; z < startPos + length; z++)
                                        input = input & (~(1U << z));
                                    k = 0;
                                    break;
                                }
                            }
                            else
                            {
                                k = 0;
                                startPos = 0;
                                break;
                            }
                        }
                    }
                }
                Console.WriteLine(input);
            }
        }

        #endregion

        //for (int i = 0; i < valM; i++)
        //{
        //    string temp = Convert.ToString(Convert.ToUInt32(Console.ReadLine()), 2);
        //    for (int j = temp.Length - 1, k = valP.Length - 1; j >= 0 ; j--)
        //    {
        //        if (temp[j] == valP[k])
        //        {
        //            if (k > 0)
        //            {
        //                if (k == valP.Length - 1)
        //                    startpos = j;
        //                --k;
        //            }
        //            if(k == 0)
        //            {
        //                tempCh = temp.ToCharArray();
        //                for (int l = j - startpos; l >= startpos; l++)
        //                {
        //                    tempCh[l] = '0';
        //                }
        //            }
        //        }
        //        else
        //        {
        //            k = valP.Length - 1;
        //        }
        //    }
        //    Console.WriteLine(Convert.ToString(Convert.ToInt32(new string(tempCh)), 10));



        //}

    }
}

