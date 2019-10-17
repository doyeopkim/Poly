#include <iostream>
#include <string>
#include "AirlineBook.h"
#include "Console.h"
#include "Schedule.h"
#include "Seat.h"
using namespace std;

AirlineBook::AirlineBook() { // 기본 생성자
	schedule = new Schedule[3]; // Schedule 객체 3개 생성
}
AirlineBook::~AirlineBook() { // 소멸자
	delete[] schedule;
}
void AirlineBook::showSchedule(int time) { // 선택된 스케줄 보여주기
	
	cout << "\n      1번석   2번석   3번석   4번석   5번석   6번석   7번석   8번석" << endl;
	switch (time+1) { // time에서 1을 빼서 받았으므로 1을 다시 더함
	case 1:
		cout << "07시:";
		break;
	case 2:
		cout << "12시:";
		break;
	case 3:
		cout << "17시:";
		break;
	}
	schedule[time].show(); // Schedule 객체의 show() 함수 호출
	cout << endl;
}
void AirlineBook::showAllSchedule() { // 모든 스케줄 출력
	for (int i = 0; i < 3; i++)
	{
		showSchedule(i);
	}
	cout << endl;
}
Schedule AirlineBook::getSchedule(int time) { // Main에서 입력받은 시간대 번지수 리턴
	return schedule[time];
}