using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float speed = -60f;
    public GameObject fruit;
    private GameObject currentFruit;
    public float offY = -0.6f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //fruit position below player.
        if (currentFruit != null)
        {
            Vector3 playerPos = transform.position;
            Vector3 fruitOffset = new Vector3(0.0f, offY, 0.0f);
            currentFruit.transform.position = playerPos + fruitOffset;
        }
        else
        {
            currentFruit = Instantiate(fruit, new Vector3(0.0f, offY, 0.0f), Quaternion.identity);
        }

        // Drop fruit
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Rigidbody2D body = currentFruit.GetComponent<Rigidbody2D>();
            body.gravityScale = 1.0f;

            Collider2D collider = currentFruit.GetComponent<Collider2D>();
            collider.enabled = true;

            currentFruit = null;
        }

        float offset = 0.0f;

        if (Keyboard.current.leftArrowKey.isPressed || Keyboard.current.aKey.isPressed)
        {
            offset -= speed;
        }
        if (Keyboard.current.rightArrowKey.isPressed || Keyboard.current.dKey.isPressed)
        {
            offset += speed;
        }
        Vector3 newPos = transform.position;
        newPos.x = transform.position.x + offset;
        transform.position = newPos;

    }
}
