using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        public enum ChangePosition
        {
            Left,
            Right,
            Up,
            Down
        }

        static void Main()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            char type = Convert.ToChar(Console.Read());

            #region declaration and init
            int rows = input;
            int cols = input;
            int counter = 1;
            int x = 0;
            int y = 0;

            byte turns = 0;

            bool hackFix = false;
            bool middle = false;

            int[,] matrix = new int[rows, cols];
            #endregion

            switch (type)
            {
                #region AMatrix
                case 'a':
                    for (int j = 0; j < cols; j++)
                        for (int i = 0; i < rows; i++)
                        {
                            matrix[i, j] = counter;
                            counter++;
                        }
                    break;
                #endregion
                #region BMatrix
                case 'b':
                    for (int j = 0; j < cols; j++)
                        for (int i = 0; i < rows; i++)
                        {
                            if (i == 0)
                            {
                                turns++;
                                if (turns % 2 == 0)
                                    counter = (rows * turns);
                                else if (turns > 1 && turns % 2 != 0)
                                    counter += rows + 1;
                            }
                            matrix[i, j] = counter;

                            if (turns % 2 == 0)
                                counter--;
                            else
                                counter++;
                        }
                    break;
                #endregion
                #region CMatrix
                case 'c':
                    matrix[rows - 1, 0] = 1;
                    matrix[0, cols - 1] = input * input;

                    turns = 2;
                    x = rows - 3;
                    y = -1;

                    while (turns < input * 2)
                    {
                        for (int i = 0; i < turns; i++)
                        {
                            counter++;
                            ++x;
                            ++y;
                            if (counter > input * input)
                            {
                                hackFix = true;
                                break;
                            }
                            matrix[x, y] = counter;
                        }
                        if (hackFix) break;
                        if (turns == input) middle = true;

                        if (middle)
                        {
                            x -= turns;
                            y -= turns - 1;
                            turns--;
                        }
                        else
                        {
                            x -= turns + 1;
                            y -= turns;
                            turns++;
                        }
                    }
                    break;
                #endregion
                #region DMatrix
                case 'd':
                    ChangePosition position = ChangePosition.Down;
                    int[] borders = new int[] { 0, input - 1, 1, input - 1 }; //Top, Down, Left, Right

                    matrix[0, 0] = 1;
                    for (int i = 2; i <= input * input; i++)
                    {
                        if (position == ChangePosition.Down)
                            borders[1] = Movement(ref x, borders[1], ref position);
                        else if (position == ChangePosition.Right)
                            borders[3] = Movement(ref y, borders[3], ref position);
                        else if (position == ChangePosition.Up)
                            borders[0] = Movement(ref x, borders[0], ref position);
                        else if (position == ChangePosition.Left)
                            borders[2] = Movement(ref y, borders[2], ref position);

                        matrix[x, y] = i;
                    }
                    break;
                #endregion
                default:
                    break;
            }
            PrintMatrix(matrix, input);
        }
        public static int Movement(ref int dir, int border, ref ChangePosition position)
        {
            switch (position)
            {
                case ChangePosition.Down:
                    ++dir;
                    if (dir == border)
                    {
                        position = ChangePosition.Right;
                        --border;
                    }
                    break;
                case ChangePosition.Right:
                    ++dir;
                    if (dir == border)
                    {
                        position = ChangePosition.Up;
                        --border;
                    }
                    break;
                case ChangePosition.Up:
                    --dir;
                    if (dir == border)
                    {
                        position = ChangePosition.Left;
                        ++border;
                    }
                    break;
                case ChangePosition.Left:
                    --dir;
                    if (dir == border)
                    {
                        position = ChangePosition.Down;
                        ++border;
                    }
                    break;
                default:
                    break;
            }
            return border;
        }

        public static void PrintMatrix(int[,] matrix, int input)
        {
            for (int i = 0; i < input; i++)
            {
                for (int j = 0; j < input; j++)
                {
                    if (j == input - 1) Console.Write(matrix[i, j]);
                    else Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
