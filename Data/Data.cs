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
      Title="Crime and Punishment",
      Description="Crime and Punishment focuses on the mental anguish and moral dilemmas of Rodion Raskolnikov, an impoverished ex-student in Saint Petersburg who formulates a plan to kill an unscrupulous pawnbroker for her money.",
      Author="Fyodor Dostoevsky",
      Rate= (double)4.8,
      DateStart= new DateTime(2003, 01, 20),
      DateRead= new DateTime(2003, 02, 21)
    },
    new Book()
    {
      Id=2,
      Title="Anna Karenina",
      Description="Anna Karenina is one of the most loved and memorable heroines of literature. Her overwhelming charm dominates a novel of unparalleled richness and density. Tolstoy considered this book to be his first real attempt at a novel form, and it addresses the very nature of society at all levels,- of destiny, death, human relationships and the irreconcilable contradictions of existence.",
      Author="Leo Tolstoy",
      Rate= (double)4.7,
      DateStart= new DateTime(2005, 02, 22),
      DateRead= new DateTime(2005, 05, 05)
    },
        new Book()
    {
      Id=3,
      Title="The Selfish Gene",
      Description="Professor Dawkins articulates a gene's eye view of evolution. A view giving center stage to these persistent units of information, and in which organisms can be seen as vehicles for their replication. This imaginative, powerful, and stylistically brilliant work not only brought the insights of Neo-Darwinism to a wide audience. But galvanized the biology community, generating much debate and stimulating whole new areas of research...",
      Author="Richard Dawkins",
      Rate= (double)4.5,
      DateStart= new DateTime(2017, 10, 05),
      DateRead= new DateTime(2018, 01, 16)
    },
        new Book()
    {
      Id=4,
      Title="Civilization & It's Discontents",
      Description="Sigmund Freud enumerates the fundamental tensions between civilization and the individual. The primary friction stems from the individual's quest for instinctual freedom and civilization's contrary demand for conformity and instinctual repression...",
      Author="Sigmund Freud",
      Rate= (double)4.0,
      DateStart= new DateTime(2005, 03, 10),
      DateRead= null
    },

  };


}
}