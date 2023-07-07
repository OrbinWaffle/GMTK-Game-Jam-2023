using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{
    PlayerController PC;
    // Start is called before the first frame update
    void Start()
    {
        PC = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        PC.UpdateMoveVector(moveVector);
    }
}