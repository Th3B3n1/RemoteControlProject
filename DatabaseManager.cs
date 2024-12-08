class DatabaseManager<T> where T : class
{
    private List<T> records = new List<T>();

    public void AddRecord(T record)
    {
        records.Add(record);
    }

    public void RemoveRecord(int id)
    {
        T? recordToRemove = records.Find(r => (int?)r?.GetType()?.GetProperty("Id")?.GetValue(r) == id);
        if (recordToRemove != null)
            records.Remove(recordToRemove);
    }

    public T? GetRecord(int id)
    {
        return records.Find(r => (int?)r?.GetType()?.GetProperty("Id")?.GetValue(r) == id);
    }

    public void PrintDatabase()
    {
        foreach (T record in records)
        {
            int? recordId = (int?)record?.GetType()?.GetProperty("Id")?.GetValue(record);
            string recordDetails = GetRecordDetails(record);
            Console.WriteLine($"Record ID: {recordId}, Details: {recordDetails}");
        }
    }
    protected int? GetRecordId(T record)
    {
        return (int?)record?.GetType()?.GetProperty("Id")?.GetValue(record);
    }

    protected string GetRecordDetails(T? record)
    {
        string details = "";

        foreach (var property in typeof(T).GetProperties())
        {
            details += $"{property.Name}: {property.GetValue(record)}, ";
        }

        return details.TrimEnd(',', ' ');
    }
}
