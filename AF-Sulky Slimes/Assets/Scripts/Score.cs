using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public int score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        TextMeshPro scoreNum = GetComponent<TextMeshPro>();

        if (other.gameObject.tag == "stack")
        {
            score += 1;
            scoreNum.text = score.ToString();
        }
    }
}
