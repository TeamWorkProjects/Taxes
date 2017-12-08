using taxes.services.Context;
using taxes.services.Models;

namespace taxes.services.Repository
{
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(ApplicationDbContext context) : base (context)
        {
        }
    }
}