#ifndef SEAT_H
#define SEAT_H
#include <string>
using namespace std;

class Seat {	// 좌석 클래스
	string name;
public:
	Seat() {} // 8개의 Seat 객체 생성하기위한 생성자
	void setName(string name); // 이름 저장하는 함수
	string getName(); // 이름을 리턴할 함수
};
#endif