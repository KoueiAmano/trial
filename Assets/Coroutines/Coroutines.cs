using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        // StartCotoutine がないとコルーチンが使えない
        StartCoroutine(UpdateHello());
        //Hello();
    }

    IEnumerator UpdateHello()
    {
        Debug.Log("Hello");

        yield return null;

        Debug.Log("HelloHello");

    }

    void Hello()
    {
        Debug.Log("Hello");
    }

}
