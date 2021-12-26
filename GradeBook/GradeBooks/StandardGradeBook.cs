using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isweighted) : base(name, isweighted) {
            // calling base gradebook
            this.Type = GradeBookType.Standard;
            this.IsWeighted = isweighted;
        }
    }
}