using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force = Vector3.zero;
    [SerializeField]
    private float Speed;
    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
        rig.useGravity = false;
    }

    public void ButtonR()
    {
        Debug.Log("R");
        if (transform.position.x < 10f)
            rig.AddForce(new Vector3(Time.deltaTime * Speed * 100f, 0f, 0f));
    }
    public void ButtonL()
    {
        Debug.Log("L");
        if (transform.position.x > -4f)
            rig.AddForce(new Vector3(Time.deltaTime * Speed * -100f, 0f, 0f));
    }
    public void ButtonStop()
    {
        Debug.Log("Stop");
        GetComponent<Rigidbody>().velocity += v3Force;
    }

    void FixedUpdate()
    {
        rig.AddForce(new Vector3(0f, Time.deltaTime * Speed, 0f));
        if (transform.position.x > 10f)
            transform.position = new Vector3(10f, 0, 0);
        if (transform.position.x < -4f)
            transform.position = new Vector3(-4f, 0,0);
    }
}
