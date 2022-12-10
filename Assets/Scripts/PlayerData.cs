using System;
using UnityEngine;
using System.Text;
using UnityEngine.Networking;


public class PlayerData
{
    public static string CurrentName;
    public static int CurrentScore;
    public static int CurrentMaxScore;
    public static bool IsNew;

    public static void UpdateMaxScore()
    {
        if (CurrentMaxScore < CurrentScore)
        {
            CurrentMaxScore = CurrentScore;
        }
    }


    public static void GetMaxScoreFromTable()
    {
    }
}