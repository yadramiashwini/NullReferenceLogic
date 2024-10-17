namespace NullReferenceLogic
{
   public class Program
    {
        static void Main(string[] args)
        {
             try
                {
         
                string val = null;  
                Console.WriteLine(val.Length);
                
                }
                catch (Exception ex)
                {
                    Console.WriteLine("null reference logic"+ex.Message);
                }
            }
        }
    
}
