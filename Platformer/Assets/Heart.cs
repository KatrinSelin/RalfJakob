using System.Collections;
    {
        Hero character = collision.GetComponent<Hero>();

        if (character)
        {
            character.Lives++;
            Destroy(gameObject);
        }
    }

}