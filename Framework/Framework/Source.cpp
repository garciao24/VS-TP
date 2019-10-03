#include <iostream>
using namespace std;
int main()

//{
	//cout << "Hello World" << endl;
	//gpacalculator;
	//system("pause");
	//return 0;


{
	double grade;

	cout << "please put the grade" << endl;
	cin >> grade;
	if ((grade >= 90) && (grade <= 100))
	{
		cout << "your grade is: " << "A" << endl;
	}
	else if (((grade >= 80) && (grade < 90)))
	{
		cout << "your grade is: " << "B" << endl;
	}
	else if (((grade >= 70) && (grade < 80)))
	{
		cout << "your grade is: " << "C" << endl;
	}
	else if (((grade >= 60) && (grade < 70)))
	{
		cout << "your grade is: " << "D" << endl;
	}
	else
		cout << "repeat the class" << endl;
	system("pause");
	return 0;
}

