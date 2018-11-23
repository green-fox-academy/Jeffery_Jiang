using System;



namespace Fileloggertest
{
    class Program
    {


        static void Main(string[] args)
        {
            NetworkAndFileloger logger =new NetworkAndFileloger("log.txt");

            logger.Log("first massage");
            
        }

        
    }
}
