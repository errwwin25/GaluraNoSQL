using GaluraNoSQL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace GaluraNoSQL.ViewModels
{
    class ViewStudentModel : INotifyPropertyChanged
    {
        public Student StudentSet { get; set; }

        public Command SubmitEntry { get; set; }

        public string StudentCodeEntry { get; set; }

        public string StudentCodeDisplay { get; set; }

        public string StudentTitleEntry { get; set; }

        public string StudentTitleDisplay { get; set; }

        public string SubjectUnitEntry { get; set; }

        public string SubjectUnitDisplay { get; set; }

        public string CourseTitletEntry { get; set; }
        public string CourseTitletDisplay { get; set; }

        public int StudentIdDisplay { get; set; }
        public int StudentIdEntry { get; set; }

        public string StudentNameEntry { get; set; }
        public string StudentNameDisplay { get; set; }

        public DateTime StudentDateEntry { get; set; }
        public DateTime StudentDateDisplay { get; set; }

        public Command ClearEntry { get; set; }
        public ViewStudentModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new Student
                {
                    CourseCode = StudentCodeEntry,
                };

                StudentCodeDisplay = StudentCodeEntry;
                StudentTitleDisplay = StudentTitleEntry;
                SubjectUnitDisplay = SubjectUnitEntry;
                StudentIdDisplay = StudentIdEntry;
                CourseTitletDisplay = CourseTitletEntry;
                StudentNameDisplay = StudentNameEntry;


                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry));

                OnPropertyChanged(nameof(StudentTitleDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));

                OnPropertyChanged(nameof(SubjectUnitEntry));
                OnPropertyChanged(nameof(SubjectUnitDisplay));

                OnPropertyChanged(nameof(StudentIdDisplay));
                OnPropertyChanged(nameof(StudentIdEntry));

                OnPropertyChanged(nameof(CourseTitletEntry));
                OnPropertyChanged(nameof(CourseTitletDisplay));

                OnPropertyChanged(nameof(StudentNameEntry));
                OnPropertyChanged(nameof(StudentNameDisplay));


                OnPropertyChanged(nameof(StudentDateEntry));
                OnPropertyChanged(nameof(StudentDateDisplay));
            });

        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
