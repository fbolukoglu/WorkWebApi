using WorkWebAPI.Models;

namespace WorkWebAPI.DataAccess
{
    public class WorkDal
    {
        public WorkDal()
        {
            
        }
        private readonly DataContext _context;
        public void Add(Work work)
        {
            _context.Add(work);
            _context.SaveChanges();
        }
        public void Delete(int id) 
        {
            Work work = Get(id);
            _context.Remove(work);
            _context.SaveChanges();
        }
        public void Update(Work work) 
        {

            _context.Update(work);
            _context.SaveChanges();
        }
        public IList<Work> GetAll() 
        {
            var result=_context.Works.ToList();
            return result ;
        }
        public Work Get(int id) 
        {
            var result=_context.Works.FirstOrDefault(x=>x.Id==id);
            return result;
        }
    }
}
