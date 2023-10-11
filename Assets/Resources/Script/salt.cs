using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salt : MonoBehaviour
{
    public float x; 
    public float y;
    public float z;
    public AudioSource shake;
    private int time;

    // Start is called before the first frame update
    void Start()
    {
        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
        z = transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.eulerAngles.x;
        y = transform.eulerAngles.y;
        z = transform.eulerAngles.z;

        if (z > 80){

            print("shake");
            if(time == 0){
                shake.Play(0);
                time +=1;
            }
            
        }
        else{

            shake.Pause();
            time = 0;
        }
    }
    
}
