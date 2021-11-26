using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public static class GPSutil
{
    public static IEnumerator initGPS()
    {
        // check if user has location service enabled
        if (!Input.location.isEnabledByUser){
            Debug.Log("User has not enabled GPS");
            yield break;
        }

        // start service before querying location.
        Input.location.Start();

        // wait until service intialize
        int maxWait = 20;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0)
        {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        // service didn't init in 20 seconds 
        if (maxWait < 1)
        {
            Debug.Log("Time out");
            yield break;

        }

        // connection failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            Debug.Log("unable to determine device location");
            yield break;
        }
    }

    public static void updatePlayerLocation()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {
            Globals.userLatitude = Input.location.lastData.latitude;
            Globals.userLongitude = Input.location.lastData.longitude;
        }

        // We update to dummy location, of northside if GPS fails
        else
        {
            Debug.Log("GPS Service not working. Returning Dummy location");
            Globals.userLatitude = 32.776665f;
            Globals.userLongitude = -96.796989f;
        }

    }
}
