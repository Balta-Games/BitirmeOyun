using UnityEngine;
using System;

public static class KmeansPredict
{
    private static double[] scalerMean = new double[] { 11.69, 18.19, 6.30, 11.56, 0.50 }; // mean
    private static double[] scalerVar = new double[] { 33.81, 64.90, 15.11, 25.56, 0.24 }; // variance

    private static double[] cluster0_Center = new double[] { -0.739764933376066, -0.8685867456271061, -0.8808284960577043, 0.06367076017452884, -0.7515175305415474 };
    private static double[] cluster1_Center = new double[] { 0.7666654764079234, 0.900171718195365, 0.9128586231870763, -0.06598606054451213, 0.7788454407430552 };

    public static int PredictCluster(double[] inputFeatures)
    {
        // 1. Veriyi Standartlaştırma (StandardScaler adımı)
        double[] scaledInput = new double[inputFeatures.Length];
        for (int i = 0; i < inputFeatures.Length; i++)
        {
            double stdDev = Math.Sqrt(scalerVar[i]); // varyansın karekökü standart sapmadır
            scaledInput[i] = (inputFeatures[i] - scalerMean[i]) / stdDev;
        }

        // 2. Küme merkezlerine olan Öklid Uzaklıklarını Hesapla
        double distToCluster0 = CalculateEuclideanDistance(scaledInput, cluster0_Center);
        double distToCluster1 = CalculateEuclideanDistance(scaledInput, cluster1_Center);

        // En yakın olan kümeyi seç
        return distToCluster0 < distToCluster1 ? 0 : 1;
    }

    private static double CalculateEuclideanDistance(double[] point1, double[] point2)
    {
        double sum = 0;
        for (int i = 0; i < point1.Length; i++)
        {
            double diff = point1[i] - point2[i];
            sum += diff * diff;
        }
        return Math.Sqrt(sum);
    }
}