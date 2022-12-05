using System.Collections;
using UnityEngine;

public class Percabangan : MonoBehaviour {
    int nilai = 88;
    void Start(){
        if (nilai > 90){
            Debug.Log("Nilai A");
        }else if (nilai > 70 && nilai <= 90) {
            Debug.Log("Nilai B");
        }else if (nilai > 50 && nilai <= 70) {
            Debug.Log("Nilai C");
        }else{
            Debug.Log("Nilai D");
        }
    }
}
