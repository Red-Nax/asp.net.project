using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models;

public class Time
{
    private DateTime now;
    private DateTime deadline;
    
    
    public Time(DateTime now, DateTime deadline)
    {
        this.now = now;
        this.deadline = deadline;
    }

    public double calculate()
    {
        TimeSpan timeDifference = deadline - now;
        return timeDifference.TotalHours;
    }

    
    
    
}