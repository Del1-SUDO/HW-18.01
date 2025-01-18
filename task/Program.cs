Book info = new Book();
info.Main("Harry Potter", "J. K. Rowling", 1997);

string aboutBook = info.GetInfo();
System.Console.WriteLine(aboutBook);

bool madeIn = info.IsPublishedRecently();
System.Console.WriteLine(madeIn);

class Book{
    private string? title;
    private string? author;
    private int year;

    public void Main(string title, string author, int year){
        this.title = title;
        this.author = author;
        this.year = year;
    }
    public string GetInfo(){
        return $"Harry Potter and the Philosopher's Stone, published in 1997, is the first book in the Harry Potter series by J.K. Rowling. It introduces readers to Harry Potter, an orphan who discovers on his eleventh birthday that he is a wizard. He is invited to attend Hogwarts School of Witchcraft and Wizardry, where he makes friends with Hermione Granger and Ron Weasley. Together, they uncover the mystery of the Philosopher's Stone, a magical object that grants immortality. The book explores themes of friendship, bravery, and the battle between good and evil";
    }
    public bool IsPublishedRecently(){
        if (this.year>2010){
            return true;
        }
        else{
            return false;
        }
    }

}