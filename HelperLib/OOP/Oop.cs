
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
    entities: guardian, student, course, teacher
    characteristics:
        guardian (student): name, surname, address, email, telephone
        student: name, surname, address, email, guardians (List<guardian>), subjects enrolled in (List<subject>)
        subject: name, field (mathematics), year (grade 11), prerequisites (List<subject>)
        teacher: name, surname, address, email, telephone, subjects teaching (List<subject>)
    */
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