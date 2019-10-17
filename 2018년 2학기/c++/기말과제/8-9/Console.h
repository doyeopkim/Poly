#ifndef CONSOLE_H
#define CONSOLE_H
#include<string>
using namespace std;

class Console {	// 콘솔 클래스
public:
	static int Menu();	// 메뉴입력(선택) 함수
	static int Time();	// 시간입력(선택) 함수
	static string Name();	// 이름입력 함수
	static int SeatNum();	// 좌석입력선택) 함수
};
#endif