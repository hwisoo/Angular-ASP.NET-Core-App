using System;
using System.Collections.Generic;

namespace Summaries.Data
{
  public static class Data
{
  public static List<Book> Books => allBooks;

  static List<Book> allBooks = new List<Book>()
  {
    new Book()
    {
      Id=1,
      Title="",
      Description="",
      Author="",
      Rate= (double)4.5,
      DateStart= new DateTime(2019, 01, 20),
      DateRead= null
    },
  };


}
}