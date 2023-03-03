using UnityEngine;

public class Traps1lvl : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private DeathScrine ds;
   

    public bool _isReverse = true;
    private int _minspeed = 30;
    private int _maxspeed = 70;
    

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
    private void Update()
    {

        if(_isReverse)
        {
            transform.position = new Vector2(transform.position.x - Time.deltaTime * _speed, transform.position.y);
        }

        if(transform.position.x < 1030f)
        {
            transform.position = new Vector2(1030f, transform.position.y);

            _isReverse = false;

        }else if(_isReverse == false)
        {
            transform.position = new Vector2(transform.position.x + Time.deltaTime * _speed, transform.position.y);
        }

        if(transform.position.x > 1310f)
        {
            transform.position = new Vector2(1310f, transform.position.y);

            _isReverse = true;
        }

    }
}
