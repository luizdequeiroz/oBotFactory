using domain.Entities;
using repository;
using System.Collections.Generic;
using System.Linq;

namespace service.Implementations
{
    internal class ChatterService : IChatterService
    {
        private readonly IChatterRepository chatterRepository;

        public ChatterService(IChatterRepository chatterRepository)
        {
            this.chatterRepository = chatterRepository;
        }

        public IList<Chatter> GetAll()
        {
            return chatterRepository.SelectAll().ToList();
        }

        public Chatter SetNew(Chatter chatter)
        {
            return chatterRepository.InsertNew(chatter);
        }
    }
}
