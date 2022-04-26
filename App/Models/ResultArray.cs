namespace App.Models;
using System.ComponentModel.DataAnnotations;

public class ResultArray
{
    [Key]
    public int RaceID { get; set; }

    public string? DriverID { get; set; }

    public int Rankk { get; set; }
}