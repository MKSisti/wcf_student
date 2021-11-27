using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace testwcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        IEnumerable<Student> GetAllStudents();

        [OperationContract]
        void CreateStudent(Student s);

        [OperationContract]
        void UpdateStudent(Student s);

        [OperationContract]
        void DeleteStudent(string cin);

        [OperationContract]
        Student GetStudent(string cin);
    }

    [DataContract]
    public class Student
    {
        [DataMember]
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idstudent { get; set; }
        [DataMember]
        [Required]
        public string first_name { get; set; }
        [DataMember]
        [Required]
        public string last_name { get; set; }
        [DataMember]
        [Required]
        public string email { get; set; }
        [DataMember]
        public string phone { get; set; }
        [DataMember]
        [Required]
        public string fil { get; set; }
        [DataMember]
        [Required]
        public string cin { get; set; }
    }
    
}
