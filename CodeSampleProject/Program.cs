class CodeSampleProject
{
  public static void Main()
  {
    int nth_term_input;
    string user_input;
    do
    {
      Console.WriteLine("Enter a for MSUBears(), b for FileOperation(), c for FibonnaciSequence(), or q to quit.");
      user_input = Console.ReadLine();
      if (user_input == "a")
        MSUBears();
      else if (user_input == "b")
        FileOperation();
      else if (user_input == "c")
      {
        Console.WriteLine("Enter a nth term");
        nth_term_input = Convert.ToInt32(Console.ReadLine());
        FibonacciSequence(nth_term_input);
      }
      Console.WriteLine("\n");
    } while (user_input != "q");
  }

  public static void MSUBears()
  {
    for (int i = 1; i < 101; i++)
    {
      if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine("MSUBears");
      else if (i % 3 == 0)
        Console.WriteLine("MSU");
      else if (i % 5 == 0)
        Console.WriteLine("Bears");
      else
        Console.WriteLine(i);
    }
  }
  public static void FileOperation()
  {
    string file_name_input;
    string line;
    string[] words;
    Console.WriteLine("Enter the name of a text file");
    file_name_input = Console.ReadLine();
    if (file_name_input.Substring(-4) != ".txt")
      file_name_input = file_name_input + ".txt";
    StreamReader stream = new StreamReader(file_name_input);
    line = stream.ReadLine();
    words = line.Split(' ');
    for (int i = 0; i < words.Length; i++)
    {
      if (words[i] == "bear")
      {
        Console.WriteLine("The first line of the text file contains the word \"bear\".");
        break;
      }
      else if (i == words.Length - 1)
        Console.WriteLine("The first line of the text file does not contain the word \"bear\".");
    }
    stream.Close();
  }
  public static void FibonacciSequence(int number)
  {
    int term = 1;
    int count = 0;
    int previous_term = 0;
    do
    {
      if (count == 0)
        Console.WriteLine("0");
      else if (count >= 1)
      {
        int next_term = term + previous_term;
        Console.WriteLine(term);
        previous_term = term;
        term = next_term;
      }
      count++;
    } while (count <= number);
  }
}
