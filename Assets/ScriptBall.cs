using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBall: MonoBehaviour
{
    public GameObject Circle;
    public GameObject ball;
    public GameObject UltraKillerBall;  
// ________________________________  
    void Start()
    {
        InvokeRepeating("BallFunction", 1, 1);
        InvokeRepeating("BallKiller", 15, 15);
        InvokeRepeating("UltraKillerBallFunction", 100, 100);
    }
// ________________________________
    void BallFunction()
    {
        int x = Random.Range(-7, 7);
        int y = 5;
        Vector2 ballcordinats = new Vector2(x, y);
        Instantiate(Circle, ballcordinats, Quaternion.identity);
    }
// ________________________________    
    void BallKiller()
    {
        int x = Random.Range(-7, 7);
        int y = 5;
        Vector2 ballcordinats = new Vector2(x, y);
        Instantiate(ball, ballcordinats, Quaternion.identity);
    }
// ________________________________ 
    void UltraKillerBallFunction()
    {
        int x = Random.Range(-7, 7);
        int y = 5;
        Vector2 ballcordinats = new Vector2(x, y);
        Instantiate(UltraKillerBall, ballcordinats, Quaternion.identity);
    }

}
