PalindromeCheck("abcba", true);
PalindromeCheck("abcde", false);
PalindromeCheck("Mr owl ate my metal worm", true);
PalindromeCheck("Never Odd Or Even", true);
PalindromeCheck("Never Even Or Odd", false);

static void PalindromeCheck(string message, bool shouldBePalindrome) => Console.WriteLine(IsPalindrome(message) == shouldBePalindrome ? "PASS" : "FAIL");

static bool IsPalindrome(string text)
{
    var message = Normalize(text);

    var reversedMessage = Reverse(message);

    var result = message == reversedMessage;

    return result;
}

static string Normalize(string message) => message.Replace(" ", "").ToLower();

static string Reverse(string message)
{
    char[] charArray = message.ToCharArray();
    Array.Reverse(charArray);

    return new string(charArray);
}