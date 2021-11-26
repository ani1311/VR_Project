using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        Globals.db = FirebaseDatabase.DefaultInstance.RootReference;

        Globals.friends = new List<Player>();
        Globals.userId = System.Guid.NewGuid();

        Globals.userLatitude = 123L;
        Globals.userLongitude = 323L;

        // DBUtils.updateUserLocation();
        // DBUtils.updateFriends();
        
        Debug.Log(Globals.friends);
    }

    void Start() {
        // Start GPS Location service
        StartCoroutine(GPSutil.initGPS());

        GPSutil.updatePlayerLocation();
        Debug.Log(Globals.userLatitude);
        Debug.Log(Globals.userLongitude);
    }

    // void Update() {
    //     foreach(Friend friend in Globals.friends) {
    //         friend.longitude += 0.01f;
    //     }
    // }
}
