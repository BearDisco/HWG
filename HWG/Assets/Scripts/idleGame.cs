using UnityEngine;
using UnityEngine.UI;

public class idleGame : MonoBehaviour
{
    public Text coinText;
    
    public double coins;

    public void Start() {
        coins = 0;
    }

    public void Update(){
        coinText.text = "Coins: " + coins;
    }

    public void Click(){
        coins += 1;

    }
    
}
