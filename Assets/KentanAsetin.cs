using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;

public class KentanAsetin : MonoBehaviour
{
    public GameObject ductTape;
    public GameObject toolBoxClosed;
    public GameObject crowBar;
    public GameObject flashLight;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ductTape = GameObject.Find("Ilmastointiteippi");
        ductTape.transform.position = new Vector3(-7f, 0f, 7f);

        toolBoxClosed = GameObject.Find("Tyokalupakki");
        toolBoxClosed.transform.position = new Vector3(6f, 0f, -7f);

        crowBar = GameObject.Find("Sorkkarauta");
        crowBar.transform.position = new Vector3(-7f, 1, -7f);
        
        flashLight = GameObject.Find("Taskulamppu");
        flashLight.transform.position = new Vector3(7f, 1f, 7f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
