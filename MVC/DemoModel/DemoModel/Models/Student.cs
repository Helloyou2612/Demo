using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DemoModel.Models
{
    public class StudentRoom
    {
        public StudentRoom()
        {
            Students = new List<Student>();
            Rooms = new Room()
            {
                RoomId = 1,
                RoomName = "Phòng số 1"
            };
        }
        
        public List<Student> Students{ get; set; }
        public Room Rooms { get; set; }
    }
    public class Student
    {
        public long  StudentId { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }

    public class Room
    {
        //[Display(Name="Id Phòng")]
        public long RoomId { get; set; }
        public string RoomName { get; set; }
    }
}