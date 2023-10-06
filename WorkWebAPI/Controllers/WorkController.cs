using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkWebAPI.DataAccess;
using WorkWebAPI.Models;

namespace WorkWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : ControllerBase
    {
        private readonly DataContext _dataContext;
        public WorkController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet("[action]")]
        public IActionResult Get(int id) 
        {
            Work ?work = _dataContext.Works.FirstOrDefault(w => w.Id == id);
            return Ok(work);
        }

        [HttpGet("get-work")]
        public IActionResult GetWorkList()

        {
            var findwork = _dataContext.Works.ToList();
            if (findwork is null) return BadRequest();
            return Ok(findwork);


        }
        [HttpPost("post-work")]
        public int Post(Work work)
        {
            _dataContext.Works.Add(work);
            _dataContext.SaveChanges();
            return 0;

        }

        [HttpDelete("delete-work/{Id}")]
        public IActionResult DeleteWork (int Id)
        {
            var findwork = _dataContext.Works.FirstOrDefault(x=>x.Id == Id);
            if (findwork is null) return BadRequest();
            _dataContext.Works.Remove(findwork);
            _dataContext.SaveChanges(); return Ok();
        }

        [HttpPut("update-work")]
        public IActionResult UpdateWork(Work work)
        {
            var findwork = _dataContext.Works.AsNoTracking().FirstOrDefault(x => x.Id == work.Id);
            if (findwork is null) return BadRequest();
            _dataContext.Works.Update(work);
            _dataContext.SaveChanges(); return Ok();
        }
    }


}
