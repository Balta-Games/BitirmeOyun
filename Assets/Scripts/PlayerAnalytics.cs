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

    public void SaveToCSV(bool isDied)
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");

        bool fileExists = File.Exists(path);

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            if (!fileExists)
            {
                writer.WriteLine("Attack,Block,Jump,Sprint,Dodge,IsDied");
            }

            writer.WriteLine($"{attackCount},{blockCount},{jumpCount},{sprintCount},{rollCount},{(isDied ? 1 : 0)}");
        }

        Debug.Log("CSV kaydedildi: " + path);
    }
    public double[] GetLastRecord()
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");
        try
        {
            // Dosyadaki tüm satırları oku
            string[] allLines = File.ReadAllLines(path);

            if (allLines.Length <= 1)
            {
                Debug.LogWarning("CSV dosyasında veri satırı bulunamadı (Sadece başlık olabilir).");
                return null;
            }

            string lastLine = allLines[allLines.Length - 1];

            if (string.IsNullOrWhiteSpace(lastLine) && allLines.Length > 2)
            {
                lastLine = allLines[allLines.Length - 2];
                Debug.Log("son satırdan bir önceki satır: " + lastLine);
            }

            string[] values = lastLine.Split(',');
            double[] record = new double[values.Length];

            for (int i = 0; i < values.Length; i++)
            {
                if (double.TryParse(values[i], System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out double result))
                {
                    record[i] = result;
                }
                else
                {
                    record[i] = 0.0; 
                }
            }
            return record;
        }
        catch (System.Exception e)
        {
            Debug.LogError("CSV okunurken hata oluştu: " + e.Message);
            return null;
        }
    }
}