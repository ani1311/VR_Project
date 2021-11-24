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

        DBUtils.updateFriends();
        
        Debug.Log(Globals.friends);

        // Test Code:
        // for(int i = 0 ; i < 4 ; i++) {
        //     Friend f = new Friend("frient" + i,i,i/2 + 1);
        //     Globals.friends.Add(f);
        // }

    }

    // void Update() {
    //     foreach(Friend friend in Globals.friends) {
    //         friend.longitude += 0.01f;
    //     }
    // }
}
