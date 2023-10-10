class Fraction{

    private int _top;

    private int _bottom;

    public Fraction(){

        _top = 1;
        _bottom = 1;
    }
    public Fraction(int TopNum){
        _top = TopNum;
        _bottom = 1;
    }
    public Fraction(int TopNum, int BotNum){
        _top = TopNum;
        _bottom = BotNum;
    }

    public int GetTopInt(){
        return _top;
    }
    public int GetBottomInt(){
        return _bottom;
    }

    public void SetTopInt(int TopNum){
        _top = TopNum;
    }
    public void SetBotInt(int BotNum){
        _bottom = BotNum;
    }

    public string GetFractionString(){
        string FractionString = $"{_top}/{_bottom}";
        return FractionString;
    }
    public float GetDecimalValue(){
        float dec = _top / _bottom;
        return dec;
    }



}