#include <iostream>
#include <fstream>
#include <string>
using namespace std;

int main()
{
	system("cls");
	system("title Database");
	system("color 0f");
	cout << "Please enter choice"<<endl;
	cout << "1. input new student\n";
	cout << "2. search student by id\n";
	cout << "3. Edit an existing student information\n";
	cout << "4. display all students\n";
	cout << "5. exit\n";

	int choice;
	cin >> choice;

	switch (choice)
	{
	case 1:
		input();
		break;
	case 2:
		search();
		break;
	case 3:
		edit();
		break;
	case 4:
		display();
		break;
	case 5:
		break;
	default:
		break;
	}
}

void input()
{

}

void search()
{

}

void edit()
{

}

void display();
{

}