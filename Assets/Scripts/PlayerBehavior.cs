using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = 5.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            Vector3 newPos = transform.position;
            newPos.x -= speed;
            transform.position = newPos;
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            Vector3 newPos = transform.position;
            newPos.x += speed;
            transform.position = newPos;
        }

        if (Keyboard.current.Akey.isPressed)
        {
            Vector3 newPos = transform.position;
            newPos.x -= speed;
            transform.position = newPos;
        }

        if (Keyboard.current.Dkey.isPressed)
        {
            Vector3 newPos = transform.position;
            newPos.x += speed;
            transform.position = newPos;
        }
    }
}
