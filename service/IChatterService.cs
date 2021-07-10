using domain.Entities;
using System.Collections.Generic;

namespace service
{
    public interface IChatterService
    {
        IList<Chatter> GetAll();
        Chatter SetNew(Chatter chatter);
    }
}
