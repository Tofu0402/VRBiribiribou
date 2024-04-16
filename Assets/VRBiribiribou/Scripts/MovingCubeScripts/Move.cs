using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject player;
    public float speed = 1f; // 移動速度
    public float changeDirectionInterval1 = 5f; // 移動方向を変更する間隔
    public float changeDirectionInterval2 = 10f;
    public float changeDirectionInterval3 = 15f;
    public float changeDirectionInterval4 = 20f;
    public float changeDirectionInterval5 = 25f;
    private string movingVector = "forward"; // 床の移動方向
    private float timer = 0f; // 経過時間を計測するタイマー


    private void Update()
    {
        // タイマーを更新する
        timer += Time.deltaTime;

        if (timer > 30) return;

        // 一定時間が経過したら移動方向を変更する
        else if(timer>=changeDirectionInterval5){
            movingVector = "up";
        }
        else if(timer >= changeDirectionInterval4){
            movingVector ="right";
        }
        else if (timer >= changeDirectionInterval3)
        {
            movingVector = "down"; // 移動方向を下に変更
        }
        else if (timer >= changeDirectionInterval1)
        {
            movingVector = "right"; // 移動方向を右に変更
        }


        // 床を移動させる
        if (movingVector == "forward")
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
            }
        }
        else if (movingVector == "right")
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.right * speed * Time.deltaTime);
            }
        }
        else if (movingVector == "left")
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.left * speed * Time.deltaTime);
            }
        }
        else if (movingVector == "down")
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }
        else if (movingVector == "up")
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (player != null)
            {
                player.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
        }
        
    }
}
