Console.WriteLine(ProductExceptSelf(new int[] { 1, 2, 3, 4 }));
//Console.WriteLine(ProductExceptSelf(new int[] { -1, 1, 0, -3, 3 }));

int[] ProductExceptSelf(int[] nums)
{
    int n = nums.Length;
    int[] answer = new int[n];

    // Produto acumulado da esquerda
    answer[0] = 1; // Não há elementos à esquerda do primeiro
    for (int i = 1; i < n; i++)
    {
        answer[i] = answer[i - 1] * nums[i - 1];
    }

    // Produto acumulado da direita
    int rightProduct = 1; // Não há elementos à direita do último
    for (int i = n - 1; i >= 0; i--)
    {
        answer[i] *= rightProduct;
        rightProduct *= nums[i];
    }

    return answer;
}

// Brute force  
//int[] ProductExceptSelf(int[] nums)
//{
//    var product = new int[nums.Length];

//    for (int i = 0; i < nums.Length; i++)
//    {
//        product[i] = 1;
//        for (int j = 0; j < nums.Length; j++)
//        {
//            if (j == i)
//                continue;

//            product[i] *= nums[j];
//        }
//    }

//    return product;
//}