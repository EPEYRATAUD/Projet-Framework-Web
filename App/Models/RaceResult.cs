namespace App.Models;

public class RaceResult
{
    public int Id { get; set; }
    public Race Race { get; set; }
    public List<ResultItem> ResultItems { get; set; }
}