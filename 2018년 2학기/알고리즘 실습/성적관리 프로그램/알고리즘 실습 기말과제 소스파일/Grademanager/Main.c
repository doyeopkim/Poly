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
	struct Grade st[STSIZE]; // �л� 100��
	struct Pro pro[PROSIZE]; // ���� 100��
	struct Sub sub[SUBSIZE]; // ����� 100��
	int i = 0, j = 0;
	//�ʱ�ȭ �κ�

	for (i = 0; i < 100; i++)
	{
		strcpy(sub[i].subjectname, "0"); // ����� "0"���� �ʱ�ȭ
		st[i].sum = NULL; // ���� �� NULL���� �ʱ�ȭ
		st[i].avg = 0; // ���� ��� 0���� �ʱ�ȭ
		st[i].callnum = 0; // �ε��� ���� ����� ���� 0���� �ʱ�ȭ
		pro[i].callnum = 0; // �ε��� ���� ����� ���� 0���� �ʱ�ȭ
		strcpy(st[i].id, "0"); // �л� ID "0"���� �ʱ�ȭ
		strcpy(st[i].password, "1234"); // �л� ��й�ȣ "1234"�� �ʱ�ȭ
		strcpy(pro[i].id, "0"); // ���� ID "a"�� �ʱ�ȭ
		strcpy(pro[i].password, "1234"); // ���� ��й�ȣ "1234"�� �ʱ�ȭ

		for (j = 0; j < 100; j++)
		{
			st[i].subject[j] = -1; // �л� 10���� ��� ������ -1�� �ʱ�ȭ
		}
	}

	FILE *stopen = fopen("c:\\1\\st.txt", "rt"); // �л� ID �� �н�����
	FILE *proopen = fopen("c:\\1\\pro.txt", "rt"); // ���� ID �� �н�����
	FILE *subnopen = fopen("c:\\1\\subjectname.txt", "rt"); // �����
	FILE *subopen = fopen("c:\\1\\subject.txt", "rt"); // ����

	for (i = 0; i < 100; i++)
	{
		if (subnopen != NULL) // ���� ���� �Է�
		{
			fscanf(subnopen, "%s", &sub[i].subjectname);
		}
		if (stopen != NULL) // �л� ID, PASSWORD ���� �Է�
		{
			fscanf(stopen, "%s %s", &st[i].id, &st[i].password);
		}
		if (proopen != NULL) // ���� ID, PASSWORD ���� �Է�
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

			else // ���� ���� �Է�
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