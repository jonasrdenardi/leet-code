var nums = new int[] { 1, 1, 1, 2, 2, 3 };

var result = RemoveDuplicates(nums);

Console.WriteLine(result);

static int RemoveDuplicates(int[] nums)
{
    if (nums.Length <= 2) return nums.Length;

    // Start in the third position as this is the maximum amount of duplication allowed.
    int slow = 2;

    for (int fast = 2; fast < nums.Length; fast++)
    {
        // If it is the same, it means that it is repeated, so the fast pointer will move forward until it finds a different one and bring it to replace the repeated position.
        // This way, the slow pointer can move forward.
        if (nums[fast] != nums[slow - 2])
        {
            nums[slow] = nums[fast];
            slow++;
        }
    }

    return slow;
}