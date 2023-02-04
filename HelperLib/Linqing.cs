namespace HelperLib;

public class Linqing {

    public void LinqTest(){
        var myCollection = new MyCollection();
        var listInt = myCollection.LinqListInt();

        var result = from aInt in listInt // foreach var aInt in listInt
                    where aInt == 1 // if condition is met
                    select aInt; // add to new collection
        
        foreach (var item in result){
            Console.WriteLine(item.ToString());
        }
    }

}