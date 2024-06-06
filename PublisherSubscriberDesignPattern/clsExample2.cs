using System;
using System.Net.WebSockets;
public class NewArticle
{
    public string Title { get;  }   
    public string Description { get; }
    public string Author { get;  }

    public NewArticle(string Author, string Title, string Decription)
    {
        this.Author = Author;
        this.Title = Title;
        this.Description = Decription;
    }
}

public class Publisher2
{
    public delegate void NewNewsPublished(object sender, NewArticle article);
    public event NewNewsPublished OnPublish;

    public void NewsPublish(string Author, string Title, string Decription)
    {
        NewArticle article = new NewArticle(Author, Title, Decription);

        OnPublish?.Invoke(this, article);
    }
}
public class Subscriber2
{
    public string subscirberName { get; }
    public Subscriber2(string Name)
    {
        subscirberName = Name;
    }

    public void Subscribe(Publisher2 publisher)
    {
        publisher.OnPublish += handleNewNews;
    }
    public void unSubscribe(Publisher2 publisher)
    {
        publisher.OnPublish -= handleNewNews;
    }
    public void handleNewNews(object sender, NewArticle newArticle)
    {
        Console.WriteLine("\nArticle:");
        Console.WriteLine($"Subscriber Name : {subscirberName}");
        Console.WriteLine($"Author : {newArticle.Author}");
        Console.WriteLine($"Title : {newArticle.Title}");
        Console.WriteLine($"Description : {newArticle.Description}");
    }
}

public class caller
{
    public static void run()
    {
        Publisher2 publisher = new Publisher2();
        Subscriber2 subscriber = new Subscriber2("Omer MEMES");
        subscriber.Subscribe(publisher);
        publisher.NewsPublish("Johan smeth", "C++", "C++ and C# are stonge pogramming language.");

    }

}

/*

Article:
Subscriber Name : Omer MEMES
Author : Johan smeth
Title : C++
Description : C++ and C# are stonge pogramming language. 
*/