using UnityEngine;

public class ControlFlow : MonoBehaviour
{
    public bool flag;
    void Start()
    {
        if (flag)
        {
            Debug.Log("Boolean flag is set.");
        }
        else
        {
            Debug.Log("Boolean flag is not set.");
        }

        for (float i = 1; i <= 10; i++)
        {
            float PowerOfTwo = Mathf.Pow(2f, i);
            Debug.Log(string.Format("The {0} power of 2 is {1}", i, PowerOfTwo));
        }
    }

    // took out void Update () since frames don't need to be updated
}
