using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            // calling base gradebook
            this.Type = GradeBookType.Ranked;
        }
    }
}