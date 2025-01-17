var nums = new int[] { 1, 1, 1, 2, 2, 3 };

var result = RemoveDuplicates(nums);

Console.WriteLine(result);

static int RemoveDuplicates(int[] nums)
{
    if (nums.Length <= 2) return nums.Length;

    // Começa na terceira posição pois é o maximo permitido em duplicidade.
    int slow = 2;

    for (int fast = 2; fast < nums.Length; fast++)
    {
        // Se for igual quer dizer que está repetido, então o ponteiro do fast vai percorrer até encontrar um diferente e trazer para o substituir a possição repetida.
        // Assim  ponteiro slow pode ir para frente.
        if (nums[fast] != nums[slow - 2])
        {
            nums[slow] = nums[fast];
            slow++;
        }
    }

    return slow;
}