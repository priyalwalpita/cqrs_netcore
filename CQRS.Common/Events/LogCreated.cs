namespace CQRS.Common.Events
{
    public class LogCreated : IEvent
    {
        public string Id { get; }
        
        public string Name { get; }
        
        public string Description { get; }

        public LogCreated()
        {
            
        }

        public LogCreated( string id, string name, string desription )
        {
            Id = id;
            Name = name;
            Description = desription;

        }
    }
}