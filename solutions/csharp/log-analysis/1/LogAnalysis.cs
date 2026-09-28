public static class LogAnalysis 
{
   
public static string SubstringAfter(this string str, string delimiter)
{
    
    int index = str.IndexOf(delimiter);
  return  str.Substring(index + delimiter.Length);
    
}
   
public static string SubstringBetween(this string str, string starDelimiter, string endDelimiter)
{
        int startIndex = str.IndexOf(starDelimiter) + starDelimiter.Length;

    int endIndex = str.IndexOf(endDelimiter);

    return str.Substring(startIndex, endIndex - startIndex);
    
}
    
public static string Message(this string logLine)
{ 
    return logLine.SubstringAfter(": "); 
}
   public static string LogLevel(this string logLine) { return logLine.SubstringBetween("[", "]"); }
}