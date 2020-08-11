namespace PaySlipProblem
{
    public class TaxableIncomeTax
    {
        public decimal Threshold { get; set; } //property
        public decimal Rate { get; set; }
        public decimal Base { get; set; }
        /* private decimal _monthlyIncome;
        public decimal AnnualIncome 
        {
            get 
            { 
                return _monthlyIncome * 12;
            } 
            set 
            { 
                _monthlyIncome = value / 12;
                
            }
        } */
        
    }
    public class TaxableIncomeTaxArray
    {
        public static TaxableIncomeTax[] Get() // static don't need to use new (instantiate)
        {
            return new[] {
                new TaxableIncomeTax
                {
                    Threshold = 18200, 
                    Rate = 0.19m,
                },
                new TaxableIncomeTax
                {
                    Threshold = 37000, 
                    Rate = 0.325m,
                    Base = 3572,
                },
                new TaxableIncomeTax
                {
                    Threshold = 87000, 
                    Rate = 0.37m,
                    Base = 19822,
                },
                new TaxableIncomeTax
                {
                    Threshold = 180000, 
                    Rate = 0.45m,
                    Base = 54232, 
                }
            };
        }
    }
}