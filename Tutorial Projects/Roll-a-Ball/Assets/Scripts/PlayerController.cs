using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;

    private int count;

    private float movementX;
    private float movementY;

    public float speed = 10.0f;

    public TextMeshProUGUI countText;
    public TextMeshProUGUI winTextObject;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
        winTextObject.gameObject.SetActive(false);
    }

    void OnMove(InputValue movementvalue) {
        Vector2 movementVector = movementvalue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }
    

    private void FixedUpdate ()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
    private void OnCollisionEnter (Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            winTextObject.gameObject.SetActive(true);
            winTextObject.text = "You Lose!";
        }
    }
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count += 1;
            SetCountText();
        }
    }
    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString();
        if (count >= 8)
        {
            winTextObject.gameObject.SetActive(true);
            winTextObject.text = "You Win!";
            Destroy(GameObject.FindGameObjectWithTag("Enemy"));
        }
    }
}
