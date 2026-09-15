static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string formattedDepart  = (department ?? "OWNER").ToUpper();

        string idPrefix = id != null ? $"[{id}] - " : ""; 
        
        return $"{idPrefix}{name} - {formattedDepart}";
    }
}
