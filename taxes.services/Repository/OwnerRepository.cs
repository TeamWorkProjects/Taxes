using taxes.services.Context;
using taxes.services.Models;

namespace taxes.services.Repository
{
    public class OwnerRepository : GenericRepository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationDbContext context) : base (context)
        {
        }
    }
}