using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using SnakeGame;
public class GameEndsWhenSnakeCollidesWithBody
{
    // A Test behaves as an ordinary method
    [Test]
    public void GameEndsWhenSnakeCollidesWithBodySimplePasses()
    {
        GameObject snake = new GameObject();
        SnakeMovement  eatFood = snake.AddComponent<SnakeMovement>();
    }

    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator GameEndsWhenSnakeCollidesWithBodyEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
