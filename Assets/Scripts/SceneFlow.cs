using UnityEngine;

// Controls data between scenes.
public static class SceneFlow
{
    private static int startMenu = 0;
    private static int restartMenu = 1;
    private static int nextStageMenu = 2;
    private static int winMenu = 3;
    private static int menuState;

    public static void setMenuState(int state)
    {
        menuState = state;
    }

    public static int getMenuState()
    {
        return menuState;
    }
}