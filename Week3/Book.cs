namespace Week3;

using System;

public class Book
{
    private string title; // Title of the book
    private string author; // Author of the book
    private int yearPublished; // Year the book was published

    /// <summary>
    /// Constructor for the Book class
    /// </summary>
    /// <param name="newTitle"></param>
    /// <param name="newAuthor"></param>
    /// <param name="newYear"></param>
    public Book(string newTitle, string newAuthor, int newYear)
    {
        title = newTitle;
        author = newAuthor;
        yearPublished = newYear;
    }

    /// <summary>
    /// Another constructor for the Book class that sets the title and author to "Unknown" and the yearPublished to 0
    /// </summary>
    public Book()
    {
        title = "Unknown";
        author = "Unknown";
        yearPublished = 0;
    }

    /// <summary>
    /// the setYearPublished method sets the yearPublished to the newYear if it is greater than
    /// 0 and less than or equal to the current year
    /// </summary>
    /// <param name="newYear"></param>
    public void setYearPublished(int newYear)
    {
        if (newYear < 0)
        {
            yearPublished = 0;
        }
        else if (newYear > DateTime.Now.Year)
        {
            yearPublished = DateTime.Now.Year;
        }
        else
        {
            yearPublished = newYear;
        }
    }
}