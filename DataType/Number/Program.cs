class Number {
    static void Main() {
        System.Console.WriteLine(1.6180339887498955);
        System.Console.WriteLine(1.6180339887498955M); // decimal
        System.Console.WriteLine(9_814_072_356);
        System.Console.WriteLine(6.023E23F);
        System.Console.WriteLine(0x002A);
        System.Console.WriteLine(0b101010);
        System.Console.WriteLine($"0x{42:X}");

        const double number = 1.6180339887498955;
        double result;
        string text;

        text = $"{number}";
        result = double.Parse(text);
        System.Console.WriteLine(text);
        System.Console.WriteLine(result);

        text = string.Format("{0:R}", number);
        result = double.Parse(text);
        System.Console.WriteLine(text);
        System.Console.WriteLine(result);

        int n = int.MaxValue;
        n = n+1;
        System.Console.WriteLine(n);
        
        text = "9.11E-31";
        float kgElectronMass = float.Parse(text);
        System.Console.WriteLine(kgElectronMass);

        string middleCText = "261.626";
        double middleC = System.Convert.ToDouble(middleCText);
        System.Console.WriteLine(middleC);
        bool boolean = System.Convert.ToBoolean(middleC);
        System.Console.WriteLine(boolean);

        //double aNumber;
        string input;
        System.Console.Write("Enter a number: ");
        input = System.Console.ReadLine();
        if(double.TryParse(input, out double aNumber)) {
            System.Console.WriteLine($"input was parsed successfully to {aNumber}.");
        }
        else {
            System.Console.WriteLine("The text entered was not a valid number.");
        }
    }
}
