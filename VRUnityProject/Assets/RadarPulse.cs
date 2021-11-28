using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadarPulse : MonoBehaviour
{
    private Transform pulseTransform;
    private float range;
    private float rangeMax;


    // Start is called before the first frame update
    private void Awake()
    {
        pulseTransform = transform.Find("Pulse");
        rangeMax = 300f;
    }

    // Update is called once per frame
    void Update()
    {
        float rangeSpeed = 150f;
        range += rangeSpeed * Time.deltaTime;
        if (range > rangeMax)
        {
            range = 0f;
        }
        pulseTransform.localScale = new Vector3(range, range);
    }
}
