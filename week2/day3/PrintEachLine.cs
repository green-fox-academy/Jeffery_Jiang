namespace PrintEachLine
{
    class Program
    {
        static void Main(string[] args)
        {

            string filepath = @".\each-line.txt";

            string[] contents;
            try
            {
                contents = File.ReadAllLines(filepath);
                foreach (var content in contents)
                {
                    Console.WriteLine(content);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("cannot find the file");
            }
            finally
            {
                Console.ReadLine();
            }

            
        }
    }
}