using System;
using System.IO;

public class clsLogger
{
    //public Action<string> Logger;
    public event Action<string> Logger;

    public clsLogger(Action<string> logger)
    {
        Logger = logger;
    }

    public void Log(string message)
    {
        if (Logger != null)
        {
            Logger(message);
        }
    }
}
public class caller
{
    public static void LogToScreen(string message) => Console.WriteLine(message);

    public static void LogToFile(string message)
    {
        using (StreamWriter writer = new StreamWriter("log.txt", false))
        {
            writer.WriteLine(message);
        }
    }
    public static void run()
    {
        Logger logToFile = new Logger(LogToFile);
        Logger logToScreen = new Logger(LogToScreen);
        
        logToFile.Log("this message will be loggin to file");
        logToScreen.Log("this message will be loggin to screen");
    }
}