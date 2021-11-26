using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class Globals : MonoBehaviour
{
    public static DatabaseReference db;

    public static System.Guid userId;

    public static float userLatitude;
    public static float userLongitude;

    public static List<Player> friends;
    
    // Implies 1 Unit = 1 m
    public const double Scale = 10;
    public const double MaxPlayers = 100;
}
