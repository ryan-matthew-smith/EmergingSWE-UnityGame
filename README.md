<h1>EmergingSWE-UnityGame</h1>

<table>
  <tr>
    <th colspan="2"><h3>Team: Group 1</h3></th>
  </tr>
  <tr>
    <th>Member</th>
    <th>Role</th>
  </tr>
  <tr>
    <td>Tiara Grier</td>
    <td>Scrum Master/Developer</td>
  </tr>
  <tr>
    <td>Taylor Lightbourne</td>
    <td>Developer</td>
  </tr>
  <tr>
    <td>Anthony Chiu</td>
    <td>Product Owner/Developer</td>
  </tr>
  <tr>
    <td>Ryan Smith</td>
    <td>Developer</td>
  </tr>
</table>

## <h3>Resource Links</h3>
<ul>
  <li><a href="https://trello.com/b/UdariJbe/snake-game" target="_blank">Backlog - Trello</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/scrum_standup_evidence.PNG" target="_blank">Sprint 1: Daily Scrum Evidence</a></li>
  <li><a href="https://github.com/ryan-matthew-smith/EmergingSWE-UnityGame/blob/main/Documents/Sprint%201/Sprint%201%20Review.pdf" target="_blank">Sprint 1: Sprint Review</a></li>
</ul>

## <h3>Sprint #1</h3>
<table>
<tr>
  <th colspan ="3">
    <h3>
      Story Point Forecast
    </h3> 
      
  </th>
    <tr>
    <th>Member</th>
    <th>Task & Rationale</th>
    <th>Points</th>
  </tr>
  <tr>
    <td>Anthony Chiu</td>
    <td>Implement Snake Speed Increase</td>
    <td>15</td>
    
  </tr>
  <tr>
    <td></td>
    <td>Implement Snake Collision with Snake Segment</td>
    <td>14</td>
          <tr>
    <td></td>
    <td>Implement Snake Collison with Walls</td>
    <td>14</td>
  </tr>
  </tr>
    <tr>
    <td></td>
    <td>Implement Snake Speed Increase</td>
    <td>6</td>
  </tr>
      <tr>
    <td>Anthony Chiu & Taylor Lightbourne</td>
    <td>Collectable Food Object</td>
    <td>8</td>
  </tr>
      <tr>
    <td>Tiara Grier</td>
    <td>Make UI Dynamically Scale with Screen</td>
    <td>3</td>
  </tr>
        <tr>
    <td></td>
    <td>Update Points UI to Increase on Food Collect</td>
    <td>4</td>
  </tr>
    <tr>
    <td>Ryan Smith</td>
    <td>Skybox Visual</td>
    <td>4</td>
       </tr>
       <tr>
          <td>Ryan Smith & Anthony Chiu</td>
    <td>Implement Camera That Follows Snake Object</td>
    <td>17</td>
  </tr>

</tr>
  
</table>
<p>Our forecast for spring 1 consisted of 85 points. The tasks that we wanted to accomplish during this sprint were related to implementing the core gameplay components of a snake game, such as the snake increasing in speed and length when consuming food, and the player receiving a game over when the snake either hits a wall or one of its own body segements. Story points were also given to items that improved the aesthetic of the game and providing a score UI for players. More points were placed onto tasks that focused on the gameplay, and movement of our game. Camera movement has the most story points (17) because we suspected there would be a lot of challenges in implementing a camera system that feel like you are tailing behind the snake (similar to how the camera is in Mario Kart), while also being mindful of providing a non-disorienting viewpoint for the player as the navigate the snake in a 3D space. This is the first time many of the team members are using Unity, and we anticipated this would be the most difficult portion of this scrum. In reality, some of these tasks ended being a lot easier than expected, so some their story points could have been decreased. </p>
<p> On the flip side, we anticipated the UI to be one of the easier tasks compared to the gameplay mechanics, thus those related tasks were given much lower story points; however, in reality, these ended up being some of our more challenging aspects of the project. On reflection, we maybe should have given them more points since it was the first time we were designing a UI with Unity and its tools.</p>



<table>
  <tr>
  <th colspan ="2">
    <h3>
      Decomposed Stories Into Task
    </h3> 
      </th>
    <tr>
    <th>Stories</th>
    <th>Task</th>
   </tr>
   <tr>
    <td>As a player, I want my input to control the Snake character so that my actions have an effect on the game.</td>
    <td>Implement Controllable Snake Object</td>
  </tr>
     <tr>
    <td>As a player, I want to be able to see the snake character and what is in front of me so that I can engage with the game world.</td>
    <td>Implement Camera That Follows Snake Object</td>
  </tr>
       <tr>
    <td>As a player, I want to be able to see game information in a HUD so that I can be motivated to know my status working towards the game objective.</td>
    <td>Implement Points UI</td>
  </tr>
         <tr>
    <td>As a player, I want the Snake's speed to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Speed Increase</td>
  </tr>
          <tr>
    <td>As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</td>
    <td>Implement Snake Collision with Walls</td>
  </tr>
            <tr>
    <td>As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</td>
    <td>Implement Snake Collision with Snake Segment</td>
  </tr>
              <tr>
    <td>As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Length Increase</td>
  </tr>
                <tr>
    <td>As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</td>
    <td>Implement Snake Length Increase</td>
  </tr>
                  <tr>
    <td>As the player, I want the UI interface to adapt to the window size of the game for an easy to read and flexible game experience.</td>
    <td>Make UI dynamically scale with screen</td>
  </tr>
                    <tr>
    <td>As the player, I want to have a visually appealing background (skybox) that will make the game feel more realistic.</td>
    <td>Implement Skybox Visuals</td>
  </tr>
     <tr>
    <td>As a player, I want to be able to collect food objects in the game so that I have an objective while playing.</td>
    <td>Implement Collectable Food Object</td>
  </tr>
       <tr>
    <td>As a player, I want to be able to see the UI update to display my current points when I collect food so that I can know my progress in the game.</td>
    <td>Update Points UI to Increase On Food Collectt</td>
  </tr>
         <tr>
    <td>As the player, I would like a visually appealing representation of the snake that is more advanced and detailed than the traditional 2D snake.</td>
    <td>Model 3D Snake in Blender</td>
  </tr>
           <tr>
    <td>As a player, I want the game to reset at certain points so that I can continue playing.</td>
    <td>Implement Scene Reset Function</td>
  </tr>
             <tr>
    <td>As a player, I want to know when I have lost the game so that I can know what to avoid and try again.</td>
    <td>Implement Game Failure Screen</td>
  </tr>
