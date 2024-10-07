using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackIdle : MonoBehaviour
{
    private Animator Animatie;
    public GameObject Player1;
    public GameObject Player2;
    public float DistanceBetweenPlayers;

    // Start is called before the first frame update
    void Start()
    {
        Animatie = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        DistanceBetweenPlayers = Vector3.Distance(Player1.transform.position, Player2.transform.position);

        if (Animatie != null) {
            if (DistanceBetweenPlayers>=0.25)
            {
                Animatie.SetTrigger("TrIdle");
            }
            else
            {
                Animatie.SetTrigger("TrAttack");
            }
        }
    }
}
