using UnityEngine;
using UnityEngine.UI;

public class Tujuan : MonoBehaviour
{
    public Text TeksPesan;
    void Start()
    {
        TeksPesan.text = "";
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
    {
        TeksPesan.text = "MENANG!";
        Debug.Log("Player sampai di tujuan");
    }
    }
}