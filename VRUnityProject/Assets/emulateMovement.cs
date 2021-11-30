using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emulateMovement : MonoBehaviour
{

    public GameObject player, player2, player3;
    // Start is called before the first frame update
    void Start()
    {
        
        player = GameObject.Find("friend1");
        player2 = GameObject.Find("friend2");
        player3 = GameObject.Find("friend3");
    }

    // Update is called once per frame
    void Update()
    {

        player.transform.position = player.transform.position + new Vector3(Random.Range(-0.1f, 0.5f), 0,Random.Range(-0.1f, 0.1f));
        player2.transform.position = player2.transform.position + new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.5f, 0.1f));
        player3.transform.position = player3.transform.position + new Vector3(Random.Range(-0.1f, 0.1f), 0, Random.Range(-0.1f, 0.5f));
    }
}
