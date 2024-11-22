using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int points;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerMovement_RB>())
        {
            //AudioManager.instance.PlayAudio(coinSound, "coindSound", false, 0.3f);
            GameManager.instance.SetPoints(GameManager.instance.GetPoints() + points);
            Destroy(gameObject);
        }
    }
}