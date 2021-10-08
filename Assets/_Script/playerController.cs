using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerController : MonoBehaviour
{

    float h;
    float v;
    Rigidbody rb;
    public int speed= 3;

    public Text Count;
    int count;
    public Text Win;

    // Start is called before the first frame update
    void Start()
    {
    rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");

        v = Input.GetAxis("Vertical");

        Count.text = "Count:" + count;
    }
    private void FixedUpdate()
    {
        Vector3 force = new Vector3(h, 0, v);
        force *= speed;
        rb.AddForce(force);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collection")
        {
            Destroy(other.gameObject);
            count++;
        }
        if(count == 10)
        {
            Win.gameObject.SetActive(true);
        }
    }


}