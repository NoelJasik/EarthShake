using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float strenght;
    Rigidbody rb;
    float timer;
    [SerializeField]
    float changeDirTime;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        strenght += Time.deltaTime * 50;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
rb.AddForce(new Vector3(Random.Range(-strenght / 2, strenght  / 2), Random.Range(-strenght * 2, strenght * 2), Random.Range(-strenght  / 2, strenght  / 2)));
timer = changeDirTime;
        }
    }
}
