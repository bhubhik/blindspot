using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 8f;

  
    // Start is called before the first frame update
    void Start()
    {
       PrintToConsole();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    void PrintToConsole()
    {
        Debug.Log("Use your arrow keys to move the player");
        Debug.Log("Use w,a,s,d to move the player");   
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
