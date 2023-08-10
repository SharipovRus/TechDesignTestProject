using UnityEngine;

public class chest_anim : MonoBehaviour
{
    private Animator animator;
    private BoxCollider2D boxCollider;
    private bool isPlayingAnimation = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isPlayingAnimation)
        {
            Vector2 clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(clickPos, Vector2.zero);

            if (hit.collider != null && hit.collider == boxCollider)
            {
                animator.Play("YourAnimationName", 0, 0);
                isPlayingAnimation = true;
            }
        }
    }

    // Callback for animation event (attach this to your animation's last keyframe)
    public void AnimationFinished()
    {
        isPlayingAnimation = false;
    }
}
