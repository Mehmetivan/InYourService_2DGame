// AI-generated

using System.Text.Json;
using TheAdventure.Models;

namespace TheAdventure.Core;

public static class SaveSystem
{
    private static readonly string SavePath = "save.json";

    public static bool SaveExists() => File.Exists(SavePath);

    public static void Save(SaveData data)
    {
        var json = JsonSerializer.Serialize(data, new JsonSerializerOptions 
        { 
            WriteIndented = true 
        });
        File.WriteAllText(SavePath, json);
    }

    public static SaveData? Load()
    {
        if (!SaveExists()) return null;
        var json = File.ReadAllText(SavePath);
        return JsonSerializer.Deserialize<SaveData>(json);
    }

    public static void Delete()
    {
        if (SaveExists()) File.Delete(SavePath);
    }
}

// AI-generated