using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCotroller : MonoBehaviour
{
    Vector3 offset;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        offset = Player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position - offset;
    }
}
