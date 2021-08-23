https://www.codewars.com/kata/577bd8d4ae2807c64b00045b/train/csharp

Problem:
Create a function that returns the name of the winner in a fight between two fighters.

Each fighter takes turns attacking the other and whoever kills the other first is victorious. Death is defined as having health <= 0.

Each fighter will be a Fighter object/instance. See the Fighter class below in your chosen language.

Both health and damagePerAttack (damage_per_attack for python) will be integers larger than 0. You can mutate the Fighter objects.

Example:
public class Fighter {
public string Name;
public int Health, DamagePerAttack;
public Fighter(string name, int health, int damagePerAttack) {
this.Name = name;
this.Health = health;
this.DamagePerAttack = damagePerAttack;
}
}
Data:
objects
function
if else

algorithm:
assign fighter1: name, health, DamagePerAttack
assign fighter2: name, health, DamagePerAttack
fighter1 goes first
fighter2.health -= fighter1.DamagePerAttack
if fighter2.health <= 0, fighter1.health -= fighter2.DamagePerAttack
repeat until one of the fighters health is <= 0
