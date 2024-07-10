using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Course_Registration_Demo
{
    public class SeedInformation
    {
        public static List<Student> SeedStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student(){
                FirstName = "Steve",
                LastName = "NotAnAlien",
                Gender = Gender.NonBinary,
                PhoneNumber = "barf-blark-001035-x28",
                Address = "Totally here on earth: 123 earth lane",
                Email = "What's that?",
                ImageLocation = "Pictures/Alien.jpg"
            });

            students.Add(new Student()
            {
                FirstName = "Bartholomew",
                LastName = "Simpson",
                Gender = Gender.Male,
                PhoneNumber = "000-111-1234",
                Address = "123 Golf Rd, Pinellas FL, 33760",
                Email = "eatmyshorts@ptc.edu",
                ImageLocation = "Pictures/Bart.png"
            });

            students.Add(new Student()
            {
                FirstName = "Synthia",
                LastName = "Doll",
                Gender = Gender.Female,
                PhoneNumber = "000-222-3456",
                Address = "1570 International Pickmin Dr, Pinellas FL, 33760",
                Email = "synthiashesareallycooldancer@gmail.com",
                ImageLocation = "Pictures/Synthia.jpg"
            });

            return students;
        }

        public static List<Course> SeedCourses()
        {
            List<Course> course = new List<Course>();

            course.Add(new Course()
            {
                CourseName = "Computer Systems & Information Technology",
                CourseDescription = "Training includes networking protocols, basic routing concepts and cybersecurity.\r\nPrepare for the A+, Network+, and Security+ certification exam.\r\nLength: 900 hrs (approx 9 mos) Tuition: $2,628 Other: $2,151 (bks, equip & fees; estimate)"
            });
            course.Add(new Course()
            {
                CourseName = "Web Development",
                CourseDescription = "Develop, maintain and market business-oriented web sites. Course content\r\nincludes internet programming, graphic design, database administration and\r\nelectronic commerce fundamentals.\r\nLength: 1050 hrs (approx 11 mos) Tuition: $3,066 Other: $1,798 (bks, equip & fees; estimate)"
            });
            course.Add(new Course()
            {
                CourseName = ".NET Application Development & Programming",
                CourseDescription = "Prepare for employment as a software developer. Learn about creating dynamic\r\nwebsites, iOS and Android phone apps and computer software.\r\nLength: 1050 hrs (approx 11 mos) Tuition: $3,066 Other: $975 (bks, equip & fees; estimate)"
            });
            course.Add(new Course()
            {
                CourseName = "Applied Cybersecurity",
                CourseDescription = "Prepares students for employment as Information Security Managers, Network\r\nSecurity Professionals, Security Penetration Testing Professionals, and Systems\r\nSecurity Practitioners.\r\nLength: 750 hrs (approx 8 mos) Tuition: $2,190 Other: $1,889 (bks, equip & fees; estimate)"
            });
            course.Add(new Course()
            {
                CourseName = "Network Support Services",
                CourseDescription = "Learn to troubleshoot complex computer network issues. Prepare to earn\r\ncertifications in Network+, Cisco Certified Network Associate (CCNA), Certified\r\nWireless Security Administrator (CWNA) and Security+.\r\nLength: 1050 hrs (approx 11 mos) Tuition: $3,066 Other: $1,418 (bks, equip & fees; estimate)"
            });
            course.Add(new Course()
            {
                CourseName = "Accounting Operations",
                CourseDescription = "Prepare for a career in a financial business environment. Training in QuickBooks\r\nand related software will be used to enhance workplace productivity.\r\nLength: 900 hrs (approx 9 mos) Tuition: $2,628 Other: $1,081 (bks, equip & fees; estimate)"
            });

            return course;
        }
    }
}
