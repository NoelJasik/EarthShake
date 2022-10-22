using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeLava : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField]
    float strenght;
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
        strenght += Time.deltaTime / 10;
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            rb.velocity = new Vector3(0, Random.Range(-strenght, strenght), 0);
            timer = changeDirTime;
        }
        
    }
}
