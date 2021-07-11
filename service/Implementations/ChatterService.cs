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
            var _chatter = chatterRepository.SelectAll().FirstOrDefault(c => c.Name == chatter.Name);
            if (_chatter == null)
                return chatterRepository.InsertNew(chatter);
            return null;
        }
    }
}
