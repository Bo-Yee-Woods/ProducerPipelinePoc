using System;

namespace DecoratorPoc.Controllers
{
    internal class SampleEvent
    {
        public SampleEvent()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
    }
}