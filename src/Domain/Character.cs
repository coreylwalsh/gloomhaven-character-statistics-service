namespace Domain;

public class Character
{
    public Guid CharacterId { get; set; }
    public string Name { get; set; }
    public Guid PlayerId { get; set; }
    public string PlayerName { get; set; }
    public string PartyName { get; set; }
    public string Class { get; set; }
    public int Experience { get; set; }
    public int Gold { get; set; }
    public string[] Items { get; set; } = new string[] {}; // change to array of class Item
    public string[] Perks { get; set; } = new string[] {}; // change to array of class Perk
    public int Checkmarks { get; set; }
    public string[] Abilities { get; set; } = new string[] {}; // change to array of class Ability
    public string PersonalQuest { get; set; }
    public int LineageRank { get; set; }
}