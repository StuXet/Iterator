using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Tooltip("List of positions the player can move to in each specific room")]
    public List<Transform> positions;
    int camPosCounter;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = positions[0].position;
        transform.rotation = positions[0].rotation;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NextPos()
    {
        camPosCounter++;
        if (camPosCounter + 1 > positions.Count)
        {
            camPosCounter = 0;
        }
        transform.position = positions[camPosCounter].position;
        transform.rotation = positions[camPosCounter].rotation;
    }

    public void PreviousPos()
    {
        camPosCounter--;
        if (camPosCounter < 0)
        {
            camPosCounter = positions.Count - 1;
        }
        transform.position = positions[camPosCounter].position;
        transform.rotation = positions[camPosCounter].rotation;
    }
}
