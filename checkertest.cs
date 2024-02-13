using Nunit1;

namespace checkertest
{
    public class checkertest

    {
        private checker _checkertest { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _checkertest = new checker();   
            

        }

        [Test]
        public void gradechecker()
        {
            //assign
            var percent = 91;

            //act
            var grade = _checkertest.gradechecker(percent);
            //assert
            Assert.AreEqual("A", grade);
        }
    }
}