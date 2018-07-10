namespace CQRS.Common.Commands
{
    public class CreateLog : ICommand
    {
        public string Id;
        
        public string Name { get; set; }
        
        public string Description { get; set; }
    }
}