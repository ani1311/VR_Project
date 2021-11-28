using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Init : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {

        Globals.friends = new List<Friend>();


        // Test Code:
        for(int i = 0 ; i < 4 ; i++) {
            Friend f = new Friend("frient" + i,i,i/2 + 1);
            Globals.friends.Add(f);
        }

    }

    // void Update() {
    //     foreach(Friend friend in Globals.friends) {
    //         friend.longitude += 0.01f;
    //     }
    // }
}
