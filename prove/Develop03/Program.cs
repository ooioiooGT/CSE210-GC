using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        scripture.gcReference();
        scripture.gcScripture();
        scripture.gcDisplay();
    }
}