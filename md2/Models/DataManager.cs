using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using md2.Models;

namespace md2.Models
{
    public class DataManager : IDataManager
    {
        private readonly DataCollection data = new DataCollection();

        // Method to print all data as a formatted string
        public string Print()
        {
            if (data.Teachers.Count == 0 && data.Students.Count == 0 &&
                data.Courses.Count == 0 && data.Assignments.Count == 0 &&
                data.Submissions.Count == 0)
            {
                return "Nav pieejamu datu.";
            }

            var result = "";
            data.Teachers.ForEach(t => result += t + "\n");
            data.Students.ForEach(s => result += s + "\n");
            data.Courses.ForEach(c => result += c + "\n");
            data.Assignments.ForEach(a => result += a + "\n");
            data.Submissions.ForEach(s => result += s + "\n");
            return result;
        }

        // Method to save data to a file in JSON format
        public void Save(string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonData = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonData);
        }

        // Method to load data from a JSON file
        public void Load(string filePath)
        {
            if (File.Exists(filePath))
            {
                var jsonData = File.ReadAllText(filePath);
                var loadedData = JsonSerializer.Deserialize<DataCollection>(jsonData);

                if (loadedData != null)
                {
                    data.Teachers = loadedData.Teachers;
                    data.Students = loadedData.Students;
                    data.Courses = loadedData.Courses;
                    data.Assignments = loadedData.Assignments;
                    data.Submissions = loadedData.Submissions;
                }
            }
        }

        // Method to create test data for initial setup
        public void CreateTestData()
        {
            var teacher = new Teacher { Name = "Anna", Surname = "Bērziņa", ContractDate = DateTime.Now, Gender = GenderType.Woman };
            data.Teachers.Add(teacher);

            var student = new Student { Name = "Jānis", Surname = "Ozoliņš", StudentIdNumber = "12345", Gender = GenderType.Man };
            data.Students.Add(student);

            var course = new Course { Name = "Matemātika", Teacher = teacher };
            data.Courses.Add(course);

            var assignment = new Assignment { Deadline = DateTime.Now.AddDays(7), Course = course, Description = "Pirmais mājasdarbs" };
            data.Assignments.Add(assignment);

            var submission = new Submission { Assignment = assignment, Student = student, SubmissionTime = DateTime.Now, Score = 95 };
            data.Submissions.Add(submission);
        }

        // Method to reset all data
        public void Reset()
        {
            data.Teachers.Clear();
            data.Students.Clear();
            data.Courses.Clear();
            data.Assignments.Clear();
            data.Submissions.Clear();
        }

        // Method to add a new student
        public void AddStudent(Student student)
        {
            data.Students.Add(student);
        }

        // Method to retrieve all students
        public List<Student> GetStudents()
        {
            return data.Students;
        }

        // Method to add a new teacher
        public void AddTeacher(Teacher teacher)
        {
            data.Teachers.Add(teacher);
        }

        // Method to retrieve all teachers
        public List<Teacher> GetTeachers()
        {
            return data.Teachers;
        }

        // Method to retrieve all data as a list of strings
        public List<string> GetAllData()
        {
            var allData = new List<string>();

            allData.AddRange(data.Students.Select(s => s.ToString()));
            allData.AddRange(data.Teachers.Select(t => t.ToString()));
            allData.AddRange(data.Courses.Select(c => c.ToString()));
            allData.AddRange(data.Assignments.Select(a => a.ToString()));
            allData.AddRange(data.Submissions.Select(s => s.ToString()));

            return allData;
        }

        // Additional methods can be added here for other types of data
    }
}
