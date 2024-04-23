using Demo3Layer.BUS.Helper;
using Demo3Layer.DAL;
using Demo3Layer.DTO;
using System.Data;

namespace Demo3Layer.BUS
{
    public class StudentBUS
    {
        private readonly StudentDAL _studentDAL;

        public StudentBUS()
        {
            _studentDAL = new StudentDAL();
        }

        /// <summary>
        /// Gets the students by class identifier.
        /// </summary>
        /// <param name="classId">The class identifier.</param>
        /// <returns></returns>
        public List<Student> GetStudentsByClassId(int classId =0)
        {
            var result = new List<Student>();
            var data = _studentDAL.GetStudentsByClassId(classId);
            foreach (var student in data.Rows)
            {
                result.Add(new((DataRow)student));
            }
            return result;
        }

        public DataTable GetAll()
        {
            return _studentDAL.GetStudentsByClassId(0);
        }

        /// <summary>
        /// Adds the specified student.
        /// </summary>
        /// <param name="student">The student.</param>
        /// <returns></returns>
        public bool Add(Student student)
        {
            if (student == null || student.ClassId <= 0)
            {
                return false;
            }

            return _studentDAL.AddStudent(student);
        }

        public bool Delete(int id)
        {
            return _studentDAL.DeleteStudent(id);
        }

        /// <summary>
        /// Updates the specified student.
        /// </summary>
        /// <param name="student">The student.</param>
        /// <returns></returns>
        public bool Update(Student student)
        {
            if(student == null || student.ClassId <= 0)
            {
                return false;
            }

            return _studentDAL.UpdateStudent(student);
        }

        public void Export(string filePath)
        {
            var result = new List<Student>();
            var data = _studentDAL.GetStudentsByClassId(0);
            foreach (var student in data.Rows)
            {
                result.Add(new((DataRow)student));
            }


            FileHelper<Student> cSVFileHelper = new FileHelper<Student>();
            cSVFileHelper.WriteJsonFile(filePath, result);
        }

        public List<Student> ReadFile(string filePath)
        {
            FileHelper<Student> helper = new FileHelper<Student>();
            return helper.ReadJsonFile(filePath);
        }
    }
}
