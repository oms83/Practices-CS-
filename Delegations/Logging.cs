using System;
using System.IO;

public class Logger
{
    public delegate void LogAcion(string message);

    private LogAcion _logAcion;
    public Logger(LogAcion logAcion)
    {
        _logAcion = logAcion;
    }
    public void Log(string message)
    {
        _logAcion?.Invoke(message);
    }
}

public class Caller
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