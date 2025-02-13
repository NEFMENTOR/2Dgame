using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    private List<InputAction> actions = new List<InputAction>();
    public InputAction MoveAction;

    public float speed = 3.0f;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {


        _MovementListManipulation();
    }

    // Update is called once per frame
    void Update()
    {
        _PlayerMovement();
    }


    // Add all InputAction(s) to a list for ease of configuration
    void _MovementListManipulation()
    {
        actions.Add(MoveAction);

        foreach (var action in actions)
        {
            action.Enable();
        }
    }

    // Method responsible for a player's movement
    void _PlayerMovement()
    {

        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 posChange = (Vector2)transform.position + (move * speed) * Time.deltaTime;
        transform.position = posChange;
    }
}
