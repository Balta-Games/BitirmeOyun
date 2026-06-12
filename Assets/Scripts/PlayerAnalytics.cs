using System.IO;
using UnityEngine;

public class PlayerAnalytics : MonoBehaviour
{
    public static PlayerAnalytics Instance;

    private int attackCount;
    private int blockCount;
    private int jumpCount;
    private int sprintCount;
    private int rollCount;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddAttack()
    {
        attackCount++;
    }

    public void AddBlock()
    {
        blockCount++;
    }

    public void AddJump()
    {
        jumpCount++;
    }

    public void AddSprint()
    {
        sprintCount++;
    }

    public void AddRoll()
    {
        rollCount++;
    }

    private void OnApplicationQuit()
    {
        SaveToCSV();
    }

    private void SaveToCSV()
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");

        bool fileExists = File.Exists(path);

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            if (!fileExists)
            {
                writer.WriteLine("Attack,Block,Jump,Sprint,Dodge");
            }

            writer.WriteLine($"{attackCount},{blockCount},{jumpCount},{sprintCount},{rollCount}");
        }

        Debug.Log("CSV kaydedildi: " + path);
    }
}