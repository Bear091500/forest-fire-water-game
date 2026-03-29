using UnityEngine;

public class ButtonTF_Diamond : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Door door;
    public GameAudio Score;
    bool isPressed = false;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Bird")&&isPressed==false){
            door.Disappear(); 
            isPressed=true;
            GetComponent<SpriteRenderer>().enabled = false; 
            GetComponent<Collider2D>().enabled = false;  
            Score.Scoresound();
        }
    }
    
}