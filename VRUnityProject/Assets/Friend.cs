using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Friend
{
    public GameObject gameObject;
    public Vector3 positionInWorld;
    public int xDir;
    public int yDir;

    public Friend(GameObject go) {
        gameObject = go;
        positionInWorld = new Vector3(Random.Range(22,27f),0,Random.Range(-3f,3f));
        gameObject.transform.position = Vector3.Scale(positionInWorld, new Vector3(Globals.scale, 0, Globals.scale));

        xDir = Random.Range(0,1) == 0 ? 1 : -1;
        yDir = Random.Range(0,1) == 0 ? 1 : -1;
        
    }

    public void update() {
        positionInWorld += new Vector3(Random.Range(0,0.01f) * xDir,0,Random.Range(0,0.01f) * yDir);
        gameObject.transform.position = Vector3.Scale(positionInWorld, new Vector3(Globals.scale, 0, Globals.scale));

        int changeDirProbX = Random.Range(0,1000);
        int changeDirProbY = Random.Range(0,1000);
        if(changeDirProbX < 10) {
            xDir *= -1;
        }
        if(changeDirProbY < 10) {
            yDir *= -1;
        }
    }
}
