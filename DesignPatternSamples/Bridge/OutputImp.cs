using System.Configuration;

namespace Bridge
{
    public static class OutputImp
    {
        public static Output Get()
        {
            var outputType = ConfigurationManager.AppSettings["OutputType"];

            if (outputType == "Console")
                return new ConsoleOutput();
            else if (outputType == "File")
                return new FileOutput();
            else
                return new DefaultOutput();
        }
    }
}
