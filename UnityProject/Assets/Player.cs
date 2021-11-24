using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{

    public string playerId;
    public float longitude;
    public float latitude;

    public Player(string playerId, float longitude, float latitude) {
        this.playerId = playerId;
        this.longitude = longitude;
        this.latitude = latitude;
    }
}
