using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

//BaseCharacter is the base of a character
public class BaseCharacterController : MonoBehaviour
{
    private Vector2 movementInput;
<<<<<<< HEAD
    [SerializeField] private float movementSpeed;
    [Range(0,1)][SerializeField] private float slowedFactor;
    private bool isSlowes;

    private void Start()
    {
        isSlowes = false;
    }

    /// <summary>
    /// Movement is called by the input system when the player moves the joystick or presses the arrow keys
    /// </summary>
    /// <param name="ctx">Context provided by Unity Input</param>
    public void Movement(CallbackContext ctx)
    {
        //movementInput is set by unity events
        movementInput = ctx.ReadValue<Vector2>(); //comment
    }

    //This is now a FIXEDupdate
    private void FixedUpdate()
    {
        var actualMovementSpeed = movementSpeed;
        if (isSlowes) actualMovementSpeed *= slowedFactor;
        

        //transform.position += new Vector3(movementInput.x, movementInput.y, 0) * Time.deltaTime * movementSpeed;

        transform.Translate(new Vector3(movementInput.x, movementInput.y, 0) * Time.deltaTime * actualMovementSpeed);

        //rb.velocity = new Vector3(movementInput.x, movementInput.y, 0) * movementSpeed;

        //rb.AddForce(new Vector3(movementInput.x, movementInput.y, 0) * movementSpeed);
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Swamp"))
        {
            isSlowes = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Swamp"))
        {
            isSlowes = false;
        }
=======
    [SerializeField] float movementSpeed;
    public void Movement(CallbackContext ctx)
    {
        //Debug.Log($"Context: {ctx.ReadValue<Vector2>()}");7

        movementInput = ctx.ReadValue<Vector2>();
>>>>>>> origin/master
    }

    private void Update()
    {
        transform.position += new Vector3(movementInput.x, movementInput.y, 0) * Time.deltaTime * movementSpeed;
    }

}
