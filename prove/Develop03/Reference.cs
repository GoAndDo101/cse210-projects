class Reference{

    private string _book;

    private string _chapter;

    private string _verses;

    public Reference(string book, string chapter, string verse){
        this._book = book;
        this._chapter = chapter;
        this._verses = verse;

    }
    public Reference(string book, string chapter, List<int> verses){
        this._book = book;
        this._chapter = chapter;
        this._verses = verses[0] + " - " + verses[(verses.Count - 1)];
        
    }
    public string displayReference(){
        return _book + " " + _chapter + " " + _verses;
    }
    public Reference(){}

}