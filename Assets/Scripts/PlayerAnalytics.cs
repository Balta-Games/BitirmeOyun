using System.IO;
using UnityEditor;
using UnityEngine;
using System;
using System.Globalization;

public class PlayerAnalytics : MonoBehaviour
{
    public static PlayerAnalytics Instance;
    private int attackCount;
    private int blockCount;
    private int jumpCount;
    private int sprintCount;
    private int rollCount;
    private System.Random random = new();

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

    private string getRandomDouble(int max)
    {
        double numberPart = random.Next(max);
        double floatPart = random.NextDouble();
        double number = numberPart + floatPart;
        number = Math.Round(number, 2);
        return number.ToString(CultureInfo.InvariantCulture);
    }

    private string createPlayerInput(bool isDied)
    {
        string input = blockCount + "," + random.Next(12) + ","; //BlockCount + SuccessfulBlockCount
        input += getRandomDouble(5) + "," + rollCount + ","; //BlockPerMinute + DodgeCount
        input += random.Next(5) + "," + getRandomDouble(3) + ","; //SuccessfulDodgeCount + DodgePerMinute
        input += random.Next(3) + "," + random.Next(4) + ","; //PanicDodges + DodgeDirection
        input += jumpCount + "," + sprintCount + ","; //JumpCount + SprintCount
        input += attackCount + "," + random.Next(21) + ","; //AttackCount + SuccessfulAttackCount
        input += getRandomDouble(12) + "," + random.Next(250) + ","; //AttackPerMinute + DamageDealt
        input += random.Next(100) + "," + (isDied ? 1 : 0); //DamageTaken + IsDied
        return input;
    }

    public void SaveToCSV(bool isDied)
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");

        if(File.Exists(path))
        {
            File.Delete(path);
        }

        using (StreamWriter writer = new StreamWriter(path, true))
        {
            writer.WriteLine("BlockCount,SuccessfulBlockCount,BlockPerMinute,DodgeCount,"+
                "SuccessfulDodgeCount,DodgePerMinute,PanicDodges,DodgeDirection,"+
                "JumpCount,SprintCount,AttackCount,SuccessfulAttackCount,AttackPerMinute,"+
                "DamageDealt,DamageTaken,IsDied");

            writer.WriteLine($"{createPlayerInput(isDied)}");
        }

        Debug.Log("CSV kaydedildi: " + path);
    }
    public double[] GetLastRecord()
    {
        string path = Path.Combine(@"Assets\Data", "player_data.csv");
        try
        {
            if(!File.Exists(path))
            {
                return null;
            }
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