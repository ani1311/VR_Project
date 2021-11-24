using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class FirebaseUtils : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DatabaseReference reference = FirebaseDatabase.DefaultInstance.RootReference;
        reference.SetValueAsync("abced");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
