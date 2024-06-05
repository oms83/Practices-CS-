using System;
public class NewArticle
{
    public string Title { get; set; }   
    public string Description { get; set; }
    public string Author { get; set; }

    public NewArticle(string Author, string Title, string Decription)
    {
        this.Author = Author;
        this.Title = Title;
        this.Description = Decription;
    }
}

