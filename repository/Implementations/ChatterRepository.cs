using domain;
using domain.Entities;
using System.Linq;

namespace repository.Implementations
{
    internal class ChatterRepository : IChatterRepository
    {
        private readonly OBotFactoryContext context;

        public ChatterRepository(OBotFactoryContext context)
        {
            this.context = context;
        }

        public IQueryable<Chatter> SelectAll()
        {
            return context.Chatters.AsQueryable();
        }

        public Chatter InsertNew(Chatter chatter)
        {
            context.Chatters.Add(chatter);
            context.SaveChanges();

            return chatter;
        }
    }
}
