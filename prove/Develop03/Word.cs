using System.Dynamic;

class Word{
    private string _shownWord = "";
    private string _hiddenWord = "";

    private bool _isHidden = false;

    public Word(string word){
        _shownWord = word;
        for (int i = 0; i < _shownWord.Length; i++){
            _hiddenWord += "_";
        };
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Reveal(){
        _isHidden = false;
    }
    public string GetHiddenWord(){
        return _hiddenWord;
    }
    public string GetShownWord(){
        return _shownWord;
    }

    public bool checkHidden(){
        return _isHidden;
    }

    public string ShowWord(Word word){
        if (word._isHidden == true){
            return _hiddenWord;
        }
        else
        {
            return _shownWord;
        }
    }


}