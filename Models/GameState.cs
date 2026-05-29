namespace TheAdventure.Models;

public class GameState
{
    public int Honour { get; set; } = -2;
    public int Coins { get; set; } = 100;

    public bool FarmerQuestDone { get; private set; } = false;
    public bool MinerQuestDone { get; private set; } = false;
    public bool TurtleQuestDone { get; private set; } = false;

    public bool AllQuestsDone => FarmerQuestDone && MinerQuestDone && TurtleQuestDone;

    public void AddHonour(int amount) => Honour += amount;
    public void SpendCoins(int amount) => Coins = Math.Max(0, Coins - amount);

    public void CompleteFarmerQuest() => FarmerQuestDone = true;
    public void CompleteMinerQuest() => MinerQuestDone = true;
    public void CompleteTurtleQuest() => TurtleQuestDone = true;

    public bool IsGoodEnding => Honour >= 1;

    public void LoadFromSave(SaveData data)
    {
        Honour = data.Honour;
        Coins = data.Coins;
        if (data.FarmerQuestDone) CompleteFarmerQuest();
        if (data.MinerQuestDone) CompleteMinerQuest();
        if (data.TurtleQuestDone) CompleteTurtleQuest();
    }
        public void Reset()
    {
        Honour = -2;
        Coins = 100;
        FarmerQuestDone = false;
        MinerQuestDone = false;
        TurtleQuestDone = false;
    }
}
