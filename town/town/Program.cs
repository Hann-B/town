using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace town
{
    class Program
    {
        static void Main(string[] args)
        {
            var studio = new House("Empty Nester")
            {
                Name = "The Tower Studio",
                NumberOfRoom=2,
                ConstructionMaterial="Brick",
                Height=20,
                Width=16,
                Length=19,
                Floors=2,
                BedRooms=1,
                BathRooms=1,
            };
            var oneOne = new House("Economical")
            {
                Name = "Small House",
                NumberOfRoom = 5,
                ConstructionMaterial = "Wood",
                Height = 30,
                Width = 35,
                Length = 30,
                Floors = 2,
                BedRooms = 1,
                BathRooms = 1,
            };
            var twoTwo = new House("Ranch")
            {
                Name = "The Pool House",
                NumberOfRoom = 9,
                ConstructionMaterial = "Wood",
                Height = 16,
                Width = 65,
                Length = 67,
                Floors = 1,
                BedRooms = 2,
                BathRooms = 2,
            };
            var threeThree = new House("Craftmans")
            {
                Name = "The Home Office",
                NumberOfRoom = 12,
                ConstructionMaterial = "Concrete",
                Height = 27,
                Width = 72,
                Length = 66,
                Floors = 1,
                BedRooms = 3,
                BathRooms = 3,
            };
            Console.WriteLine();
            var bankBranch = new Bank("Bank Branch")
            {
                Name="Branch Office",
                NumberOfRoom=9,
                ConstructionMaterial="Steel",
                Height=25,
                Width=86,
                Length=86,
                Floors=1,
                BathRooms=2,
            };
            var bankCorporate = new Bank("Corporate Bank")
            {
                Name = "Corporate Office",
                NumberOfRoom = 25,
                ConstructionMaterial = "Concrete",
                Height = 65,
                Width = 207,
                Length = 207,
                Floors = 3,
                BathRooms = 4,
            };
            var bankSky = new Bank("Sky Bank")
            {
                Name = "Sky Office",
                NumberOfRoom = 610,
                ConstructionMaterial = "Concrete",
                Height = 1396,
                Width = 29,
                Length = 25,
                Floors = 85,
                BathRooms = 160,
            };
            Console.WriteLine();
            var elementary = new School("Elementary School")
            {
                Name = "Biffle Elementary School",
                NumberOfRoom = 59,
                ConstructionMaterial = "Brick",
                Height = 23,
                Width = 290,
                Length = 290,
                Floors = 1,
                ClassRooms = 30,
                BathRooms = 11,
                NumberOfStudents = 500,
                NumberOfTeachers=35,
            };
            var middleSchool = new School("Middle School")
            {
                Name = "Biffle Middle School",
                NumberOfRoom = 56,
                ConstructionMaterial = "Brick",
                Height = 54,
                Width = 255,
                Length = 255,
                Floors = 2,
                ClassRooms = 30,
                BathRooms = 15,
                NumberOfStudents = 450,
                NumberOfTeachers = 30,
            };
            var highSchool = new School("High School")
            {
                Name = "Biffle High School",
                NumberOfRoom = 70,
                ConstructionMaterial = "Concrete",
                Height = 73,
                Width = 403,
                Length = 403,
                Floors = 3,
                ClassRooms = 45,
                BathRooms = 20,
                NumberOfStudents = 800,
                NumberOfTeachers = 40,
            };
        }
    }
}
