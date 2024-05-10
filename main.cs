using System;

public class Book
{
  public string Title { get; set; }
  public string Author { get; set; }
  public int PublicationYear { get; set; }

  private bool isAvailable;
  private int numberOfPages;
  private string genre;

  public book()
  {
    Title = "Unknown";
    Author = "Unknown";
    PublicationYear = 0;
    isAvailable = true;
    numberOfPages = 0;
    genre = "Unknown";
  }

  public Book(string title, string author, int publicationYear)
  {
    Title = title;
    Author = author;
    PublicationYear = publicationYear;
    
  }
  