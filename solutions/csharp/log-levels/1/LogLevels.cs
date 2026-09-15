static class LogLine
{
    public static string Message(string logLine)
    {
        int position = logLine.IndexOf(":");
         return logLine.Substring(position + 1).Trim();
    }

    public static string LogLevel(string logLine)
    {
        int inicio = logLine.IndexOf("[") + 1;
        int final = logLine.IndexOf("]");
        int cantidad = final - inicio;
        string palabraExtraida = logLine.Substring(inicio, cantidad).ToLower();
        
        return palabraExtraida;
    }

    public static string Reformat(string logLine)
    {

       return $"{Message(logLine)} ({LogLevel(logLine)})";
        
    }
}
