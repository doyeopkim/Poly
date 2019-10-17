#include<iostream>
#include<string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

void Seat::setName(string name) { // 이름 저장 함수
	this->name = name;
}
string Seat::getName() { // 저장되어있는 이름 리턴 함수
	return name;
}