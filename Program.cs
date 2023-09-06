Page FirstPage = new Page(MyNotes.VariablesPageOne);

Page SecondPage = new Page(MyNotes.VariablesPageTwo);

Page thiredPage = new Page(MyNotes.VariablesPageThree);

Chapter Kapitel1 = new Chapter("variabler");

Kapitel1.Pages.Add(FirstPage);
Kapitel1.Pages.Add(SecondPage);
Kapitel1.Pages.Add(thiredPage);



Book mybook = new Book("HJAP");
mybook.Chapters.Add(Kapitel1);
mybook.Start();

Console.ReadLine();