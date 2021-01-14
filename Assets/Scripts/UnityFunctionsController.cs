using UnityEngine;

public class UnityFunctionsController : MonoBehaviour
{
    public void MyFunction()
    {
        Debug.Log("MyFunction!");
    }
    public void MyIntFunction(int num)
    {
        Debug.Log("MyIntFunction! " + num.ToString());
    }
    public void MyStringFunction(string str)
    {
        Debug.Log("MyStringFunction! " + str);
    }
}
