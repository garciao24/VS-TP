#include <iostream>
#include <fstream>
#include <string>
#include<vector>
using namespace std;

struct schedule{
	schedule(string bi,int x,  int io,  int ni,  int pi) :classname(bi),classnum(x), grade1(io), grade2(ni), grade3(pi) {}
	string classname;
	int classnum;
	int grade1;
	int grade2;
	int grade3;
};


void input()
{
	system("cls");
	string fname;
	string lname;
	int age;
	int stdID;
	int count = 0;

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
	newStudent << fname << " " << lname << " " << stdID << " " << age <<""<<count<<endl;
	newStudent.close();

	

}


void addclass()
{
	vector<schedule> shd;
	cout << "Add student schedule\n";
	int count=0;
	int choice;
	string depa;
	int grade1;
	int grade2;
	int grade3;
	int num;
	while (true)
	{
		cout << "to continue to Add class to student schedule press 1\n";
		cout << "to finish press 2\n";
		cin >> choice;
		if (count >= 5)
		{
			cout << "max allowed classes reached\n";
			return;
		}
		switch (choice)
		{
		case 1:
			cout << "input class departments (CS....etc.)\n";
			cin >> depa;
			
			cout << "Enter class course number\n";
			cin >> num;
			cout << "enter grade 1\n";
			cin >> grade1;
			cout << "enter grade 2\n";
			cin >> grade2;
			cout << "enter grade 3\n";
			cin >> grade3;
			shd.push_back(schedule(depa,num,grade1,grade2,grade3));
			count++;
			break;

		case 2:
			if (1 > count)
			{
				cout << "must have atleast one class\n";
				break;
			}
			return;
		default:
			cout << "invalid input try again;\n";
			break;
		}
	}
}

void search()
{
	system("cls");
	string fname;
	string lname;
	int age;
	int stdID;

	cout << "enter student id"; 
	cin >> stdID;
	string stdID2 = to_string(stdID);
	stdID2.append(".txt");




}

void edit()
{

}

void display()
{

}

int main()
{
	system("cls");
	system("title Database");
	//system("color 0f");
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
