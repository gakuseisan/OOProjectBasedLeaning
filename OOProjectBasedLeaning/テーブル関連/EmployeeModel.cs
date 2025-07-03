public class EmployeeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public TimeSpan WorkTimeSum { get; set; }
    public int WorkDayCount { get; set; }
    public TimeSpan WorkTimeIn { get; set; }
    public TimeSpan WorkTimeOut { get; set; }
    public TimeSpan? WorkTimeRestSum { get; set; }
    public string WorkStatus { get; set; }
}
