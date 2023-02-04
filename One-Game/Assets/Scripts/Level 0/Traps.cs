using UnityEngine;

public class Traps : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private DeathScrine ds;
   

    public bool _isReverse = true;
    private int _minspeed = 10;
    private int _maxspeed = 30;
    

    private void Awake()
    {
        _speed = Random.Range(_minspeed, _maxspeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.TryGetComponent(out PlayerMove pm))
        {
            pm.transform.gameObject.SetActive(false);

            ds.DeathSc();
        }
    }
    private void FixedUpdate()
    {

        if(_isReverse)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - Time.deltaTime * _speed);
        }

        if(transform.position.y < 9.5f)
        {
            transform.position = new Vector2(transform.position.x, 9.5f);

            _isReverse = false;

        }else if(_isReverse == false)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + Time.deltaTime * _speed);
        }

        if(transform.position.y > 20)
        {
            transform.position = new Vector2(transform.position.x, 20);

            _isReverse = true;
        }

    }
}
