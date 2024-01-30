using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextText : MonoBehaviour
{
    private Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GetComponent<Text>();
        StartCoroutine(NextLine1());
        StartCoroutine(NextLine2());
    }
    
    IEnumerator NextLine1()
    {
        _text.text = "Using the WASD keys, move the player with rb.Addforce.";
        yield return new WaitForSeconds(5);
        _text.text = "Click the spawn cube button with your mouse to spawn the CUBE.";
    }
    IEnumerator NextLine2()
    {
        yield return new WaitForSeconds(10);
        _text.text = "Move close to the CUBE on the left to change your body material to it´s color.";
    }
}
