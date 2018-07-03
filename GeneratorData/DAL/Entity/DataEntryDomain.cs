
namespace GeneratorData.DAL.Entity
{
   public class DataEntryDomain
   {
       private int _numberStudents;
        public int NumberStudents
        {
            get => _numberStudents;
            set => _numberStudents = value;
        }
        public double Min { get; set; }
        public double Max { get; set; }
        public double FixedAvg { get; set; }
        public double Tolerance { get; set; }

    }
}
