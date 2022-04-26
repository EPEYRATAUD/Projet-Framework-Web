namespace App.Models;

public class RacesArray
{
    public int Id { get; set; }
    public Race? Race { get; set; }
    public List<ResultArray>? ResultArrays { get; set; }
}