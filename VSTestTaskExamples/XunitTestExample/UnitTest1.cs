namespace XunitTestExample
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessCase()
        {

        }

        [Fact]
        public void FailCase()
        {
            throw new NotImplementedException("This case should fail, by intentional.");
        }
    }
}