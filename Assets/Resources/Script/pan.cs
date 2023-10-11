using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pan : MonoBehaviour
{
    private float x,y,z,xz,xs, xy; 
    public AudioSource fire, addsalt, cook;
    public int time, cooktime;
    public GameObject Steak;
    public Material rawmaterial,cookedmaterial,donematerial;
    public Text step;

    // Start is called before the first frame update
    void Start()
    {
        
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        xs = Steak.transform.position.x;
        xz = Steak.transform.position.z;
        cooktime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
        x = transform.position.x;
        y = transform.position.y;
        z = transform.position.z;
        xs = Steak.transform.position.x;
        xy = Steak.transform.position.y;
        xz = Steak.transform.position.z;
        Steak.GetComponent<MeshRenderer> ().material = rawmaterial;

        if ((x is >=6.1f and <=6.4f) && (z is >=3.8f and <=4.1f)){
            //print("fire");
            if(time == 0){
                fire.Play(0);
                time +=1;
                print("fire on");
            }
            if(((xs >=(x-0.1f)) & (xs<(x+0.2f)))& ((xz >=(z-0.1f)) &(xz < (z+0.2f)))){
                //print("cook");
                
                if(cooktime ==0){
                    cook.Play(0);
                }
                // x = transform.position.x;
                // y = transform.position.y;
                // z = transform.position.z;
                // xs = Steak.transform.position.x;
                // xy = Steak.transform.position.y;
                // xz = Steak.transform.position.z;
                cooktime +=1;
                // xs = x;
                // xy= y+0.1f;
                // xz = z;
                
                if (cooktime >3000){
                    Steak.GetComponent<MeshRenderer> ().material = cookedmaterial;
                    //step.text = "add salt";
                    print("add");
                }
                if(cooktime >8000){
                    Steak.GetComponent<MeshRenderer> ().material = donematerial;
                }
                  
            }



            
        }
        else{

            fire.Pause();
            time = 0;
        }
    }
}
