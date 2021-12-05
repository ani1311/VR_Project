using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emulateMovement : MonoBehaviour
{
    public List<Friend> friends = new List<Friend>();
    // Start is called before the first frame update
    void Start()
    {
        friends.Add(new Friend(GameObject.Find("ross")));
        friends.Add(new Friend(GameObject.Find("joey")));
        friends.Add(new Friend(GameObject.Find("chandler")));
        friends.Add(new Friend(GameObject.Find("rachel")));
        friends.Add(new Friend(GameObject.Find("monica")));
        friends.Add(new Friend(GameObject.Find("phoebe")));
    }

    // Update is called once per frame
    void Update()
    {
        foreach(Friend friend in friends) {
            friend.update();
        }
    }
}
