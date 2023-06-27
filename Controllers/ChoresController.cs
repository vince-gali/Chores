namespace Chores.Controllers;

[ApiController]
[Route("api/chores")]

public class ChoresController : ControllerBase
{
    private readonly ChoresService _choresService;
    public ChoresController(ChoresService choresService)
    {
        _choresService = choresService;
    }
    
    [HttpGet]
    public ActionResult<List<Chore>> GetAllChores(){
        {
            try
            {
                List<Chore> chores = _choresService.GetAllChores();
                return Ok(chores);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }


    [HttpPost]
    public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
    {
        try
        {
            Chore chore = _choresService.CreateChore(choreData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpDelete("{choreId}")]
    public ActionResult<string> RemoveChore(int choreId)
    {
        try
        {
            string Message = _choresService.RemoveChore(choreId);
            return Ok(Message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }


    [HttpPut("{choreId}")]
    public ActionResult<Chore> UpdateChore(int choreId, [FromBody]Chore updateData)
    {
        try
        {
            updateData.Id = choreId;
            Chore chore = _choresService.UpdateChore(updateData);
            return Ok(chore);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}