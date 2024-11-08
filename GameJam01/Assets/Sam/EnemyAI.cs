using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // reference to the player's transform


    public float moveSpeed = 5f; // the enemy's move speed
    public float rotationSpeed = 5f; // the speed at which the enemy rotates
    public float chaseRange = 10f; // the distance at which the enemy starts chasing the player

    private void Update()
    {
        // calculate the distance between the enemy and the player
        float distance = Vector3.Distance(player.position, transform.position);

        ChasePlayer(distance); // method that holds the logic for enemy to chase player
    }


    private void ChasePlayer(float distance)
    {
        // if the distance is less than a certain threshold, move towards the player
        if (distance < chaseRange)
        {
            // calculate the direction towards the player
            Vector3 direction = (player.position - transform.position).normalized;

            // move the enemy towards the player
            transform.position += direction * moveSpeed * Time.deltaTime;

            // calculate the rotation towards the player
            Quaternion lookRotation = Quaternion.LookRotation(direction);

            // smoothly rotate towards the player
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, rotationSpeed * Time.deltaTime);

        }
    }


}
