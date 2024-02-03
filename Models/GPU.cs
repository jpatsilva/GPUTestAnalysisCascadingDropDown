namespace GPUTestAnalysisCascadingDropDown.Models
{
    public class GPU
    {
        public string Type { get; set; }
        public string Parameter_Name { get; set; }
        public string Expression { get; set; }
        public string Description { get; set; }
        public GPU() { }
        public GPU(string type, string parameter_name, string expression, string description)
        {
            Type = type;
            Parameter_Name = parameter_name;
            Expression = expression;
            Description = description;

            // Do some work here but need to check with architecture
            // Maybe there is no work to be done here

        }
    }
}
