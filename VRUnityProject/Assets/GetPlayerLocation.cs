using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Android;


public class GetPlayerLocation : MonoBehaviour
{
   
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
            Debug.Log("Time out");
             yield break;

        }
            

       

        // connection failed
        if (Input.location.status == LocationServiceStatus.Failed)
        {

            Debug.Log("unable to determine device location");
            yield break;
        }
        else
        {

            
            Debug.Log("Running");
            InvokeRepeating("Update", 0.5f, 1f);


        }

    }// end of GPSLoc


    // Update is called once per frame
    void Update()
    {
        if (Input.location.status == LocationServiceStatus.Running)
        {


            latitudeValue = GPSutil.Latitude();
            longitudeValue = GPSutil.Longitude();
            // GPS access granted to GPS values and it has been init
        }

        else
        {
            Debug.Log("Stopped");
            // service is stopped.


        }
        
    }// end of Update
}
