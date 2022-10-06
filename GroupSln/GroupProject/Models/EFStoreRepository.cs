namespace ASP_NetProject.Models;

public class EFStoreRepository : IStoreRepository
{
    private StoreDbContext _context;

    public EFStoreRepository(StoreDbContext ctx)
    {
        _context = ctx;
    }
    //TODO Skal samsvara við IStoreRepository klassan - Síða 182 í PDF
    // public public IQueryable<Product> Products => context.Products;
}