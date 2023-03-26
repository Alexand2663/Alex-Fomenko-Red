using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RemainingThrows : MonoBehaviour
{
    public int remainingThrows;
    public TMP_Text NumOfThrows;

    // Start is called before the first frame update
    void Start()
    {
        //NumOfThrows = this.gameObject.GetComponent<TextMeshPro>();
        remainingThrows = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            remainingThrows -= 1;
        }
        NumOfThrows.text = remainingThrows.ToString();
    }
}
