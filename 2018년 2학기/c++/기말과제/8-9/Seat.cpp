#include<iostream>
#include<string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

void Seat::setName(string name) { // �̸� ���� �Լ�
	this->name = name;
}
string Seat::getName() { // ����Ǿ��ִ� �̸� ���� �Լ�
	return name;
}