#define _CRT_SECURE_NO_WARNINGS
#include <stdio.h>
#include <string.h>
#include <conio.h>
#include <Windows.h>
#include "DefineFunc.h"

void AddProFunc(struct Grade* st, struct Pro* pro) // ���� �߰� �Լ�
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count���̹� �����ϴ� ���� ��
	char addpro[100] = "0"; // �߰��� ������
	int plusnum; // �߰��� ���� ��
	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ���� ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	system("cls");
	gotoxy(x, y);
	printf("���� �ִ� �������� �� : %d", count);
	gotoxy(x, y + 1);
	printf("����� ���� ���� �Է��� �ּ��� : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d ���� �߰��Ͽ����ϴ�. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("���� ���� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�. "); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("����� ������ ���� �ٽ� �Է��ϼ��� : ");
		scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");

		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���


	for (j = 0; j < plusnum; j++) // �߰��� ���� �� ��ŭ �ݺ�
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(pro[i].id, "0")) // �������� "0" �� ��
			{
				forcount = 0;
				gotoxy(x + 4, y + 3);
				printf("����� �������� �Է��� �ּ��� : ");
				scanf("%s", addpro);
				gotoxy(x + 4, y + 4);
				printf("��ϵ� ������ : %s", addpro);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(pro[k].id, addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("�̹� �����ϴ� ID �Դϴ�.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp(st[k].id, addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("�̹� �����ϴ� ID �Դϴ�.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp("admin", addpro))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("������ ID�����δ� ������ �� �����ϴ�.");
						forcount = 1;
						Sleep(700);
						system("cls");
						break;
					}
					if (k == 99 && forcount == 0)
					{
						strcpy(pro[i].id, addpro);
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("%s ������ ��ϵǾ����ϴ�.", addpro);
						Sleep(700);
						system("cls");
						break;
					}
				}
				break;
			}
		}
	}

	count = 0;
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ���� ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 3, y + 2);
	printf("�� �������� �� : %d", count);
	gotoxy(x + 3, y + 3);
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", pro[i].id);
		}
	}
	gotoxy(x + 3, y + 4);
	system("pause");
	system("cls");
}

