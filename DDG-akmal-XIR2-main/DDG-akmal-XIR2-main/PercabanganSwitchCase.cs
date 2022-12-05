using System.Collections;
using UnityEngine;

public class PercabanganSwitchCase : MonoBehaviour
{
    int angka = 2;
    void Start() {
        switch (angka)
        {
            case 1:
                Debug.Log("Telor");
            break;
            case 2:
                Debug.Log("Ayam Bakar");
            break;
            case 3:
                Debug.Log("Sate Ayam");
            break;
            default:
                Debug.Log("Jus Apel");
            break;
        }
    }
}
