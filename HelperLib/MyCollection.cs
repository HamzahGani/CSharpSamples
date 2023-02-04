namespace HelperLib;
using System.Collections;
public class MyCollection
{
    public IEnumerable getMany(string method){
        switch (method) {
            case "arList": return LinqListInt(); //ListObject(); //GetArrayList();
            case "list": return ListString();
            default: return new List<string>(); 
        }
    }

    public List<object> ListObject(){
        return new List<object>(){1, "a"};
    }

    public List<int> LinqListInt(){
        var numbers = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        numbers.ForEach(num => Console.Write(num + ", "));
        return numbers;

    }

    public ArrayList GetArrayList(){
        var arList = new ArrayList(){ 1, "a"};
        arList.Add(2);
        arList[0] = "arList";
        arList.Insert(1, "b");

        arList.Add("ListString");
        arList.AddRange(ListString());

        return arList;
    }

    public List<string> ListString(){
        var letters = new List<string>(){
            "a","b","c"
        };
        return letters;
    }

    public Dictionary<int, string> DictionaryString(){
        var letters = new Dictionary<int, string>()
        {
            {1,"a"}, {2,"b"}
        };
        letters.Add(3,"a"); // key must be unique but value can be null or duplicate 
        letters.Add(4,"b"); 

        return letters;
    }

    public Hashtable hashTest(){
        var test = new Hashtable()
        {
            {1, "abc"},
            {"abc", 1}
        };

        return test;
    }

    public Stack<int> StackInt(){
        var myStack = new Stack<int>();
        myStack.Push(1);
        myStack.Push(2);

        return myStack;
        // Push(T) adds item, Peek() views last added, Pop() removes last added, Contains(T) true/false, Clear() removes all
    } // LIFO
    
    public Queue<int> QueueInt(){
        var nums = new Queue<int>();
        nums.Enqueue(1);
        nums.Enqueue(2);

        return nums;
        //Count(), Enqueue() adds, Dequeue() removes oldest, Peek() view oldest, Contains<T> true/false, Clear() removes all
    }

    public (int, string, string) TupleTest(){
        (int id, string firstName, string lastName) person = (1, "myName", "mySurname");
        
        person.id = 2;
        
        return person;
    }
}
