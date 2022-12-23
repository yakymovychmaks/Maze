using UnityEngine;
using TMPro;


public class Player : MonoBehaviour
{

    [SerializeField] private float _healthPoint;

    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private TMP_Text _scoreText;

     private float _score;

    private void Start()
    {
         _healthText.text = _healthPoint.ToString();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Coin coin))
        {
            Destroy(coin.gameObject);

            _score += coin.Value;
            _scoreText.text = _score.ToString();
        }
        else if (other. TryGetComponent(out Finish finish))
        {
            Destroy(gameObject);
        }
    }

}
