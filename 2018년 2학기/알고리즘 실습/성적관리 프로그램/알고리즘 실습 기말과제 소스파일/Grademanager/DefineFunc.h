#ifndef __DefineFunc_H__
#define __DefineFunc_H__

void AddProFunc(struct Grade* st, struct Pro* pro); // ���� �� �߰� �Լ�
void DelProFunc(struct Pro* pro); // ���� �� ���� �Լ�
void AddStFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // �л� �� �߰� �Լ�
void DelStFunc(struct Grade* st, struct Sub* sub); // �л� �� ���� �Լ�
void AddSubFunc(struct Grade* st, struct Sub* sub); // ���� �߰� �Լ�
void DelSubFunc(struct Grade* st, struct Sub* sub); // ���� ���� �Լ�

// �̻� AddDel.c

void ProOutputFunc(struct Grade* st, struct Sub* sub); // ������ȸ ������ �Լ�
void StOutputFunc(struct Grade* st, struct Sub* sub); // ������ȸ �л��� �Լ�
void SearchProFunc(struct Pro* pro); // ���� ��ȸ �Լ�
void SearchStFunc(struct Grade* st); // �л� ��ȸ �Լ�
void AllInputFunc(struct Grade* st, struct Sub* sub); // ��ü ���� �Է� �Լ�
void ChoiceInputFunc(struct Grade* st, struct Sub* sub); // ���� ���� �Է� �Լ�
void DelGradeFunc(struct Grade* st, struct Sub* sub); // ���� ���� �Լ�

// �̻� InputOutput.c

void AdminMenuFunc(); // ������ �޴� ��� �Լ�
void ProMenuFunc(); // ���� �޴� ��� �Լ�
void StMenuFunc(); // �л� �޴� ��� �Լ�
void gotoxy(int x, int y); // gotoxy �Լ�

// �̻� Menu.c

void FileSaveFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // ���� ���� �Լ�
void LoginFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // �α��� �Լ�
void LogoutFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); //�α׾ƿ� �Լ�
void ChangePasswordFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // ��й�ȣ ���� �Լ�
void CalculateFunc(struct Grade* st, struct Sub* sub); // ����, ������ �����ϴ� �Լ�

// �̻� System.c

struct Grade
{
	char id[11]; // �л� id ũ��� 11
	char password[11]; // �л� pw ũ��� 11
	int subject[100];     // ���� 100(�ִ�)���� ���� ����
	int sum; // �հ�
	float avg; // ���
	char *rating[100]; // ���� ���  [(�ִ�)100����] { ex) rating[0]�� �����, rating[1]�� ����� }
	int callnum; // �л� ���� ȣ��� �ش� �ε��� ���� ����ϱ� ���� ����
};

struct Pro
{
	char id[11];
	char password[11];
	int callnum; // ��й�ȣ ���� ȣ��� �ش� �ε��� ���� ����ϱ� ���� ����
};

struct Sub
{
	char subjectname[11];
};

#endif