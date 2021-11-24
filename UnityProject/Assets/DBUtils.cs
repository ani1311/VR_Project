using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase;
using Firebase.Database;

public class DBUtils : MonoBehaviour
{
    public static void updateUserLocation() {
        Player user = new Player(Globals.userId.ToString(),Globals.userLatitude,Globals.userLongitude);
        string userJson = JsonUtility.ToJson(user);

        Globals.db.Child("users").Child(Globals.userId.ToString()).SetRawJsonValueAsync(userJson);
    }

    public static void updateFriends() {
        FirebaseDatabase.DefaultInstance.GetReference("users").GetValueAsync().ContinueWith(task => 
        {  
            DataSnapshot snapshot = task.Result;
            
            foreach(DataSnapshot player in snapshot.Children) {
                Player friend = new Player(player.Child("playerId").Value.ToString(),
                (float)player.Child("longitude").Value,
                (float)player.Child("latitude").Value);
                Globals.friends.Add(friend);
            }
            
        }); 

    }
}
