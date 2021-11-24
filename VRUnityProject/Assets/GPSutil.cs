using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;

public static class GPSutil 
{
    public static float latitudeValue;
    public static float longitudeValue;
    
    public static float Latitude()
    {

        if (Input.location.status == LocationServiceStatus.Running)
        {

            latitudeValue = Input.location.lastData.latitude;
            return Input.location.lastData.latitude;
            // return latitude
        }

        else
        {   latitudeValue = 0.0f;
            return 0.0f;
        


        }


    }// end of Latitude()

    public static float Longitude()
    {

        if (Input.location.status == LocationServiceStatus.Running)
        {

            longitudeValue = Input.location.lastData.longitude;
            return Input.location.lastData.longitude;
            // return longitude
        }

        else
        {
            longitudeValue = 0.0f;
            return 0.0f;
        


        }


    }// end of Latitude()


}
