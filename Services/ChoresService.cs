namespace Chores.Services;

public class ChoresService
{
    private readonly ChoresRepo _repo;
    public ChoresService( ChoresRepo repo)
    {
        _repo = repo;
    }

    public List<Chore> GetAllChores()
    {
        List<Chore> chores = _repo.GetAllChores();
        return chores;
    }

    internal Chore CreateChore(Chore choreData)
    {
        Chore chore = _repo.CreateChore(choreData);
        return chore;
    }

    internal string RemoveChore(int choreId)
    {
        Chore chore = _repo.GetById(choreId);
        if(chore == null) throw new Exception($"Not chore at id: {choreId}");
        _repo.RemoveChore(choreId);
        return $"chore at id: {choreId} was removed";
    }

    internal Chore UpdateChore(Chore updateData)
    {
        Chore original = _repo.GetById(updateData.Id);
        if (original == null) throw new Exception($"No chore at id: {updateData.Id}");
        original.Name = updateData.Name !=null ? updateData.Name : original.Name;
        original.Completed = updateData.Completed !=null ? updateData.Completed : original.Completed;

        _repo.UpdateChore(updateData);
        return updateData;
    }


}