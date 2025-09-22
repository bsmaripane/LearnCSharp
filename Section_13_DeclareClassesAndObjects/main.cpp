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

class Account
{
	// Attribute
	string name{ "Main Account" };
	double balance{ 0.00 };

	// Method
	bool depost(double);
	bool withdraw(double);
};

int main()
{
	Player Maswi;
	Player Hero;

	Player players[]{ Maswi, Hero };

	vector<Player>player_vec{ Maswi };
	player_vec.push_back(Hero);

	Player* enemy{ nullptr };
	enemy = new Player;
	delete enemy;


	// Account class
	Account semape_account;
	Account maswi_account;



	cin.get();
	return 0;
}