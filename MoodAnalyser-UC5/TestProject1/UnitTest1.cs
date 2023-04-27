using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem;

namespace TestProjectForMoodAnalyser
{
    [TestClass]
    public class TestClassForMoodEvaluation
    {
        public const string SAD_MOOD = "SAD";
        public const string HAPPY_MOOD = "HAPPY";
       
        // Checking for sad for sad mood
       
        [TestMethod]
        public void TestMethodForSadMood()
        {
            //Access
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass("I am in sad mood today");
            //Act
            string actual = moodAnalyserClass.analyseMood();
            //Assert
            Assert.AreEqual(SAD_MOOD, actual);
        }
       
        [TestMethod]
        public void TestMethodForHappyMood()
        {
            //Access
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass("I am in any mood today");
            //Act
            string actual = moodAnalyserClass.analyseMood();
            //Assert
            Assert.AreEqual(HAPPY_MOOD, actual);
        }
       
        // Checking For Happy Mood for null Message
        
        [TestMethod]
        public void TestMethodForHappyMoodForNull()
        {
            //Access
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass(null);
            //Act
            string actual = moodAnalyserClass.analyseMood();
            //Assert
            Assert.AreEqual(HAPPY_MOOD, actual);
        }
        
        // Passes Null message and returns Mood is not NULL using Custom Exception Class
        
        [TestMethod]
        public void Given_NullMood_UsingMoodAnalysisCustomException_ExpectingNull()
        {
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass(null);
            try
            {
                //Act
                string actual = moodAnalyserClass.analyseMood();
            }
            catch (MoodAnalysisCustomException exception)
            {
                //Assert
                Assert.AreEqual("Mood should not be NULL", exception.Message);
            }
        }
        
        // Passes Empty message and returns Mood is not EMPTY using Custom Exception Class
        
        [TestMethod]
        public void Given_EmptyMood_UsingMoodAnalysisCustomException_ExpectingEmpty()
        {
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass();
            try
            {
                //Act
                string actual = moodAnalyserClass.analyseMood();
            }
            catch (MoodAnalysisCustomException exception)
            {
                //Assert
                Assert.AreEqual("Mood should not be EMPTY", exception.Message);
            }
        }
        
        // Test Case 4.1 to match both class name and constructor name
        
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClass()
        {
            //Arrange
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass();
            //Act
            var objectFromFactory = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserClass", "MoodAnalyserClass", null);
            //Assert
            objectFromFactory.Equals(moodAnalyserClass);

        }
       
        // Test Case 4.2 To return exception when wrong class name is passed
       
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClassWithWrongClassName()
        {
            //Arrange
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass();
            //Act
            try
            {
                var obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyserClass", null);
            }
            //Assert
            catch (MoodAnalysisCustomException customException)
            {
                Assert.AreEqual("No such class found", customException.Message);
            }
        }

       
        // Test Case 4.3 To return exception for wrong constructor name
        
        [TestMethod]
        public void CreateObjectOfMoodAnalyserClassWithWrongConstructor()
        {
            //Arrange
            MoodAnalyserClass moodAnalyserClass = new MoodAnalyserClass();
            //Act
            try
            {
                var objectFromFactory = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserClass", "MoodAnalyser", null);
            }
            //Assert
            catch (MoodAnalysisCustomException customException)
            {
                Assert.AreEqual("No such constructor found", customException.Message);
            }

        }
        
        // TC 5.1 When the right class name is passed, it should return object of mood analyser class
        
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyserClass()
        {
            //Arrange
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass();
            //Act
            var obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserClass", "MoodAnalyserClass", "I am in happy mood today");
            //Assert
            obj.Equals(moodAnalyser);
        }

        
        // TC 5.2 When a wrong class name is passed then throw exception
       
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyseInvalidClassName()
        {
            //Arrange
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass();
            //Act
            try
            {
                var obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyser", "MoodAnalyserClass", "I am in happy mood today");
            }
            //Assert
            catch (MoodAnalysisCustomException exception)
            {
                Assert.AreEqual("No such class found", exception.Message);
            }
        }

        
        // TC 5.3 When a erong constructor name is passed then throw an exception
        
        [TestMethod]
        public void CreateParameterizedObjectOfMoodAnalyseInvalidConstructor()
        {
            //Arrange
            MoodAnalyserClass moodAnalyser = new MoodAnalyserClass();
            //Act
            try
            {
                var obj = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyserProblem.MoodAnalyserClass", "MoodAnalyser", "I am in a happy mood today");
            }
            //Assert
            catch (MoodAnalysisCustomException exception)
            {
                Assert.AreEqual("No such constructor found", exception.Message);
            }
        }
    }
}