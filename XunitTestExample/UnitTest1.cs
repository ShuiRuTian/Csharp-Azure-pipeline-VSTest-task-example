namespace XunitTestExample
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessCase1()
        {

        }

        [Fact]
        public void SuccessCase2()
        {

        }

        [Fact]
        public void SuccessCase3()
        {

        }

        [Fact]
        public void SuccessCase4()
        {

        }

        [Fact]
        public void SuccessCase5()
        {

        }

        static int FailedCase1Count = 0;

        [Fact]
        public void FailCase1()
        {
            FailedCase1Count++;
            if (FailedCase1Count < 10)
                throw new NotImplementedException("Fail case 1");
        }

        [Fact]
        public void FailCase2()
        {
            throw new NotImplementedException("Fail case 2");
        }
    }
}