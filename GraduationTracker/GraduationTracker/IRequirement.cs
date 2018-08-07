namespace GraduationTracker
{
    public interface IRequirement
    {
        ICourse[] Courses { get; set; }
        int Credits { get; set; }
        int Id { get; set; }
        int MinimumMark { get; set; }
        string Name { get; set; }
    }
}