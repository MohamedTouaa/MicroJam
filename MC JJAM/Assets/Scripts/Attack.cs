using TMPro;
using UnityEngine;

public class AxeAttack : MonoBehaviour
{
    public bool isAttacking = false;
    [SerializeField] saveP game_stat;

    public TextMeshProUGUI sheep;
    public TextMeshProUGUI cow;
    public TextMeshProUGUI humain;
    audioManagers mm;
    private void Start()
    {
        GameObject a = GameObject.Find("Player");
        mm = a.transform.GetChild(3).GetComponent<audioManagers>();
        game_stat.number_cow = 0;
            game_stat.number_ship = 0;
            game_stat.number_humain = 0;
    }
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isAttacking)
        {
            isAttacking = true;
            mm.playS("sword");
            GetComponent<Animator>().SetTrigger("Attack");
        }
        sheep.text = " sheep : " + game_stat.number_ship;
        cow.text = " cow : " + game_stat.number_cow;
        humain.text = " humain : " + game_stat.number_humain;
    }

    // Called when the attack animation hits something.
    private void OnTriggerEnter(Collider other)
    {
        if (isAttacking)
        {
            // Check if the collision object implements the IDamagable interface.
            IDamagable damagable = other.GetComponent<IDamagable>();
            if (damagable != null)
            {
                float damage = CalculateDamage(); // Calculate the damage to deal.
                damagable.Damage(damage); // Deal damage to the object.

              if(other.GetComponent<EnemyHealth>().currentHealth <= 0)
                {
                    if (other.tag == "cow")
                        game_stat.number_cow += 1;
                    if (other.tag == "sheep")
                        game_stat.number_ship += 1;
                    if (other.tag == "humain")
                        game_stat.number_humain += 1;

                }


            }
        }
    }

    private float CalculateDamage()
    {
        // You can calculate damage based on player stats or any other relevant factors.
        // For example, you can use the player's strength or weapon stats.
        // Replace this with your own logic.
        float baseDamage = 1f; // Replace with your base damage value.
        // Calculate the damage based on your game's mechanics.
        float finalDamage = baseDamage; // You can adjust this formula based on your game's mechanics.
        return finalDamage;
    }

    // Called when the attack animation begins.
    public void StartAttack()
    {
        isAttacking = true;
    }

    // Called when the attack animation ends.
    public void EndAttack()
    {
        
        isAttacking = false;
    }
}
