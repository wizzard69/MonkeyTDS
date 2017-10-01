using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int dameageToGive;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHealthManager>().HurtPlayer(dameageToGive);
        }
    }
}
