using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractStudent edu = new SchoolStudent();
            edu.Study();

            //edu = new UniversityStudent();
            //edu.Study();

           // AbstractStudent pupl = new Pupil();
            //pupl.Study();

        }
    }

    public abstract class AbstractStudent
    {
        public void Study()
        {
            EducationalProcess();
        }

        public abstract void EducationalProcess();
    }

    public class SchoolStudent : AbstractStudent
    {
        public override void EducationalProcess()
        {
            Console.WriteLine("Study at school");
        }
    }

    public class UniversityStudent : AbstractStudent
    {
        public override void EducationalProcess()
        {
            Console.WriteLine("Study at university");
        }
    }

    public class Student
    {
        private IStudyStrategy _studyStrategy;

        public Student(IStudyStrategy studyStrategy)
        {
            _studyStrategy = studyStrategy;
        }

        public void Study()
        {
            _studyStrategy.Learn();
        }

        public void ChangeEducation()
        {
            _studyStrategy.ChangeEducation();
        }
    }

    public interface IStudyStrategy
    {
        void Learn();

        void ChangeEducation();
    }
    
    public class SchoolStrategy : IStudyStrategy
    {
        public void Learn()
        {
            Console.WriteLine("Study at school");
        }

        public void ChangeEducation()
        {
            Console.WriteLine("Study at university");
        }
    }

    public class UniversityStrategy : IStudyStrategy
    {
        public void Learn()
        {
            Console.WriteLine("Study at university");
        }

        public void ChangeEducation()
        {
            Console.WriteLine("Study at school");
        }
    }

    
}
