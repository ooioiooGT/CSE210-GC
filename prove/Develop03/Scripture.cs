using System; 

public class Scripture
{   
    private string _gcref ;
    private string _gcscr ; 
    private List<string> _gcScrList; 
    public void gcReference(){
        Console.WriteLine("what are the reference");
        _gcref = Console.ReadLine();
        
        
    }
    public void gcScripture(){
        Console.WriteLine("what is the scripture? ");
        _gcscr = Console.ReadLine();
        List <string>  gcScrList = _gcscr.Split(" ").ToList();
        _gcScrList = gcScrList;

    }
    public void gcramdom(List<string> _gcScrList){
        
    }
    public void gcDisplay(){
        Console.WriteLine ($"this is your reference {_gcref}");
        Console.WriteLine ($"this is scripture: {_gcScrList[4]}");
    }
    
}