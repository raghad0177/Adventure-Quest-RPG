# Adventure-Quest-RPG
BattleSystem
Overview
The BattleSystem class simulates a turn-based battle between a player and a monster. The system manages attacks, calculates damage, and determines the outcome of the battle based on the health of the participants.

Class Details
BattleSystem
The BattleSystem class contains two main methods:

Attack(dynamic attacker, dynamic target): Simulates an attack from the attacker to the target, calculates damage, and updates the target's health.
StartBattle(Player attacker, Monster target): Starts the battle between the player and the monster, alternating turns until one of them is defeated.
Methods
int Attack(dynamic attacker, dynamic target)
Simulates an attack from the attacker to the target, calculates the damage dealt, and updates the target's health.

Parameters:
attacker (dynamic): The attacking entity.
target (dynamic): The target entity.
Returns:
int: The updated health of the target.
Logic:
If the target's health is less than 0, set damage to 0 and target's health to 0.
Calculate damage as the difference between the attacker's attack power and the target's defense.
Update the target's health by subtracting the damage.
Ensure the target's health does not go below 0.
Print the attack details and the updated health of the target.
int StartBattle(Player attacker, Monster target)
Starts a turn-based battle between the player and the monster until one of them is defeated.

Parameters:
attacker (Player): The player attacking.
target (Monster): The monster being attacked.
Returns:
int: The remaining health of the winner.
Logic:
Initialize a random number generator.
Loop while both the attacker and the target have health greater than 0:
Randomly determine whose turn it is to attack.
If it's the attacker's turn, call the Attack method with the attacker and target.
If it's the target's turn, call the Attack method with the target and attacker.
Print the result of the battle based on who has health remaining.
Return the health of the winner.
