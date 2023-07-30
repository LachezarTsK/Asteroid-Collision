
/**
 * @param {number[]} asteroids
 * @return {number[]}
 */
var asteroidCollision = function (asteroids) {

    let index = -1;
    for (let currentAsteroid of asteroids) {

        let  currentAsteroidIsUndestroyed = true;
        while (currentAsteroidIsUndestroyed && index >= 0 && asteroids[index] > 0 && currentAsteroid < 0) {
            currentAsteroidIsUndestroyed = currentAsteroid + asteroids[index] < 0;
            if (currentAsteroid + asteroids[index] <= 0) {
                --index;
            }
        }
        if (currentAsteroidIsUndestroyed) {
            asteroids[++index] = currentAsteroid;
        }
    }

    return asteroids.slice(0, index + 1);
};
