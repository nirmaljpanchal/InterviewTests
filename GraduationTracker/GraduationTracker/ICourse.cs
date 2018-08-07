namespace GraduationTracker
{
    public interface ICourse
    {
        int Credits { get; }
        int Id { get; set; }
        int Mark { get; set; }
        string Name { get; set; }
    }
}