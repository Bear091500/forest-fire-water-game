using UnityEngine;

public class Button : MonoBehaviour
{
    public Door door;

    public float pressDepth = 0.1f; // 按下去的距離
    public float speed = 5f;        // 動畫速度

    private Vector3 originalPos;
    private Vector3 pressedPos;
    private bool isPressed = false;

    void Start()
    {
        originalPos = transform.localPosition;
        pressedPos = originalPos + new Vector3(0, -pressDepth, 0);
    }

    void Update()
    {
        if (isPressed)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, pressedPos, Time.deltaTime * speed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, originalPos, Time.deltaTime * speed);
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bird")){
            isPressed = true;
            if (door != null)
                door.Disappear();
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if (other.CompareTag("Bird")){
            isPressed = false;
            if (door != null)
                door.Appear();
        }
    }
}