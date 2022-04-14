using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmentscript : MonoBehaviour
{
    public float speed;
    private int yourscoreis = 0;
// ________________________________
    void Start()
    {
        
    }
// ________________________________
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * speed);
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * speed);
        }
    }
// ________________________________
    void OnTriggerEnter2D(Collider2D col)
    {
        Destroy(col.gameObject);
        if(col.gameObject.tag == "SafeBall")
        {
        Destroy(col.gameObject);
        yourscoreis++;
        print(yourscoreis);
        }
        if(col.gameObject.tag == "KillerBall")
        {
        Destroy(col.gameObject);
        Destroy(gameObject);
        }
        if(col.gameObject.tag == "UltraKillerBallTag")
        {
        Destroy(col.gameObject);
        Destroy(gameObject);
        }
        
    }
}