void DelProFunc(struct Pro* pro) // ���� ���� �Լ�
{
	system("cls");
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, procount = 0; // count���̹� �����ϴ� ���� �� forcount�� for������ �������� �ʴ� ������ ��¿�
	int delnum; // ������ ���� ��
	char delid[1000]; // ������ ���� ID��

	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ���� ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	procount = count;
	gotoxy(x, y);
	printf("���� �ִ� �������� �� : %d", count);
	gotoxy(x, y + 1);
	printf("�����ִ� ������ : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ������ ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", &pro[i].id);
		}
	}

	gotoxy(x, y + 2);
	printf("������ ���� ���� �Է��� �ּ��� : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y);
		printf(" ���������� �Է� �Ǿ����ϴ�!");
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("������ ���� ���� 0���� �۰ų� %d���� �Ѿ �� �����ϴ�.", procount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� �������� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("������ ���� ���� �ٽ� �Է� �ϼ��� : ");
		scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf(" ���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���

	if (count == 0) // ��� ���� ���� ȣ�� ��
	{
		for (i = 0; i < 100; i++)
		{
			strcpy(pro[i].id, "0"); // �������� "0"���� �ʱ�ȭ
		}
		system("cls");
		gotoxy(x, y);
		printf("��� �������� �����Ǿ����ϴ�.");
		Sleep(700);
		system("cls");
	} // count�� 0�̸� ��� ������ �������Ƿ� ��米�� ���� ���

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
			gotoxy(x + 4, y + 3);
			printf("������ �������� �Է��� �ּ��� : ");
			scanf("%s", &delid);
			gotoxy(x + 4, y + 4);
			printf("�Էµ� ������ : %s", delid);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(pro[i].id, delid)) // �Է¹��� ������� �����ϴ� �������� ��ġ�� ��
				{
					if (!strcmp(delid, "0"))
					{
						break;
					}
					strcpy(pro[i].id, "0"); // �������� "0"���� �ʱ�ȭ
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s ������ �����Ǿ����ϴ�!", delid);
					Sleep(700);
					system("cls");
					forcount = 1; // ��ġ�ϴ� �������� �ִٸ� 1�� �ʱ�ȭ
					break;
				}
			}
			if (forcount == 0) //��ġ�ϴ� �������� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("�������� �ʴ� �������Դϴ�");
				Sleep(700);
				system("cls");

			}
		}
	}

	count = 0;
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ���� ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x + 3, y + 2);
	printf("�� �������� �� : %d", count);
	gotoxy(x + 3, y + 3);
	printf("�����ִ� ���� : ");

	for (i = 0; i < 100; i++) // ���� �����ϴ� ������ ���
	{
		if (!strcmp(pro[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", pro[i].id);
		}
	}
	gotoxy(x + 3, y + 4);
	system("pause");
	system("cls");
}

void AddStFunc(struct Grade* st, struct Sub* sub, struct Pro* pro) // �л� �߰� �Լ�
{
	int x = 43;
	int y = 7;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count���̹� �����ϴ� �л� ��
	char addst[100] = "0"; // �߰��� �л���
	int plusnum; // �߰��� �л� ��
	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x, y);
	printf("���� �ִ� �л��� �� : %d", count);
	gotoxy(x, y + 1);
	printf("�߰��� �л� ���� �Է��� �ּ��� : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d ���� �߰��Ͽ����ϴ�. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;

		system("cls");
		gotoxy(x - 10, y + 3);
		printf("�л� ���� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�."); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("����� �л� ���� �ٽ� �Է��ϼ��� : ");
		scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���



	for (j = 0; j < plusnum; j++) // �߰��� �л� �� ��ŭ �ݺ�
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(st[i].id, "0")) // �л����� "0" �� ��
			{
				forcount = 0;
				gotoxy(x + 4, y + 3);
				printf("�߰��� �л����� �Է��� �ּ��� : ");
				scanf("%s", addst);
				gotoxy(x + 4, y + 4);
				printf("�Էµ� �л��� : %s", addst);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(st[k].id, addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("�̹� �����ϴ� ID�� �Դϴ�.");
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp(pro[k].id, addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("�̹� �����ϴ� ID�� �Դϴ�.");
						Sleep(700);
						system("cls");
						break;
					}
					else if (!strcmp("admin", addst))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("������ ID�����δ� ������ �� �����ϴ�.");
						Sleep(700);
						system("cls");
						break;
					}
					if (k == 99 && forcount == 0)
					{
						strcpy(st[i].id, addst);
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("%s �л��� �߰��Ǿ����ϴ�!", addst);
						Sleep(700);
						system("cls");
						break;
					}
				}
				break;
			}
		}
	}

	count = 0; //0���� �ٽ� �ʱ�ȭ
	for (i = 0; i < 100; i++) // �̹� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 4, y + 2);
	printf("�� �л��� �� : %d", count);
	gotoxy(x + 4, y + 3);
	printf("�����ִ� �л� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}
	gotoxy(x + 4, y + 4);
	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}

