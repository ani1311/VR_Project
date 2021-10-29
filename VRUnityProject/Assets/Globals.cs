using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals : MonoBehaviour
{
    public static List<Friend> friends;
    public float myLatitude;
    public float myLongitude;
    
    // Implies 1 Unit = 1 m
    public const double Scale = 10;
    public const double MaxPlayers = 100;
}
