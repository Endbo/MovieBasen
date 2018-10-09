using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieBasen.Models;

namespace MovieBasenTestProject
{
    [TestClass]
    public class UnitTest1
    {
        Movie movie = new Movie(); //Instance of the movie class
        Actor actor = new Actor(); //Instance of the actor class

        [TestMethod]
        public void TypeMovieNameFailTest() //Type empty movie name
        {
            movie.Name = ""; //Movie name is an empty string
            if (movie.Name == string.Empty) //If movie name is empty, then throw exception (The test will fail)
            {
                throw new Exception("Movie name can't be empty");
            }
        }

        [TestMethod]
        public void TypeMovieNameSucceed()
        {
            movie.Name = "Jack the Giantslayer";
            if (movie.Name == string.Empty) //Same condition as above, but passes because the movie name isn't empty
            {
                throw new Exception("Movie name can't be empty");                
            }
        }

        [TestMethod]
        public void TypeMovieYearFail()
        {
            movie.Year = 19000; //Movie year set to year 19.000
            if (movie.Year > 2017) //Checks that the movie year isn't later than 2017)
            {
                throw new Exception("Movie year can't be later than 2017");
            }
        }

        [TestMethod]
        public void TypeMovieYearFail2()
        {
            movie.Year = 1900; //Movie year set to year 19.000
            if (movie.Year < 1950) //Checks that the movie year isn't earlier than 1950
            {
                throw new Exception("Movie year can't be earlier than 1950");
            }
        }

        [TestMethod]
        public void ActorAgeTest()
        {
            actor.Age = -1;
            if(actor.Age <= 0)
            {
                throw new Exception("Actor age can't be minus or under 0");
            }
        }

        [TestMethod]
        public void ActorIdNotNullOrNegativeTestFail()
        {
            actor.ID = -1;
            Assert.IsTrue(actor.ID > 0);   //Actor Id should always be a number over 0     
        }

        [TestMethod]
        public void ActorIdNotNullOrNegativeTestPass()
        {
            actor.ID = 1;
            Assert.IsFalse(actor.ID <= 0);    //Actor Id should not be equal 0 (Every actor have an actor Id)            
        }









    }
}