</table>


## 

<details>
<summary>Part 1: Product Inception and Planning</summary>
<br>
<h3>Product Vision</h3>
<p>Our product is for gamers who originally played the Snake game. This new and improved Snake is a three-dimensional game that reimagines and expands on the retro 2D Snake game. Unlike the original game, which has limited potential and restricted movement and environments, our product will grow the World of Snake giving the player a better visual experience and making players feel they have more control of the snake in a more open environment.</p>

## <h3>Rationale for Product Backlog Order</h3>
<ol>
  <li>The first user story will focus on implementing a controllable snake object, as it will serve as the game's main character. This is essential for players to be able to navigate the game by moving the snake forward and changing its direction.</li>
  <li>We will incorporate a camera feature that tracks the snake and follows the snake's movements. This will ensure that players have a clear view of the snake's path and the length of its body at all times.</li>
  <li>To build the original game, we will need to introduce a food object for the snake to consume. This element will allow users to earn points and contribute to increasing the game's difficulty as it progresses.</li>
  <li>Next, we will implement a scoring system, which will be displayed on the user interface.</li>
  <li>The next user story will be to develop the functionality for the score to increment whenever the snake collects food. This feature can be developed in parallel with the next two user stories (6 and 7).</li>
  <li>In the next user story, we will introduce the ability for the snake to grow in length upon consuming the food object.</li>
  <li>In line with enhancing the snake's capabilities upon consuming food, we will implement a feature that increases the snake's speed when it eats the food object.</li>
  <li>We will develop the ability to detect when the snake collides with its own body. This development will be vital for future features, so we ordered it to occur prior to those user stories.</li>
  <li>Following this, we will introduce a scene reset function for players to reset the game and start again. Initially, this functionality will be triggered manually for testing, but it will be needed in the last user story when the user loses the game.</li>
  <li>We predict the last user story will focus on implementing a game failure condition. This condition will be triggered when the snake collides with its own body, resulting in the game ending and the scene resetting.</li>
</ol>

## <h3>Definition of Ready</h3>
<ol>
  <li>Implement Controllable Snake Object
    <ul>
      <li><b>Story Points:</b> 7</li>
      <li><b>User Story:</b> As a player, I want my input to control the Snake character so that my actions have an effect on the game.</li>
    </ul>
  </li>
  <li>Implement Camera That Follows Snake Object
    <ul>
      <li><b>Story Points:</b> 17</li>
      <li><b>User Story:</b> As a player, I want to be able to see the snake character and what is in front of me so that I can engage with the game world.</li>
    </ul>
  </li>
  <li><b>Implement Collectable Food Object</b>
    <ul>
      <li><b>Story Points:</b> 8</li>
      <li><b>User Story:</b> As a player, I want to be able to collect food objects in the game so that I have an objective while playing.</li>
    </ul>
  </li>
  <li><b>Implement Points UI</b>
    <ul>
      <li><b>Story Points:</b> 3</li>
      <li><b>User Story:</b> As a player, I want to be able to see game information in a HUD so that I can be motivated to know my status working towards the game objective.</li>
    </ul>
  </li>
  <li><b>Update Points UI to Increase On Food Collect</b>
    <ul>
      <li><b>Story Points:</b> 4</li>
      <li><b>User Story:</b> As a player, I want to be able to see the UI update to display my current points when I collect food so that I can know my progress in the game.</li>
    </ul>
  </li>
  <li><b>Implement Snake Length Increase</b>
    <ul>
      <li><b>Story Points:</b> 15</li>
      <li><b>User Story:</b> As a player, I want the Snake's length to increase as I collect food so that I can be challenged by the games increasingly difficulty.</li>
    </ul>
  </li>
  <li><b>Implement Snake Speed Increase</b>
    <ul>
      <li><b>Story Points:</b> 6</li>
      <li><b>User Story:</b> As a player, I want the Snake's speed to increase as I collect food so that I can be challenged by the games increasingly difficulty.</li>
    </ul>
  </li>
  <li><b>Implement Snake Collision with Snake Segment</b>
    <ul>
      <li><b>Story Points:</b> 14</li>
      <li><b>User Story:</b> As a player, I want to be penalized when the Snake character collides with itself so that I can be challenged to avoid it.</li>
    </ul>
  </li>
  <li><b>Implement Scene Reset Function</b>
    <ul>
      <li><b>Story Points:</b> 13</li>
      <li><b>User Story:</b> As a player, I want the game to reset at certain points so that I can continue playing.</li>
    </ul>
  </li>
  <li><b>Implement Game Failure Condition</b>
    <ul>
      <li><b>Story Points:</b> 8</li>
      <li><b>User Story:</b> As a player, I want to know when I have lost the game so that I can know what to avoid and try again.</li>
    </ul>
  </li>
</ol>
</details>

