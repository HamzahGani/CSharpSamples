
namespace HelperLib;

public class Oop
{
    public Oop() 
    {

    }
}

// LMS - we mus know which stident is in which course and who is the teacher
public class LearningManagementSystem 
{
    public LearningManagementSystem(){}

    // abstraction
    /*
    entities: Guardian, Student, Subject, Teacher
    characteristics:
        Guardian (student): Name, Surname, Address, Email, Telephone
        Student: Name, Surname, Address, Email, guardians (List<guardian>), subjects enrolled in (List<subject>)
        Subject: name, field (mathematics), year (grade 11), prerequisites (List<subject>)
        Teacher: Name, Surname, Address, Email, telephone, subjects teaching (List<subject>)

        Notes:
            Person - shared fields (Name, Surname, Address, Email)
            Subject references subject as pre requisite
        
        Classes defined below
    */

    public class Subject
    {
        public string? Name { get; set; }
        public string? Field { get; set; }
        public string? Year { get; set; }
        public List<Subject>? prerequisites { get; set; }
    }

    public class Guardian
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
    }

    public class Student
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public List<Guardian>? Guardians { get; set; }
        public List<Subject>? EnrolledIn { get; set; }
    }

    public class Teacher
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? Telephone { get; set; }
        public List<Subject>? Teaching { get; set; }
    }
}

// OOP Principles
/*
1. Abstraction
Identify essential entities (nouns - person, place, thing, process)
determine characteristics of each entity - information (data) and behaviors (methods)
identify classes and their members from nouns

2. Ecapsulation
Create classes with appropirate access modifiers
    to show functionality but hide details and complexity

3. Inheritance
Establish relationships between classes

4. Polymorphism
Establish relationships between classes

*/

// Solid Principles
/*
1. Single Responsibility Principle

2. Open/Closed Principle

3. Liskov Substition Principle

4. Interface Segregation Principle

5. Dependency inversion Principle
*/

// Design Patterns