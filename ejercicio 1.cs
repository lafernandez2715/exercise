public int smallest(int[] numbers)
        {
            Boolean exist =  true;
            int number = 1;
            int small = 0;
            while (exist == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == number)
                    {
                        exist = true;
                        if (numbers[i] == small) { small = 0; };
                        break;
                    }
                    else {
                        small = number;
                        exist = false;
                    }
                }
                number++;
            }
            return small;
        }