void DelStFunc(struct Grade* st, struct Sub* sub) // �л� ���� �Լ�
{
	int x = 43;
	int y = 7;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, stcount = 0; // count���̹� �����ϴ� �л� �� forcount�� for������ �������� �ʴ� �л��� ��¿�
	int delnum; // ������ �л� ��
	char delid[1000]; // ������ �л� ID��
	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	stcount = count;
	gotoxy(x, y);
	printf("���� �ִ� �л��� �� : %d", count);
	gotoxy(x, y + 1);
	printf("�����ִ� �л� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x, y + 2);
	printf("������ �л� ���� �Է��� �ּ��� : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y);
		printf("���������� �Է� �Ǿ����ϴ�!");
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("������ �л� ���� 0���� �۰ų� %d���� �Ѿ �� �����ϴ�. ", stcount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� �л� �� ���� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("������ �л��� ���� �ٽ� �Է��ϼ��� : ");
		scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf(" ���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���

	if (count == 0) // ��� �л� ���� ȣ�� ��
	{
		for (i = 0; i < 100; i++)
		{
			strcpy(st[i].id, "0"); // �л����� "0"���� �ʱ�ȭ

			for (j = 0; j < 100; j++)
			{
				st[i].subject[j] = -1; // ������ �л��� ��� ������ ������ -1�� �ʱ�ȭ
			}
		}
		system("cls");
		gotoxy(x, y);
		printf("��� �л��� �����Ǿ����ϴ�.");
		Sleep(700);
		system("cls");
	} // count�� 0�̸� ��� �л��� �������Ƿ� ����л� ���� ���

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
			gotoxy(x + 4, y + 3);
			printf("������ �л����� �Է��� �ּ��� : ");
			scanf("%s", &delid);
			gotoxy(x + 4, y + 4);
			printf("�Էµ� �л��� : %s", delid);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, delid)) // �Է¹��� �л���� �����ϴ� �л����� ��ġ�� ��
				{
					if (!strcmp(delid, "0"))
					{
						break;
					}
					for (k = 0; k < 100; k++)
					{
						st[i].subject[k] = -1; // ������ �л��� ��� ������ ������ -1�� �ʱ�ȭ
					}
					strcpy(st[i].id, "0"); // �л����� "0"���� �ʱ�ȭ
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s �л��� �����Ǿ����ϴ�!", delid);
					Sleep(700);
					system("cls");
					forcount = 1; // ��ġ�ϴ� �л����� �ִٸ� 1�� �ʱ�ȭ
					break;
				}
			}
			if (forcount == 0) //��ġ�ϴ� �л����� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("�������� �ʴ� �л����Դϴ�");
				Sleep(700);
				system("cls");

			}
		}
	}

	count = 0; //0���� �ٽ� �ʱ�ȭ
	for (i = 0; i < 100; i++) // �̹� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 3, y + 3);
	printf("�� �л��� �� : %d", count);
	gotoxy(x + 3, y + 4);
	printf("�����ִ� �л� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� �л��� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}

void AddSubFunc(struct Grade* st, struct Sub* sub) // ���� �߰� �Լ� �߰�
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0; // count���̹� �����ϴ� ���� �� forcount�� for������ �������� �ʴ� ����� ��¿�
	char addsub[100] = "0"; // �߰��� �����
	int plusnum; // �߰��� ���� ��
	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	system("cls");
	gotoxy(x, y);
	printf("���� �ִ� ������ �� : %d", count);
	gotoxy(x, y + 1);
	printf("�߰� �� ���� ���� �Է��� �ּ��� : ");
	scanf("%d", &plusnum);

	count += plusnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		system("cls");
		gotoxy(x + 4, y + 4);
		printf("%d ���� �߰��Ͽ����ϴ�. ", plusnum);
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count -= plusnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("���� ���� 0���� �۰ų� 100���� �Ѿ �� �����ϴ�. "); //�Է� ���� ���� 0���� �۰ų� 100���� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("�߰��� ������ ���� �ٽ� �Է��ϼ��� : "); scanf("%d", &plusnum);
		count += plusnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);;
			system("cls");
		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���


	for (j = 0; j < plusnum; j++) // �߰��� ���� �� ��ŭ �ݺ�
	{
		for (i = 0; i < 100; i++)
		{
			if (!strcmp(sub[i].subjectname, "0")) // ������� "0" �� ��
			{
				forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
				gotoxy(x + 4, y + 3);
				printf("�߰��� ������� �Է��� �ּ��� : ");
				scanf("%s", addsub);
				gotoxy(x + 4, y + 4);
				printf("�Էµ� ����� : %s", addsub);

				for (k = 0; k < 100; k++)
				{
					if (!strcmp(sub[k].subjectname, addsub))
					{
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("�̹� �����ϴ� ����� �Դϴ�.");
						Sleep(700);
						system("cls");
						forcount = 1;
						break;
					}
				}
				if (forcount == 0)
				{
					strcpy(sub[i].subjectname, addsub);
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s ������ �߰��Ǿ����ϴ�!", addsub);
					Sleep(700);
					system("cls");
					break;
				}
				break;
			}
		}
	}

	count = 0; //0���� �ٽ� �ʱ�ȭ
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}

	gotoxy(x + 3, y + 2);
	printf("�� ������ �� : %d", count);
	gotoxy(x + 3, y + 3);
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}
	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}

