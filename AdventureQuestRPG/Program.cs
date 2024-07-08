namespace AdventureQuestRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Adventure.Game();
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {   
                Console.WriteLine(e.ToString());
            }
            finally
            {
                Console.WriteLine("Match End !!");
            }
        }
    }
}
