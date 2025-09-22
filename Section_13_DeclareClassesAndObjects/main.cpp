// Section 13 Declare Classes and Objects

#include <iostream>
#include <string>
#include <vector>

using namespace std;

class Player
{
	// attributes
	string name;
	int health;
	int xp;

	// Method
	void talk(string);
	bool is_dead();
};

int main()
{
	Player Maswi;
	Player Hero;

	Player* enemy{ nullptr };
	enemy = new Player;
	delete enemy;

	cin.get();
	return 0;
}