using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
	public Transform player;
	public Text scoreText;
	private float initialPlayerPosition;

    // Start is called before the first frame update
    void Start()
    {
     initialPlayerPosition = player.position.z;   
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (player.position.z-initialPlayerPosition).ToString("0");
    }
}