void DelSubFunc(struct Grade* st, struct Sub* sub) // ���� ���� �Լ�
{
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, count = 0, forcount = 0, subcount = 0; // count���̹� �����ϴ� ���� �� forcount�� for������ �������� �ʴ� ����� ��¿�
	int delnum; // ������ ���� ��
	char delsub[11]; // ������ �����
	system("cls");
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	subcount = count;
	system("cls");
	gotoxy(x, y);
	printf("���� �ִ� ������ �� : %d", count);
	gotoxy(x, y + 1);
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}

	gotoxy(x, y + 2);
	printf("������ ���� ���� �Է��� �ּ��� : ");
	scanf("%d", &delnum);

	count -= delnum;

	while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
	if (0 <= count && count <= 100)
	{
		gotoxy(x, y + 1);
		printf("���������� �Է� �Ǿ����ϴ�!");
		Sleep(700);
		system("cls");
	}

	while (0 > count || count > 100)
	{
		count += delnum;
		system("cls");
		gotoxy(x - 10, y + 3);
		printf("������ ���� ���� 0���� �۰ų� %d���� �Ѿ �� �����ϴ�. ", subcount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� ���� �� ���� Ŭ��
		Sleep(700);
		system("cls");
		gotoxy(x - 5, y + 3);
		printf("������ ������ ���� �ٽ� �Է��ϼ��� : "); scanf("%d", &delnum);
		count -= delnum;
		while (getchar() != '\n');

		if (0 <= count && count <= 100) {
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}
	} // 0�̻� 100������ ���� �ޱ����� �ݺ���

	if (count == 0) // ��� ���� ���� ȣ�� ��
	{
		for (i = 0; i < 100; i++)
		{
			for (k = 0; k < 100; k++)
			{
				st[i].subject[k] = -1; // ��� �л��� ���� ������ �ٽ� -1�� �ʱ�ȭ
			}
			strcpy(sub[i].subjectname, "0"); // ������� "0"���� �ʱ�ȭ
		}
		system("cls");
		gotoxy(x, y);
		printf("��� ������ �����Ǿ����ϴ�.");
		Sleep(700);
		system("cls");
	} // count�� 0�̸� ��� ������ �������Ƿ� ������ ���� ���

	else
	{
		for (j = 0; j < delnum; j++)
		{
			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ
			gotoxy(x + 4, y + 3);
			printf("������ ������ �Է��� �ּ��� : ");
			scanf("%s", &delsub);
			gotoxy(x + 4, y + 4);
			printf("�Էµ� ����� : %s", delsub);

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(sub[i].subjectname, delsub)) // �Է¹��� ������ �����ϴ� ������� ��ġ�� ��
				{
					if (!strcmp(delsub, "0"))
					{
						break;
					}
					for (k = 0; k < 100; k++)
					{
						st[k].subject[i] = -1; // ��� �л��� ������ ������ ������ -1�� �ʱ�ȭ
					}
					strcpy(sub[i].subjectname, "0"); // ������� "0"���� �ʱ�ȭ
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("%s ������ �����Ǿ����ϴ�!", delsub);
					Sleep(700);
					system("cls");
					forcount = 1; // ��ġ�ϴ� ������� �ִٸ� 1�� �ʱ�ȭ
					break;
				}
			}
			if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("�������� �ʴ� ������Դϴ�");
				Sleep(700);
				system("cls");
			}
		}
	}

	count = 0; //0���� �ٽ� �ʱ�ȭ
	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			count++;
		}
	}
	gotoxy(x + 4, y + 2);
	printf("�� ������ �� : %d", count);
	gotoxy(x + 4, y + 3);
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}
	gotoxy(x + 3, y + 4);
	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}

