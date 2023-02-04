using System.Text.RegularExpressions;

namespace HelperLib;

public class ExTesting{

    public string TestExceptions()
    {
        var msg = "";
        try 
        {
            msg = "trying";
            throw new Exception("exception thrown.");
        }
        catch (ArgumentNullException ex)
        {
            // ArgumentNull: null argument passed to methods
            msg = ex.Message;
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // ArgumentOutOfRange: value is outside the range of valid value
            msg = ex.Message;
        }
        catch (ArgumentException ex)
        {
            // Argument: invalid argument passed to method
            msg = ex.Message;
        }
        catch (DivideByZeroException ex)
        {
            // DivideByZero: int divided by zero
            msg = ex.Message;
        }
        catch (FileNotFoundException ex)
        {
            // FileNotFound: file does not exist at the specified location
            msg = ex.Message;
        }
        catch (FormatException ex)
        {
            // FormatException: value not correct to be parsed
            msg = ex.Message;
        }
        catch (IndexOutOfRangeException ex)
        {
            // IndexOutOfRange: array index is outside the array bounds
            msg = ex.Message;
        }
        catch (InvalidOperationException ex)
        {
            // InvalidOperation: method call is invali in objects current state
            msg = ex.Message;
        }
        catch (KeyNotFoundException ex)
        {
            // KeyNotFound: key for accessing a member in a collection does not exist
            msg = ex.Message;
        }
        catch (NotSupportedException ex)
        {
            // NotSupported: mthod or operation is not supported
            msg = ex.Message;
        }
        catch (NullReferenceException ex)
        {
            // NullReference: attempting to access members of null object
            msg = ex.Message;
        }
        catch (OverflowException ex)
        {
            // Overflow: arithmetic, casting or conversion results in an overflow
            msg = ex.Message;
        }
        catch (OutOfMemoryException ex)
        {
            // OutOfMemory: not enough memory to execute coee
            msg = ex.Message;
        }
        catch (StackOverflowException ex)
        {
            // StackOverflow: a stack in memory overflows
            msg = ex.Message;
        }
        catch (TimeoutException ex)
        {
            // Timeout: time allocated to an operation has expired
            msg = ex.Message;
        }
        catch (Exception ex)
        {
            // CatchAll Exception
            msg = ex.Message;
        }
        finally 
        {
            msg = "finally";
        }
        return msg;
    }

    public void StudentTest()
    {
        Student newStudent = null;

        try
        {
            newStudent = new Student();
            newStudent.StudentName = "James007";

            ValidateStudent(newStudent);
        }
        catch (InvalidStudentNameException ex) 
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadKey();
    }

    private static void ValidateStudent(Student std)
    {
        Regex regex = new Regex("^[a-zA-Z]+$");
        if (!regex.IsMatch(std.StudentName))
        {
            throw new InvalidStudentNameException(std.StudentName);
        }
    }
}

class Student
{
    public int StudentId { get; set; }
    public string StudentName { get; set; }
}

[Serializable]
class InvalidStudentNameException : Exception
{
    public InvalidStudentNameException() {}

    public InvalidStudentNameException(string name) 
        : base(string.Format("Invalid Student Name: {0}", name))
    {

    }
}