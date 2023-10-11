using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salt : MonoBehaviour
{
    public float x; 
    public float y;
    public float z;
    public AudioSource shake;
    public int time;

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

        if (z > 100 && z < 200){
            if(time == 0){
                print("shake");
                shake.Play(0);
                time = 1;
            }
        }
        else{

            shake.Stop();
            time = 0;
        }
    }
    
}
