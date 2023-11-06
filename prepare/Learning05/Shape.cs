public abstract class Shape{
    private string _gcColor ;
    public Shape (string color){
        _gcColor = color;
    }
    public string GetColor(){
        return _gcColor;
    }
    public void SetColor(string color){
        _gcColor = color;
    }

    public abstract double GetArea();
};