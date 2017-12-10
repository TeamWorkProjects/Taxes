using taxes.services.Models;
using taxes.services.Context;


namespace taxes.services.Repository
{
    class UnitOfWork
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        private Repository<User> userRepository;

        public Repository<User> UserRepository
        {
            get { return userRepository ?? new Repository<User>(context); }
        }
    }
}
