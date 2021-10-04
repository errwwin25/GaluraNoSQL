using GaluraNoSQL.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Firebase.Database;
using Firebase.Database.Query;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace GaluraNoSQL.Services
{
   public class DFfirebase
    {
        FirebaseClient client;

        public DFfirebase()
        {
            client = new FirebaseClient("https://xamarin-a543e-default-rtdb.firebaseio.com/");
        }
        public ObservableCollection<Student> getStudent()
        {
            var studentData = client
                .Child("Student")
                .AsObservable<Student>()
                .AsObservableCollection();

            return studentData;
        }
        public async Task AddStudent(string StudentID, string Name, string CourseCode, string CourseTitle, string Units)
        {
            Student em = new Student() { StudentID = StudentID, name = Name, course = CourseCode, courses = CourseTitle, unit = Units, };
            {
                await client
                    .Child("Student")
                    .PostAsync(em);
            }
        }
    }
}
