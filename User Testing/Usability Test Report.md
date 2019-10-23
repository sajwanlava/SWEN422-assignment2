# Usability Test Report

The Usability Tests provided us with some useful user feedback about our prototype. This report is a presentation of the received feedback and test results, evaluating the usability metrics against the pre-approved goals, subjective evaluations, and specific usability problems and recommendations for resolution. The recommendations will be categorically sized by development to aid in the implementation strategy.

This report will be split in two sections as the team ran two usability group tests. The second group ran with slight modifications of the functionality of the game based on group one's feedback and results.

## Metrics and goals

Completion success and error rates showed what functionality was missing or incomplete in our prototype. Time-to-completion of scenarios was useful because it showed which scenarios took longer to complete, often due to design/layout flaws. However, the best feedback was received through subjective evaluations and commentary while testing.

Our goals with this testing were to establish a baseline of user performance, establish and validate user performance measures, and identify potential design concerns to be addressed in order to improve the efficiency, productivity, and end-user satisfaction.

Metrics such as 'time-on-task' showed whether scenarios can be completed 'quickly and easily', as is one of our usability goals. Subjective evaluations and commentary gave us deeper insight into potential design concerns and how efficient and satisfying the interface is for our users

## Results

This section outlines the time-on-task, completion rates, error rates and any further notes for any specific tasks. There may be deviation in tasks and do not hold information as it was extremely hard to mediate how a player will interact with the tasks when within the game.

### Group One Results

**TIMES**

| Task                                             | Player One | Player Two | Player Three | Player Four | Player Five | **AVERAGE TIME** |
| ------------------------------------------------ | ---------- | ---------- | ------------ | ----------- | ----------- | -----------------|
| Select Tutorial from the Menu                    | 5.51       | 7.50       | 7.02         | 4.58        | 4.18        | |
| Move towards the big white cube                  | 12.01      | 2.43       | 7.32         | 11.96       | 2.63        | |
| Move towards the sinking white cube              | 6.75       | 7.03       | 17.73        | 7.75        | 5.16        | |
| Look up to the top of the original cube          | 2.08       | 3.48       | 1.52         | 2.45        |             | |
| Walk through the orange portal                   | 6.95       | 6.02       | 6.30         | 7.73        | 8.02        | |
| Walk back through the blue portal                | 2.36       | 3.03       | 1.26         | 5.23        | 11.09       | |
| Fire a portal at the big white cube              | 1.02       | 3.26       | 11.9         | 7.63        | 7.02        | |
| Walk through the blue portal                     | 2.23       | 3.23       | 3.26         |             | 1.0         | |
| Walk back through the orange portal              | 3.25       | 3.02       | 2.95         | 4.70        | 9.33        | |
| Fire a portal at a grey surface                  | 1.90       | 2.22       | 21.6         | 3.10        | 3.00        | |
| Fire a portal at open space                      |            | 2.04       | 2.16         | 9.48        | 2.40        | |
| Fire a portal at the ground                      |            | 0.52       | 1.26         | 0.72        | 2.40        | |
| Exit the level through the hole in the wall      | 14.69      | 64.60      | 72.2         | 47.68       | 38.76       | |
| Level One: Reach the goal as quickly as possible | 48.40      | 24.60      | 36.62        | 70          | 130.54      | |


**TASK RATES**

| Task                                                 | Completion Rate % | Error-Free Rate % | Notes |
| ---------------------------------------------------- | ----------------- | ----------------- | ----- |
| Select Tutorial from the Menu                        |     100%          |     80%           |Without a pointer coming from the sensor, some players selected the wrong level.         |
| Move towards the big white cube                      |      100%         |   60%             |Objects were too large to differentiate what was the necessary shape to walk towards.|
| Move towards the sinking white cube                  |       100%        |       80%         |Objects were too large to differentiate what was the necessary shape.            |
| Look up to the top of the original cube              |         100%      |        100%       |       |
| Walk through the orange portal                       |         100%      |        100%       |       |
| Walk back through the blue portal                    |        100%       |        100%       |       |
| Fire a portal at the big white cube                  |      100%         |         100%      |       |
| Walk through the blue portal                         |      100%         |           100%    |       |
| Walk back through the orange portal                  |         100%      |         100%      |       |
| Fire a portal at a grey surface                      |         100%      |         40%       |Grey was not easily differentiable to white                                               |
| Fire a portal at open space                          |    100%           |    100%           |       |
| Fire a portal at the ground                          | 100%              |100%               |       |
| Exit the level through the hole in the wall          |  100%             |    60%            |Hole was not obvious, to two of the five players. However, it has been decided this is more of a puzzle solving issue rather than functionality.|
| **Level One**: Reach the goal as quickly as possible |  100%             |    60%            |One user got launched up a wall and experienced vertigo. Another managed to shoot right through a wall and finish the level quite quickly. A lot had difficulties understanding what the goal was.|


