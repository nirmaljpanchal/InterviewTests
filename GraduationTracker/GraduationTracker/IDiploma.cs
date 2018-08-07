namespace GraduationTracker
{
    public interface IDiploma
    {
        int Credits { get; set; }
        int Id { get; set; }
        IRequirement[] Requirements { get; set; }
    }
}