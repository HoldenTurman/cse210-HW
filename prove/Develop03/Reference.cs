public class Reference {
    // This will house the scripture chapter, verse, and book name


    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

        //Constructor for single verse
    public Reference(string bookName, int chapterNumber, int verseNumber)
    {
        _book = bookName;
        _chapter = chapterNumber;
        _verseStart = verseNumber;
        _verseEnd = verseNumber;

    }

    //Constructor for range of verses
    public Reference(string bookName, int chapterNumber, int verseStart, int verseEnd)
    {
        
        _book = bookName;
        _chapter = chapterNumber;
        _verseStart = verseStart;
        _verseEnd = verseEnd;

    }

    // Method to get the full reference as a string
    public string GetReferenceText()
    {
        //conditional to compare to boolean

        if(_verseStart == _verseEnd)
        {
            return $"{_book} {_chapter}:{_verseStart}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
    }


}