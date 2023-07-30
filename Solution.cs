
using System;
using System.Linq;

public class Solution
{
    public int[] AsteroidCollision(int[] asteroids)
    {
        int index = -1;
        foreach (int currentAsteroid in asteroids)
        {
            bool currentAsteroidIsUndestroyed = true;
            while (currentAsteroidIsUndestroyed && index >= 0 && asteroids[index] > 0 && currentAsteroid < 0)
            {
                currentAsteroidIsUndestroyed = currentAsteroid + asteroids[index] < 0;
                if (currentAsteroid + asteroids[index] <= 0)
                {
                    --index;
                }
            }
            if (currentAsteroidIsUndestroyed)
            {
                asteroids[++index] = currentAsteroid;
            }
        }

        return asteroids.Take(index + 1).ToArray();
    }
}
