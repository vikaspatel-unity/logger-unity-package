using UnityEngine;
public class Logger
{
    private static LogSettings logSettings;
    public static void Log(string tag,string message)
    {
        if (CanPrintLog())
        {
            Debug.Log(Application.productName + " " + tag + ": " + message);
        }
    }

    public static void LogError(string tag, string message)
    {
        if (CanPrintLog())
        {
            Debug.LogError(Application.productName + " " + tag + ": " + message);
        }
    }

    public static void LogWarning(string tag, string message)
    {
        if (CanPrintLog())
        {
            Debug.LogWarning(Application.productName + " " + tag + ": " + message);
        }
    }

    public static void LogAssertion(string tag, string message)
    {
        if (CanPrintLog())
        {
            Debug.LogAssertion(Application.productName + " " + tag + ": " + message);
        }
    }

    private static bool CanPrintLog()
    {
        if(logSettings==null)
        {
            logSettings = LogSettings.LoadInstance();
        }

        return logSettings.CanPrintLog();
    }
}
