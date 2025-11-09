public class Repository<T> : IRepository where T: class
{
    private readonly ApplicationDbContext _dbcontext;
    private readonly DbSet<T> _dbSet;

    public Repository(ApplicationDbContext dbContext)
    {
        _dbcontext = dbContext;
        _dbSet = _dbcontext.Set<T>();
    }

    public IEnumerable<T> GetAll() => _dbcontext.ToList();
    public T? GetById(int id) => _dbcontext.Find(id);
    public void Add(T entity) => _dbcontext.Add(entity);
    public void Update(T entity) => _dbcontext.Update(entity);
    public void Delete(T entity) => _dbcontext.Remove(entity);
    public void Save() => _dbcontext.SaveChanges();
}