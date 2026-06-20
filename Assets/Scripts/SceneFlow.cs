using System.IO;
using UnityEngine;

// Controls data between scenes.
public static class SceneFlow
{
    private static int level = 1;
    private static int menuState;

    public static void setMenuState(int state)
    {
        menuState = state;
    }

    public static int getMenuState()
    {
        return menuState;
    }

    public static void increaseLevel()
    {
        level++;
    }

    public static void resetLevel()
    {
        level = 1;
    }

    public static int getLevel()
    {
        return level;
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void DeleteDataFile()
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");

        if(File.Exists(path))
        {
            File.Delete(path);
        }
    }
}