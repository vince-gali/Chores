namespace Chores.Repositories;

public class ChoresRepo
{
    private List<Chore> dbChores;

    public ChoresRepo()
    {
        this.dbChores = new List<Chore>{};
        dbChores.Add(new Chore(1, "Clean toilet", "eli clogged the toilet its gross", false));
    }

    internal List<Chore> GetAllChores()
    {
        return dbChores;
    }

    internal Chore CreateChore(Chore choreData)
    {
        int lastId = dbChores[dbChores.Count - 1].Id;
        choreData.Id = lastId +1;
        dbChores.Add(choreData);
        return choreData;
    }

    internal Chore GetById(int choreId)
    {
        Chore chore = dbChores.Find(c => c.Id == choreId);
        return chore;
    }

    internal void RemoveChore(int choreId)
    {
        Chore chore = dbChores.Find(c => c.Id == choreId);
        dbChores.Remove(chore);
    }

    internal void UpdateChore(Chore updateData)
    {
        Chore chore = GetById(updateData.Id);
        chore = updateData;
    }


}