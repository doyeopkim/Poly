#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"
#define STSIZE 100
#define SUBSIZE 100
#define PROSIZE 100
#pragma warning (disable : 4996)

int main()
{
	struct Grade st[STSIZE]; // 학생 100명
	struct Pro pro[PROSIZE]; // 교수 100명
	struct Sub sub[SUBSIZE]; // 과목수 100개
	int i = 0, j = 0;
	//초기화 부분

	for (i = 0; i < 100; i++)
	{
		strcpy(sub[i].subjectname, "0"); // 과목명 "0"으로 초기화
		st[i].sum = NULL; // 점수 합 NULL으로 초기화
		st[i].avg = 0; // 점수 평균 0으로 초기화
		st[i].callnum = 0; // 인덱스 값을 기억할 변수 0으로 초기화
		pro[i].callnum = 0; // 인덱스 값을 기억할 변수 0으로 초기화
		strcpy(st[i].id, "0"); // 학생 ID "0"으로 초기화
		strcpy(st[i].password, "1234"); // 학생 비밀번호 "1234"로 초기화
		strcpy(pro[i].id, "0"); // 교수 ID "a"로 초기화
		strcpy(pro[i].password, "1234"); // 교수 비밀번호 "1234"로 초기화

		for (j = 0; j < 100; j++)
		{
			st[i].subject[j] = -1; // 학생 10명의 모든 성적을 -1로 초기화
		}
	}

	FILE *stopen = fopen("c:\\1\\st.txt", "rt"); // 학생 ID 및 패스워드
	FILE *proopen = fopen("c:\\1\\pro.txt", "rt"); // 교수 ID 및 패스워드
	FILE *subnopen = fopen("c:\\1\\subjectname.txt", "rt"); // 과목명
	FILE *subopen = fopen("c:\\1\\subject.txt", "rt"); // 성적

	for (i = 0; i < 100; i++)
	{
		if (subnopen != NULL) // 과목 파일 입력
		{
			fscanf(subnopen, "%s", &sub[i].subjectname);
		}
		if (stopen != NULL) // 학생 ID, PASSWORD 파일 입력
		{
			fscanf(stopen, "%s %s", &st[i].id, &st[i].password);
		}
		if (proopen != NULL) // 교수 ID, PASSWORD 파일 입력
		{
			fscanf(proopen, "%s %s", &pro[i].id, &pro[i].password);
		}
	}
	for (i = 0; i < 100; i++)
	{
		for (j = 0; j < 100; j++)
		{
			if (!strcmp(sub[j].subjectname, "0"))
			{
				break;
			}

			else // 성적 파일 입력
			{
				if (subopen != NULL)
				{
					fscanf(subopen, "%d", &st[i].subject[j]);
				}
			}
		}
	}

	CalculateFunc(st, sub);
	LoginFunc(st, sub, pro);

	fclose(stopen);
	fclose(proopen);
	fclose(subnopen);
	fclose(subopen);
}