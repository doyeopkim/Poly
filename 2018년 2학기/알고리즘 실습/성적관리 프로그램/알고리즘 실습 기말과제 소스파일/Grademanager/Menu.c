#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void AdminMenuFunc() // 관리자 메뉴 출력 함수
{
	system("cls");
	int i1;
	int x = 31;
	int y = 3;

	gotoxy(x, y);

	printf("┌");
	for (i1 = 0; i1 < 50; i1++) {
		printf("─");
	}
	printf("┐");

	for (i1 = 0; i1 < 20; i1++)
	{
		y++;
		gotoxy(31, y);

		printf("│");

		if (i1 == 12)
		{
			gotoxy(48 + 1, i1 - 5);
			printf("성적 입출력 프로그램");
			gotoxy(48, i1 - 3);
			printf("☞메뉴를 선택하세요☜");
			gotoxy(51, i1 - 1);
			printf("[1] 교수 조회");
			gotoxy(51, i1);
			printf("[2] 교수 추가");
			gotoxy(51, i1 + 1);
			printf("[3] 교수 삭제");
			gotoxy(51, i1 + 2);
			printf("[4] 과목 추가");
			gotoxy(51, i1 + 3);
			printf("[5] 과목 삭제");
			gotoxy(51, i1 + 4);
			printf("[6] 학생 추가");
			gotoxy(51, i1 + 5);
			printf("[7] 학생 삭제");
			gotoxy(51, i1 + 6);
			printf("[8] 로그 아웃");
			gotoxy(51, i1 + 7);
			printf("[0] 종     료");

		}
		x += 60;
		gotoxy(82, y);
		printf("│");



	}
	gotoxy(31, y);
	for (i1 = 0; i1 < 50; i1++)
		printf("─");

	gotoxy(31, y);
	printf("└");
	gotoxy(82, 23);
	printf("┘");
}

void ProMenuFunc() // 교수 메뉴 출력 함수
{
	system("cls");
	int i2;
	int x3 = 33;
	int y3 = 3;

	gotoxy(x3, y3);

	printf("┌");
	for (i2 = 0; i2 < 50; i2++) {
		printf("─");
	}
	printf("┐");

	for (i2 = 0; i2 < 20; i2++)
	{
		y3++;
		gotoxy(33, y3);
		printf("│");

		if (i2 == 12)
		{
			gotoxy(48 + 1, i2 - 3);
			printf("성적 입출력 프로그램");
			gotoxy(48, i2 - 1);
			printf("☞메뉴를 선택하세요☜");
			gotoxy(51, i2 + 1);
			printf("[1] 학생조회");
			gotoxy(51, i2 + 2);
			printf("[2] 학생 성적 전체 입력");
			gotoxy(51, i2 + 3);
			printf("[3] 학생 성적 부분 입력");
			gotoxy(51, i2 + 4);
			printf("[4] 학생 성적 삭제");
			gotoxy(51, i2 + 5);
			printf("[5] 학생 성적 조회");
			gotoxy(51, i2 + 6);
			printf("[6] 비밀번호 변경");
			gotoxy(51, i2 + 7);
			printf("[7] 로그 아웃");
			gotoxy(51, i2 + 8);
			printf("[0] 종료");

		}
		x3 += 60;
		gotoxy(84, y3);

		printf("│");

	}

	gotoxy(35, y3);
	for (i2 = 0; i2 < 50; i2++)
		printf("─");

	gotoxy(33, y3);
	printf("└");
	gotoxy(84, 23);
	printf("┘");
}

void StMenuFunc() //  학생 메뉴 출력 함수
{
	system("cls");
	int i3;
	int x4 = 38;
	int y4 = 5;

	gotoxy(x4, y4);

	printf("┌");
	for (i3 = 0; i3 < 39; i3++) {
		printf("─");
	}
	printf("┐");

	for (i3 = 1; i3 < 15; i3++)
	{
		y4++;
		gotoxy(38, y4);

		printf("│");

		if (i3 == 12)
		{
			gotoxy(48 + 1, i3 - 3);
			printf(" 성적 입출력 프로그램");
			gotoxy(48, i3 - 1);
			printf(" ☞메뉴를 선택하세요☜");
			gotoxy(52, i3 + 1);
			printf("[1] 성적조회");
			gotoxy(52, i3 + 2);
			printf("[2] 비밀번호 변경");
			gotoxy(52, i3 + 3);
			printf("[3] 로그 아웃");
			gotoxy(52, i3 + 4);
			printf("[0] 종    료");


		}
		x4 += 60;
		gotoxy(78, y4);
		printf("│");

	}

	gotoxy(38, y4);
	for (i3 = 0; i3 < 40; i3++)
		printf("─");

	gotoxy(38, y4);
	printf("└");
	gotoxy(78, 19);
	printf("┘");
}

void gotoxy(int x, int y) // goto 함수
{
	COORD pos = { x,y };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}