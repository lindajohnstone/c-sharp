using PaySlipProblem;

namespace test.PayslipProblem
{
    public class StubPayslipIO : IPayslipIO
    {
        private string _readLine;

        public string ReadLine()
        {
            return _readLine;
        }
        public void WriteLine(string v)
        {
            
        }

        public void Write(string v)
        {
            
        }

        public StubPayslipIO WithReadLine(string value) 
        {
            _readLine = value;
            return this;
        }

        
    }

}