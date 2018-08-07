namespace GraduationTracker
{
    public interface IStudent
    {
        ICourse[] Courses { get; set; }
        int Id { get; set; }
        STANDING Standing { get; set; }
    }
}