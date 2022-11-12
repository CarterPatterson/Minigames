using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool isBallSpawned = false;

    public GameObject killBallPrefab;
    
    public float secondsPassed = 0;
    public Vector2 randomVelocityRange;

    public int secondsTillBallSpawn = 0;
    

    void Update()
    {
        secondsPassed += Time.deltaTime;

        if (isBallSpawned) return;
        
        if (secondsPassed >= secondsTillBallSpawn)
        {
            isBallSpawned = true;

            var killBall = Instantiate(killBallPrefab);
            var rigidbody = killBall.GetComponent(typeof(Rigidbody)) as Rigidbody;

            var random = Random.Range(randomVelocityRange.x, randomVelocityRange.y);
            var randomVelocity = new Vector3(random, 0, random);
            
            rigidbody.AddForce(randomVelocity);

        }
    }
}
