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
	system("cls");
	string fname;
	string lname;
	int age;
	int stdID;

	cout << "input first name";
	cin >> fname;
	cout << "input last name";
	cin >> lname;
	cout << "input student age";
	cin >> age;
	//cout << "input student date of birth";
	//cin >> date;
	cout << "enter student id";
	cin >> stdID;

	string stdID2 = to_string(stdID);
	stdID2.append(".txt");

	ofstream newStudent(stdID2);
	newStudent << fname << " " << lname << " " << stdID << " " << age <<endl;
	newStudent.close;


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