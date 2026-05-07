namespace libfreedomsharp
{
    public class County
    {

        public string StateName { get; set; }
        public string CountyName { get; set; }
        public string Decision { get; set; }

        public County(string stateName, string countyName, string firstDecision, string finalDecision)
        {
            StateName = stateName;
            CountyName = countyName;
            Decision = finalDecision;
        }
    }
}