void DelGradeFunc(struct Grade* st, struct Sub* sub) // ���� ���� �Լ�
{
	system("cls");
	int x = 42;
	int y = 9;
	int i = 0, j = 0, k = 0, subcount = 0, stucount = 0, forcount = 0, nstcount = 0, nsubcount = 0; // subcount,stucount���̹� �����ϴ� ����,�л� �� forcount�� for������ �������� �ʴ� ����� ��¿�
	int delnum, delnum1; // ������ ���� ��
	char yn, yn1; // y/n
	char delsub[1000]; // ������ �����
	char delstu[1000]; // ������ ������ �л���
	int delst[100] = { 0 }; // ������ �л� �ӽ� �����

	for (i = 0; i < 100; i++) // �Լ� ȣ���� ������ �ʱ�ȭ
	{
		delst[i] = 0;
	}

	for (i = 0; i < 100; i++) // �̹� �����ϴ� ����, �л� �� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			subcount++;
		}
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			stucount++;
		}
	}
	nstcount = stucount;
	nsubcount = subcount;
	gotoxy(x, y);
	printf("�����ִ� �л� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(st[i].id, "0"))
		{
		}
		else
		{
			printf("%s ", st[i].id);
		}
	}

	gotoxy(x, y + 1);
	printf("�����ִ� ���� : ");
	for (i = 0; i < 100; i++) // ���� �����ϴ� ����� ���
	{
		if (!strcmp(sub[i].subjectname, "0"))
		{
		}
		else
		{
			printf("%s ", sub[i].subjectname);
		}
	}


	// ��� �л� ���� ���� ���� -> ��� �л� �ƴҽ� ��� ���� �������� ����
	// -> ��� ���� ���� �ƴҽ� ����� �Է¹ް� ����

	getchar(); // ���� �����
	gotoxy(x, y + 2);
	printf("��� �л��� �����Ͻðڽ��ϱ�? Y/N : ");
	scanf("%c", &yn);

	if (yn == 'Y' || yn == 'y')
	{
		system("cls");
		gotoxy(x, y);
		printf("�����ִ� ���� �� : %d", subcount);
		gotoxy(x, y + 1);
		printf("������ ���� ���� �Է��� �ּ��� : ");
		scanf("%d", &delnum);


		subcount -= delnum;

		while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
		if (0 <= subcount && subcount <= 100)
		{
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}

		while (0 > subcount || subcount > 100)
		{
			subcount += delnum;
			system("cls");
			gotoxy(x - 10, y + 3);
			printf("������ ���� ���� 0���� �۰ų� %d���� �Ѿ �� �����ϴ�. ", nsubcount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� ���� �� ���� Ŭ��
			Sleep(700);
			system("cls");
			gotoxy(x - 5, y + 3);
			printf("������ ������ ���� �ٽ� �Է��ϼ��� : "); scanf("%d", &delnum);
			subcount -= delnum;
			while (getchar() != '\n');

			if (0 <= subcount && subcount <= 100) {
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
				Sleep(700);
				system("cls");
			}
		} // 0�̻� 100������ ���� �ޱ����� �ݺ���

		if (subcount == 0) // ��� ���� ���� ȣ�� ��
		{
			for (i = 0; i < 100; i++)
			{
				for (k = 0; k < 100; k++)
				{
					st[i].subject[k] = -1; // ��� �л��� ���� ������ �ٽ� -1�� �ʱ�ȭ
				}
			}
			system("cls");
			gotoxy(x, y + 1);
			printf("��� �л��� ��� ���� ������ �����Ǿ����ϴ�.");
			Sleep(700);
		} // subcount�� 0�̸� ��� ������ �������Ƿ� ������ ���� ���

		else
		{
			for (j = 0; j < delnum; j++)
			{
				system("cls");
				gotoxy(x, y);
				printf("������ ������ �Է��� �ּ��� : ");
				scanf("%s", &delsub);
				gotoxy(x, y + 1);
				printf("�Էµ� ����� : %s\n", delsub);

				forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, delsub)) // �Է¹��� ������ �����ϴ� ������� ��ġ�� ��
					{
						for (k = 0; k < 100; k++)
						{
							st[k].subject[i] = -1; // ��� �л��� ������ ������ ������ -1�� �ʱ�ȭ
						}
						system("cls");
						gotoxy(x + 4, y + 3);
						printf("��� �л��� �ش� ���� ������ �����Ǿ����ϴ�!");
						Sleep(700);
						system("cls");
						forcount = 1; // ��ġ�ϴ� ������� �ִٸ� 1�� �ʱ�ȭ
						break;
					}
				}
				if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
				{
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("�������� �ʴ� ������Դϴ�");
					Sleep(700);
					system("cls");
				}
			}
		}
	}

	else if (yn == 'N' || yn == 'n')
	{
		system("cls");
		gotoxy(x, y);
		printf("�����ִ� �л� �� : %d", stucount);
		gotoxy(x, y + 1);
		printf("������ �л� ���� �Է��� �ּ��� : ");
		scanf("%d", &delnum);

		stucount -= delnum;

		while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
		if (0 <= stucount && stucount <= 100)
		{
			system("cls");
			gotoxy(x + 5, y + 3);
			printf("���������� �Է� �Ǿ����ϴ�!");
			Sleep(700);
			system("cls");
		}

		while (0 > stucount || stucount > 100)
		{
			stucount += delnum;
			system("cls");
			gotoxy(x - 10, y + 3);
			printf("������ �л� ���� 0���� �۰ų� %d���� �Ѿ �� �����ϴ�. ", nstcount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� �л� �� ���� Ŭ��
			Sleep(700);
			system("cls");
			gotoxy(x - 5, y + 3);
			printf("������ �л��� ���� �ٽ� �Է��ϼ��� : "); scanf("%d", &delnum);
			stucount -= delnum;
			while (getchar() != '\n');

			if (0 <= stucount && stucount <= 100) {
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
				Sleep(700);
				system("cls");
			}
		} // 0�̻� 100������ ���� �ޱ����� �ݺ���

		for (j = 0; j < delnum; j++)
		{
			system("cls");
			gotoxy(x, y);
			printf("������ �л����� �Է��� �ּ��� : ");
			scanf("%s", &delstu);
			gotoxy(x, y + 1);
			printf("�Էµ� �л��� : %s", delstu);

			forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ

			for (i = 0; i < 100; i++)
			{
				if (!strcmp(st[i].id, delstu)) // �Է¹��� �л���� �����ϴ� �л����� ��ġ�� ��
				{
					if (!strcmp(delstu, "0"))
					{
						break;
					}
					delst[i] = 1; // i���� �л� �ӽ� ����
					forcount = 1;
					break;
				}
			}
			if (forcount == 0) //��ġ�ϴ� �л����� ���ٸ� �������� ���
			{
				system("cls");
				gotoxy(x + 4, y + 3);
				printf("�������� �ʴ� �л����Դϴ�");
				Sleep(700);
				system("cls");
			}
		}

		getchar(); // ���� �����
		system("cls");
		gotoxy(x + 4, y + 3);
		printf("��� ������ ����ðڽ��ϱ�? Y/N : ");
		scanf("%c", &yn1);

		if (yn1 == 'Y' || yn1 == 'y')
		{
			for (i = 0; i < 100; i++)
			{
				if (delst[i] == 1)
				{
					for (j = 0; j < 100; j++)
					{
						st[i].subject[j] = -1; // ���������� -1�� �ʱ�ȭ
					}
				}
			}
			system("cls");
			gotoxy(x + 4, y + 3);
			printf("�ش� �л��� ��� ���� ������ �����Ǿ����ϴ�!");
		}

		else if (yn1 == 'N' || yn1 == 'n')
		{
			system("cls");
			gotoxy(x, y);
			printf("�����ִ� ���� �� : %d", subcount);
			gotoxy(x, y + 1);
			printf("������ ���� ���� �Է��� �ּ��� : ");
			scanf("%d", &delnum1);

			subcount -= delnum1;

			while (getchar() != '\n'); // �Է¹��� ������ ���� ��ġ���� ������ �ݺ�
			if (0 <= subcount && subcount <= 100)
			{
				system("cls");
				gotoxy(x + 5, y + 3);
				printf("���������� �Է� �Ǿ����ϴ�!");
				Sleep(1000);
				system("cls");
			}

			while (0 > subcount || subcount > 100)
			{
				subcount += delnum1;
				system("cls");
				gotoxy(x - 10, y + 3);
				printf("������ ���� �� �� 0���� �۰ų� %d�� �Ѿ �� �����ϴ�. ", nsubcount); //�Է� ���� ���� 0���� �۰ų� �����ϴ� ���� �� ���� Ŭ��
				Sleep(700);
				system("cls");
				gotoxy(x - 5, y + 3);
				printf("������ ���� ���� �ٽ� �Է��ϼ��� : ");
				scanf("%d", &delnum1);
				subcount -= delnum1;
				while (getchar() != '\n');

				if (0 <= subcount && subcount <= 100) {
					system("cls");
					gotoxy(x + 5, y + 3);
					printf("���������� �Է� �Ǿ����ϴ�!");
					Sleep(700);
					system("cls");
				}
			} // 0�̻� 100������ ���� �ޱ����� �ݺ���

			for (j = 0; j < delnum1; j++)
			{
				system("cls");
				gotoxy(x, y);
				printf("������ ������ �Է��� �ּ��� : ");
				scanf("%s", &delsub);
				gotoxy(x, y + 1);
				printf("�Էµ� ����� : %s", delsub);

				forcount = 0; // for���� �����Ҷ����� 0���� �ʱ�ȭ

				for (i = 0; i < 100; i++)
				{
					if (!strcmp(sub[i].subjectname, delsub)) // �Է¹��� ������ �����ϴ� ������� ��ġ�� ��
					{
						if (!strcmp(delsub, "0"))
						{
							break;
						}
						for (k = 0; k < 100; k++)
						{
							if (delst[k] == 1)
							{
								st[k].subject[i] = -1; // ���������� -1�� �ʱ�ȭ
								gotoxy(x, y);
								printf("�ش� �л��� �ش� ���� ������ �����Ǿ����ϴ�!");
								forcount = 1; // ��ġ�ϴ� ������� �ִٸ� 1�� �ʱ�ȭ
								break;
							}
						}
					}
				}
				if (forcount == 0) //��ġ�ϴ� ������� ���ٸ� �������� ���
				{
					system("cls");
					gotoxy(x + 4, y + 3);
					printf("�������� �ʴ� ������Դϴ�");
					Sleep(700);
					system("cls");
				}
			}
		}

		else
		{
			system("cls");
			gotoxy(x + 4, y + 3);
			printf("�߸��� �Է��Դϴ�.");
			Sleep(700);
			system("cls");
		}
	}

	else
	{
		system("cls");
		gotoxy(x + 4, y + 3);
		printf("�߸��� �Է��Դϴ�.");
		Sleep(700);
		system("cls");
	}

	CalculateFunc(st, sub); // ������ �����Ǿ��� �� �־��⿡ �ٽ� ��� �Լ� ȣ��
	system("pause");
	system("cls");
}