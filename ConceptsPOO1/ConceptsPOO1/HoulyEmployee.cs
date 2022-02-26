namespace ConceptsPOO1
{
    public class HoulyEmployee : Employee
    {

        public float Hours { get; set; }

        public decimal HoursValue { get; set; }

        public override decimal GetValueToPay()
        {
            return (decimal)Hours * HoursValue;
        }

        public override string ToString()
        {
            return $" {base.ToString() }" +
                $" \n\t Hours................:{$"{Hours:N2}",18}" +
                $" \n\t Hours Value..........:{$"{HoursValue:C2}",18}" +
                $" \n\t Value to pay.........:{$"{GetValueToPay():C2}",18}";
        }
    }
}
