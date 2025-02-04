using static System.Console;

class Number {
    static void Main() {
        WriteLine(@"begin
            /\
           /  \
          /____\ ""
        end");

        string firstName = "Fe", lastName = "Chuang";
        WriteLine($@"Your full name is {
         firstName } { lastName }");
        
        string text = string.Format("Your full name is {0} {1}.", firstName, lastName);
        WriteLine(text);
        text = string.Concat(firstName, lastName);
        WriteLine(text);

        string option = "/help";
        int result = string.Compare(option, "/Help");
        WriteLine(result);
        result = string.Compare(option, "/Help", true);
        WriteLine(result);

        bool isCh = lastName.StartsWith("Ch");
        WriteLine(isCh);
        bool isPhd = lastName.EndsWith("Ph.D.");
        WriteLine(isPhd);

        string color = "_Pink_";
        WriteLine(color.ToLower());
        WriteLine(color.ToUpper());

        string username = "   Ivy      ";
        WriteLine(username.Trim());
        WriteLine(username.TrimStart());
        WriteLine(username.TrimEnd());

        string testStr = @"\Thi\s \is \a \str\i\ng.";
        WriteLine(testStr.Replace(@"\", ""));

        WriteLine("This is a string.");
        Write("This is a string." + System.Environment.NewLine);

        string palindrome = "Never odd or even";
        WriteLine(
            $"The palindrome \"{palindrome}\" is"
            + $" {palindrome.Length} characters."
        );

        bool boolean = true;
        text = boolean.ToString();
        WriteLine(boolean);
    }
}
