#ifndef SCHEDULE_H
#define SCHEDULE_H
#include <string>
#include "Seat.h"
using namespace std;

class Schedule {	// 스케쥴 클래스
	string name;
	int seatNum;
	Seat* seat; // 8개의 객체 생성을 위한 객체 포인터
public:
	Schedule(); // 기본 생성자
	void show(); // 좌석 출력
	void book(int seatNum, string name);	// 예약 함수
	void cancle(int seatNum, string name);	// 예약 취소 함수
	void search(int time, string name); // 예약 찾기 함수
};
#endif