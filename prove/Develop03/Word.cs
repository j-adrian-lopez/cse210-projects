using System;

public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // Create method that will hide the words
    public void HideWord()
    {
        _isHidden = true;
    }

    public bool IsHidden(){
        return _isHidden;
    }

    // Create method to render words depending on if they are hidden or not
    public string GetRenderedWord()
    {
        if(_isHidden == true)
        {
            return new string('_', _word.Length);
        }
        else
        {
            return _word;
        }
    }

        // private void ShowWord()
    // {

    // }
    // private static void IsHidden()
    // {

    // }
}