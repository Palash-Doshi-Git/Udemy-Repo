using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Quiz_Udemy
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_lecture()
        {
            Lecture newLecture = new Lecture(2, "5", "5/20/2017", "Guest Speaker", "Lecture", "New Hall", true,"Some info here", 12.99);
            Console.WriteLine(newLecture); 
        }
        [TestMethod]
        public void Test_musical()
        {
            Musical newMusical = new Musical(2,"5","The magic Flute","Musical","Theatre","Mozart", "5/20/2017", true,true,false,49.99);
            Console.WriteLine(newMusical);
        }

        public void Test_Play()
        {
            Play newplay = new Play(2, "5", "05/20/2017", "Death of a Salesman", "Play"
                , "Theatre", true, 15, "Info here", 15.99);
            Console.WriteLine(newplay);
        }

    }
}
