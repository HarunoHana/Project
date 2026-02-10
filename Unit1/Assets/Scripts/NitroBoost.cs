using System.Collections;
using UnityEngine;

public class NitroBoost : MonoBehaviour
{
    public float nitroSpeed = 20;
    public float boostTime = 5;
    public float cycleSpeed = 2;
    Renderer rend;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color color = rend.material.color;
        color.a = Mathf.PingPong(Time.time *cycleSpeed, 1);
        rend.material.color = color;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("vehicle"))
        {
            Drive drive = other.gameObject.GetComponent<Drive>();
            StartCoroutine("Boost", drive);
        }
    }

    IEnumerator Boost(Drive drive)
    {
        drive.maxSpeed += nitroSpeed;
        yield return new WaitForSeconds(boostTime);
        drive.maxSpeed -= nitroSpeed;
    }    
}
