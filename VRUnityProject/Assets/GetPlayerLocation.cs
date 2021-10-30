using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;


public class GetPlayerLocation : MonoBehaviour
{
    public Text GPSStatus;
    public float latitudeValue;
    public float longitudeValue;
    // Start is called before the first frame update
    void Start()
    {
         StartCoroutine(GPSLoc());
        
    }
    IEnumerator GPSLoc()
    {
        // check if user has location service enabled
        if (!Input.location.isEnabledByUser)
            Debug.Log("User has not enabled GPS");
            yield break;

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
        if (maxWait < 1){
            GPSStatus.text = "Time out";
            Debug.Log("Time out");
             yield break;

        }
            

       

        // connection failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {
            GPSStatus.text = "unable to determine device location";
            Debug.Log("unable to determine device location");
            yield break;
        }
        else
        {

            GPSStatus.text = "Running";
            Debug.Log("Running");
            InvokeRepeating("Update", 0.5f, 1f);


        }

    }// end of GPSLoc


    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {

            GPSStatus.text = "Running";
            latitudeValue = Input.location.lastData.latitude;
            longitudeValue = Input.location.lastData.longitude;
            // GPS access granted to GPS values and it has been init
        }

        else
        {
            GPSStatus.text = "Stop";
            Debug.Log("Stopped");
            // service is stopped.


        }
        
    }// end of Update
}
