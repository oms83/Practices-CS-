using System;

public class NewsArticle
{
    public string Author { get; }
    public string Title { get; }
    public string Description { get; }

    public NewsArticle(string author, string title, string description)
    {
        this.Author = author;
        this.Title = title;
        this.Description = description;
    }
}

public class publisher
{
    public EventHandler<NewsArticle> NewNewsArticle;

    public void Publish(string author, string title, string description)
    {
        NewsArticle newsArticle = new NewsArticle(author, title, description);

        OnPublished(newsArticle);
    }
    protected virtual void OnPublished(NewsArticle newsArticle)
    {
        NewNewsArticle?.Invoke(this, newsArticle);
    }
}

public class subscriber
{
    public string name {get;}
    public subscriber(string name)
    {
        this.name = name;
    }

    public void subscribe(publisher _publisher)
    {
        _publisher.NewNewsArticle += handleNewsArticle;
    }

    public void handleNewsArticle(object sender, NewsArticle newsArticle)
    {
        Console.WriteLine("\nArticle:");
        Console.WriteLine($"Subscriber Name : {name}");
        Console.WriteLine($"Author : {newsArticle.Author}");
        Console.WriteLine($"Title : {newsArticle.Title}");
        Console.WriteLine($"Description : {newsArticle.Description}");
    }
}

public class call
{
    public static void run()
    {
        publisher _publisher = new publisher();
        subscriber _subscriber = new subscriber("Omer MEMES");
        _subscriber.subscribe( _publisher );
        _publisher.Publish("Omer MEMES", "C++ & C#", "C++ and C# are very strong programming languages");
        _publisher.Publish("Omer MEMES", "C++ & C", "C++ and C are very strong programming languages");
    }
}

/*
Article:
Subscriber Name : Omer MEMES
Author : Omer MEMES
Title : C++ & C#
Description : C++ and C# are very strong programming languages

Article:
Subscriber Name : Omer MEMES
Author : Omer MEMES
Title : C++ & C
Description : C++ and C are very strong programming languages
*/