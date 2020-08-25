using System;

namespace PaySlipProblem
{
    public class PayslipIO: IPayslipIO
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public void WriteLine(string v)
        {
            Console.WriteLine(v);
        }
        public void Write(string v)
        {
            Console.Write(v);
        }
    }
}