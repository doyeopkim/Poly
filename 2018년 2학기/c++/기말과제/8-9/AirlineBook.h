#ifndef AIRLINEBOOK_H
#define AIRLINEBOOK_H
#include "Console.h"
#include "Schedule.h"
using namespace std;

class AirlineBook {	// 예약 클래스
	Schedule* schedule; // 3개의 객체 생성을 위한 객체 포인터
public:
	AirlineBook();	// 객체 3개 생성할 생성자
	~AirlineBook(); // 소멸자
	void showSchedule(int time);	// 입력받은 시간대 스케쥴 출력 함수
	void showAllSchedule();	//모든 스케쥴 출력 함수
	Schedule getSchedule(int time);	// Main에서 입력받은 시간대 번지수 리턴할 함수
};
#endif