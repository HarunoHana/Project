using UnityEngine;

public class Methods : MonoBehaviour
{
    int a = 3;
    int b = 5;
    int c = 8;
    int d = 7;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int e = Add(a, b, c);
        Debug.Log(e);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    int Add(int firstNumber, int secondNumber, int thirdNumber)
    {
        //Debug.Log (firstNumber + secondNumber + thirdNumber);
        return(firstNumber + secondNumber + thirdNumber);
    }
}
