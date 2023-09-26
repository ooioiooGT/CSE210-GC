using System;
public class Job{
    public string _gcJobTitle;
    public string _gcCompany;
    public int _gcStartYear;
    public int _gcEndYear;
    public void Display(){
        Console.WriteLine($"{_gcJobTitle} ({_gcCompany}) {_gcStartYear}-{_gcEndYear}");
    }

}