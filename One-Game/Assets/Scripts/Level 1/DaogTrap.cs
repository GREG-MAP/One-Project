using UnityEngine;

public class DaogTrap : MonoBehaviour
{

    [SerializeField] private Transform _stP;
    [SerializeField] private Transform _endP;
    [SerializeField] private GameObject _trap;
    [SerializeField] private float _ts = 0f;
    [SerializeField] private float _speed = 0.1f;
    [SerializeField] private bool _rev;
    [SerializeField] private DeathScrine ds;

    private void Start()
    {
        transform.position = new Vector2(_stP.position.x, _stP.position.y + 0.5f);
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
        if(_rev == true)
        {
            transform.position = Vector2.Lerp(transform.position, _endP.position, _speed * Time.deltaTime);

            _ts += Time.deltaTime * _speed;
        }
        
        if(_ts >= 2f)
        {
            _rev = false;
        }

        if(_rev == false)
        {
            transform.position = Vector2.Lerp(transform.position, _stP.position, _speed * Time.deltaTime);

            _ts -= Time.deltaTime * _speed;
        }

        if(_ts <= 0f)
        {
            _rev = true;
        }

        
    }
}
