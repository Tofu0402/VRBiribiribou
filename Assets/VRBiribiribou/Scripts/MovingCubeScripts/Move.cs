using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f; // 移動速度
    public float changeDirectionInterval1 = 5f; // 移動方向を変更する間隔
    public float changeDirectionInterval2 = 10f;
    public float changeDirectionInterval2 = 15f;
    private string movingVector = "forward"; // 床の移動方向
    private float timer = 0f; // 経過時間を計測するタイマー


    private void Update()
    {
        // タイマーを更新する
        timer += Time.deltaTime;

        // 一定時間が経過したら移動方向を変更する
        if (timer >= changeDirectionInterval1)
        {
            movingVector = "right"; // 移動方向を反転させる
        }else if (timer >= changeDirectionInterval2)
        {
            movingVector = "left";
        }else if (timer >= changeDirectionInterval3)
        {
            movingVector = "down";
        }


        // 床を移動させる
        if (movingVector == "forward"){
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (player != null)
            {

                player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }else if(movingVector == "right"){
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }

    }

}