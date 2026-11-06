using  Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Reposity;

public class BeerRepository : IRepository<Beer>
{

    private StoreContext _context;
    public BeerRepository(StoreContext context)
    {
        _context = context;
    }
    public async Task Add(Beer entity) => await _context.Beers.AddAsync(entity);
 

    public async Task<IEnumerable<Beer>> Get() =>
     await _context.Beers.ToListAsync();
    

    public async Task<Beer> GEtById(int id) =>
    await _context.Beers.FindAsync(id);
   

        public async Task Save()=> await _context.SaveChangesAsync();

public void Delete (Beer entity)=> _context.Beers.Remove(entity);

    public void Update(Beer entity)
    {
        _context.Beers.Attach(entity);
        _context.Beers.Entry(entity).State=EntityState.Modified;
    }

    public Task save()
    {
        throw new NotImplementedException();
    }
}