**PROBLEMS**

These problems are based on testers one till five of our pre-test and post-test questionnaires.

| Problem | Impact (Low, Moderate, High) | Frequency (Low, Moderate, High) | Severity (1-4) <!-- 1 is high severity and 4 is the lowest --> |
| ------- | ---------------------------- | ------------------------------- | -------------------------------------------------------------- |
| Trouble finding the hole in the wall during the first level and walked the perimeter of the first area twice        | Moderate                             |        Moderate                         |            4                                                    |
| **A side platform wall too low which made the first person camera launch up the wall and nearly fall into nothingness which was vertigo and motion-sickness inducing**       |     High                         |             Moderate                    |                  1                                             |
| **Glitch in the game as players are able to shoot through an obstacle** |             High                 |                Moderate                 |                     1                                          | 1
| Confusing for players as context of the game is not known which meant that on multiple occasions some through portals in quick succession only to wind up where they were initially |         Moderate                     |                High                 |                          2                                     |
| The colour difference between the grey and the white is not obvious enough |         Moderate                     |             High                    |              3                                                 |
| Other levels are accidentally chosen and there is no option to confirm choice or go to the menu again, so have to go through an already completed level/tutorial. | High | High | 1 |
| Green goal was not obvious | High | Moderate | 1 |
| Green goal takes too long to register level completion | High | High | 1 |
| **Shapes were too big which meant that the game was too disorienting for some players** | Low | Low | 3 |
| **Portal balls were moving too fast** | Moderate | Moderate | 3 |
| **Needs to be more immersing so the environment feels more complete** | Low | Low | 3 |
| Too difficult to navigate the menu by clicking on the correct level | High | High | 1 |

#### Fixes Between Test Groups

Between the user groups testing, the team managed to get the following problems improved. They are also bold in the table above. 

1.  *Needs to be more immersing so the environment feels more complete* - Sounds were implemented so when the users would shoot and go through the portals there would be different sounds associated with the action.
2.  *Shapes were too big which meant that the game was too disorienting for some players* - A lot of the players had issues with the sizing of level one so the wall sizes were decreased to solve this.
3.  *A side platform wall too low which made the first person camera launch up the wall and nearly fall into nothingness which was vertigo and motion-sickness inducing* - This wall was increased to prevent anyone else being able to jump on it.
4.  *Portal balls were moving too fast* - Velocity was decreased which made the rebound action more natural.
5.  *Glitch in the game as players are able to shoot through an obstacle* - Minor code change was implemented to solve this issue

### Group Two Results

**TIMES**

| Task                                                 | Player Six | Player Seven | Player Eight | Player Nine | Player Ten | Player Eleven | Player Twelve | **AVERAGE TIME** |
| ---------------------------------------------------- | ---------- | ------------ | ------------ | ----------- | ---------- | ------------- | ------------- |------------------|
| Select Tutorial from the Menu                        | 21.82      | 10.62        | 9.43         | 58.67       | 7.33       | 1.00          | 4.05          | |
| Move towards the big white cube                      | 8.80       | 4.23         | 1.86         | 19.00       | 5.22       | 4.20          | 2.20          | | 
| Move towards the sinking white cube                  | 10.48      | 6.63         | 8.95         | 12.30       | 60.63      | 12.75         | 5.56          | |
| Look up to the top of the original cube              | 2.83       | 1.66         | 1.40         | 3.26        | 2.59       | 2.48          | 1.65          | |
| Walk through the orange portal                       | 8.63       | 4.25         | 16.40        | 7.00        | 4.56       | 5.32          | 4.06          | |
| Walk back through the blue portal                    | 9.25       | 3.75         | 2.69         | 2.35        | 1.82       | 0.90          | 2.35          | |
| Fire a portal at the big white cube                  | 11.23      | 13.46        |              | 16.33       |            | 3.32          | 3.25          | |
| Walk through the blue portal                         | 5.52       | 1.13         | 2.11         | 1.20        | 4.30       | 0.88          | 1.72          | |
| Walk back through the orange portal                  | 1.25       | 6.02         | 3.15         | 5.25        | 1.92       | 0.78          | 3.95          | |
| Fire an orange portal at the grey shape              | 1.96       | 2.70         | 1.43         | 4.15        | 2.20       | 1.95          | 1.72          | |
| Fire a portal into open space                        | 1.78       | 1.92         | 4.99         | 4.85        | 3.70       | 0.90          | 1.62          | |
| Fire a portal at the ground                          | 0.99       | 0.65         | 0.89         | 1.09        | 1.83       | 0.86          |               | |
| Exit the level through the hole in the wall          | 63.86      | 42.36        | 30.48        | 116.74      | 54.23      | 24.93         | 22.25         | |
| **Level One**: Reach the goal as quickly as possible | 100.86     | 65.62        | 41.85        | 273.19      | 32.51      | 29.37         | 30.72         | |


