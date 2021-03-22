public int solution(int[] numberst){
            int small = 0;
            for (int i = 1; i < numbers.Length; i++) //el error esta en que al inicializar i en 1, no se leia el primer elemento del arreglo, pudiendo este ser el monor numero
            {
                if (numbers[i] < small)
                {
                    small = numbers[i];
                }
                
            }
            
            Console.WriteLine(small);
}