using System.Collections;

var resp = IsValid("(]");
Console.WriteLine(resp);

bool IsValid(string s)
{
    var stack = new Stack();

    for (var i = 0; i < s.Length; i++)
    {
        if (s[i] == '(' || s[i] == '{' || s[i] == '[')
        {
            stack.Push(s[i]);
            continue;
        }
        else
        {
            if (stack.Count == 0)
                return false;

            var item = (char)stack.Peek();
            if ((s[i] == ')' && item != '(') ||
                (s[i] == '}' && item != '{') ||
                (s[i] == ']' && item != '['))
                return false;

            stack.Pop();
        }
    }

    return stack.Count == 0;
}
