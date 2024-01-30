namespace GPUTestAnalysisCascadingDropDown.Models
{
    public class GPU
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public GPU() { }
        public GPU(string name, string description)
        {
            Name = name;
            Description = description;

            // Do some work here but need to check with architecture
            // Maybe there is no work to be done here

        }
    }
}
