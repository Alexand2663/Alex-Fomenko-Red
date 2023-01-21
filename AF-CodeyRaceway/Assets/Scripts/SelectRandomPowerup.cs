using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectRandomPowerup : MonoBehaviour
{
    public List<GameObject> powerupList;
    public int randomNumberInList;
    public GameObject chosenPowerup;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && chosenPowerup != null)
        {
            Instantiate(chosenPowerup, transform.position, Quaternion.identity);
            chosenPowerup = null;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ItemBox")
        {
            randomNumberInList = Random.Range(0, powerupList.Count);
            chosenPowerup = powerupList[randomNumberInList];
        }
    }
}