**TASK RATES**

| Task                                                 | Completion Rate % | Error-Free Rate % | Notes |
| ---------------------------------------------------- | ----------------- | ----------------- | ----- |
| Select Tutorial from the Menu                        |     100%          |      42%          |A lot of issues selecting between game options in the menu. One player had to do it four times.                        |
| Move towards the big white cube                      |      100%         |     100%          |       |
| Move towards the sinking white cube                  |         100%      |     86%           |Player said he knew how to use a vive, but physically walked into a peice of furniture at the other end of the room.       |
| Look up to the top of the original cube              |         100%      |       100%        |       |
| Walk through the orange portal                       |      100%         |        74%        |Unsure how to play portal and did not understand the concept of the game                                                   |
| Walk back through the blue portal                    |      100%         |       100%        |       |
| Fire a portal at the big white cube                  |       100%        |       74%         |Unsure how to play portal and did not understand the concept of the game                                                   |
| Walk through the blue portal                         |       100%        |        100%       |       |
| Walk back through the orange portal                  |       100%        |       100%        |       |
| Fire an orange portal at the grey shape              |       86%         |         74%       |Some players couldn't differentiate between the white and grey like the last user group. A player described themselves as "colour-blind"       |
|Fire a portal into open space                         |100%               | 100%              |       |
| Fire a portal at the ground                          |         100%      |           100%    |       |
| Exit the level through the hole in the wall          |         100%      |        43%        |Big white square on the side wall for aesthetic purposes confused some players as they thought that was the hole. Players took a while finding the hole, but that is part of the puzzle. Players in this group also did not realise that they could shoot a portal to the other side of the hole to complete the tutorial.|
| **Level One**: Reach the goal as quickly as possible |      100%         |       57%         |Goal was once again unclear and took too long to register that the level had been complete. Player managed to go between the walls and the level had to be restarted on our end. Green luminance on the portal confused players and they thought it was the goal which induced repetitive walking through the portals. One player walked in between the two portals and got sucked in one.|


**PROBLEMS**

These problems are based on the testers six till twelve of our pre-test and post-test questionnaires.

| Problem | Impact (Low, Moderate, High) | Frequency (Low, Moderate, High) | Severity (1-4) <!-- 1 is high severity and 4 is the lowest --> |
| ------- | ---------------------------- | ------------------------------- | -------------------------------------------------------------- |
| Too difficult to navigate the menu by clicking on the correct level | High | High | 1 |
| Confusing for players as context of the game is not known which meant that on multiple occasions some through portals in quick succession only to wind up where they were initially |         Moderate                     |                High                 |                          1                                      |
| The colour difference between the grey and the white is not obvious enough |         Moderate                     |             High                    |              2                                                  |
| Other levels are accidentally chosen and there is no option to confirm choice or go to the menu again, so have to go through an already completed level/tutorial. | High | High | 1 |
| Green goal was not obvious | High | Moderate | 1 |
| Green goal takes too long to register level completion | High | High | 1 |
| Able to go between walls in level 1 | High | Low | 2 |
| If walking between two portals close together like the default in level 1, players can get sucked into one portal even without intending to | Low | Low | 4 |
| Luminance of the blue portal is slightly green which confuses some users into thinking that it is the goal | Low | Low | 3 |
| Unclear how to select different menu options | High | Low | 2 |


## Further Recommendations

It would be recommended for the team to tackle the issues of a high severity of 1 or 2 as these problems made game play slow, difficult and tedious. A lot of the issues are stemmed from having a visible tracking pointer on the controllers so it would be easier to navigate the menu and aim the portals. 

Another high priority task that the product would benefit by fixing would be the use of help notes and the inclusion of the game objective within the gameplay of the tutorial level. This was because after testing it was apparent to see that plenty of users actually were not familiar with the concept of using a vive and the idea of the game 'Portal'.