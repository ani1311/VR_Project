using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFriends : MonoBehaviour
{   
    public GameObject PlayerPosPrefab;
    public InsaneSystems.Radar.RadarObject boolboy;
    List<GameObject> friendObjects;

    void Start() {
        friendObjects = new List<GameObject>();
        for(int i = 0 ; i < Globals.MaxPlayers ; i++) {
            GameObject go = Instantiate(PlayerPosPrefab);
            go.transform.Translate(0,10000,0);
            go.AddComponent<InsaneSystems.Radar.RadarObject>();
            boolboy = go.GetComponent<InsaneSystems.Radar.RadarObject>();
            boolboy.ShouldBeVisibleAllTime = true;
            friendObjects.Add(go);
        }
    }

    void Update()
    {
        int playerPosIndes = 0;
        foreach(Friend friend in Globals.friends) {
            friendObjects[playerPosIndes].transform.position = new Vector3(getXPosInGame(friend.longitude),getYPosInGame(friend.longitude),0);
            playerPosIndes++;
        }
    }

    float getXPosInGame(float posInWord) {
        return posInWord;
    }

    float getYPosInGame(float posInWord) {
        return posInWord;
    }
}
