#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void AdminMenuFunc() // ������ �޴� ��� �Լ�
{
	system("cls");
	int i1;
	int x = 31;
	int y = 3;

	gotoxy(x, y);

	printf("��");
	for (i1 = 0; i1 < 50; i1++) {
		printf("��");
	}
	printf("��");

	for (i1 = 0; i1 < 20; i1++)
	{
		y++;
		gotoxy(31, y);

		printf("��");

		if (i1 == 12)
		{
			gotoxy(48 + 1, i1 - 5);
			printf("���� ����� ���α׷�");
			gotoxy(48, i1 - 3);
			printf("�Ѹ޴��� �����ϼ����");
			gotoxy(51, i1 - 1);
			printf("[1] ���� ��ȸ");
			gotoxy(51, i1);
			printf("[2] ���� �߰�");
			gotoxy(51, i1 + 1);
			printf("[3] ���� ����");
			gotoxy(51, i1 + 2);
			printf("[4] ���� �߰�");
			gotoxy(51, i1 + 3);
			printf("[5] ���� ����");
			gotoxy(51, i1 + 4);
			printf("[6] �л� �߰�");
			gotoxy(51, i1 + 5);
			printf("[7] �л� ����");
			gotoxy(51, i1 + 6);
			printf("[8] �α� �ƿ�");
			gotoxy(51, i1 + 7);
			printf("[0] ��     ��");

		}
		x += 60;
		gotoxy(82, y);
		printf("��");



	}
	gotoxy(31, y);
	for (i1 = 0; i1 < 50; i1++)
		printf("��");

	gotoxy(31, y);
	printf("��");
	gotoxy(82, 23);
	printf("��");
}

void ProMenuFunc() // ���� �޴� ��� �Լ�
{
	system("cls");
	int i2;
	int x3 = 33;
	int y3 = 3;

	gotoxy(x3, y3);

	printf("��");
	for (i2 = 0; i2 < 50; i2++) {
		printf("��");
	}
	printf("��");

	for (i2 = 0; i2 < 20; i2++)
	{
		y3++;
		gotoxy(33, y3);
		printf("��");

		if (i2 == 12)
		{
			gotoxy(48 + 1, i2 - 3);
			printf("���� ����� ���α׷�");
			gotoxy(48, i2 - 1);
			printf("�Ѹ޴��� �����ϼ����");
			gotoxy(51, i2 + 1);
			printf("[1] �л���ȸ");
			gotoxy(51, i2 + 2);
			printf("[2] �л� ���� ��ü �Է�");
			gotoxy(51, i2 + 3);
			printf("[3] �л� ���� �κ� �Է�");
			gotoxy(51, i2 + 4);
			printf("[4] �л� ���� ����");
			gotoxy(51, i2 + 5);
			printf("[5] �л� ���� ��ȸ");
			gotoxy(51, i2 + 6);
			printf("[6] ��й�ȣ ����");
			gotoxy(51, i2 + 7);
			printf("[7] �α� �ƿ�");
			gotoxy(51, i2 + 8);
			printf("[0] ����");

		}
		x3 += 60;
		gotoxy(84, y3);

		printf("��");

	}

	gotoxy(35, y3);
	for (i2 = 0; i2 < 50; i2++)
		printf("��");

	gotoxy(33, y3);
	printf("��");
	gotoxy(84, 23);
	printf("��");
}

void StMenuFunc() //  �л� �޴� ��� �Լ�
{
	system("cls");
	int i3;
	int x4 = 38;
	int y4 = 5;

	gotoxy(x4, y4);

	printf("��");
	for (i3 = 0; i3 < 39; i3++) {
		printf("��");
	}
	printf("��");

	for (i3 = 1; i3 < 15; i3++)
	{
		y4++;
		gotoxy(38, y4);

		printf("��");

		if (i3 == 12)
		{
			gotoxy(48 + 1, i3 - 3);
			printf(" ���� ����� ���α׷�");
			gotoxy(48, i3 - 1);
			printf(" �Ѹ޴��� �����ϼ����");
			gotoxy(52, i3 + 1);
			printf("[1] ������ȸ");
			gotoxy(52, i3 + 2);
			printf("[2] ��й�ȣ ����");
			gotoxy(52, i3 + 3);
			printf("[3] �α� �ƿ�");
			gotoxy(52, i3 + 4);
			printf("[0] ��    ��");


		}
		x4 += 60;
		gotoxy(78, y4);
		printf("��");

	}

	gotoxy(38, y4);
	for (i3 = 0; i3 < 40; i3++)
		printf("��");

	gotoxy(38, y4);
	printf("��");
	gotoxy(78, 19);
	printf("��");
}

void gotoxy(int x, int y) // goto �Լ�
{
	COORD pos = { x,y };
	SetConsoleCursorPosition(GetStdHandle(STD_OUTPUT_HANDLE), pos);
}