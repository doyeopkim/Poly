#ifndef __DefineFunc_H__
#define __DefineFunc_H__

void AddProFunc(struct Grade* st, struct Pro* pro); // 교수 수 추가 함수
void DelProFunc(struct Pro* pro); // 교수 수 삭제 함수
void AddStFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // 학생 수 추가 함수
void DelStFunc(struct Grade* st, struct Sub* sub); // 학생 수 삭제 함수
void AddSubFunc(struct Grade* st, struct Sub* sub); // 과목 추가 함수
void DelSubFunc(struct Grade* st, struct Sub* sub); // 과목 삭제 함수

// 이상 AddDel.c

void ProOutputFunc(struct Grade* st, struct Sub* sub); // 성적조회 교수용 함수
void StOutputFunc(struct Grade* st, struct Sub* sub); // 성적조회 학생용 함수
void SearchProFunc(struct Pro* pro); // 교수 조회 함수
void SearchStFunc(struct Grade* st); // 학생 조회 함수
void AllInputFunc(struct Grade* st, struct Sub* sub); // 전체 성적 입력 함수
void ChoiceInputFunc(struct Grade* st, struct Sub* sub); // 선택 성적 입력 함수
void DelGradeFunc(struct Grade* st, struct Sub* sub); // 성적 삭제 함수

// 이상 InputOutput.c

void AdminMenuFunc(); // 관리자 메뉴 출력 함수
void ProMenuFunc(); // 교수 메누 출력 함수
void StMenuFunc(); // 학생 메뉴 출력 함수
void gotoxy(int x, int y); // gotoxy 함수

// 이상 Menu.c

void FileSaveFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // 파일 저장 함수
void LoginFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // 로그인 함수
void LogoutFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); //로그아웃 함수
void ChangePasswordFunc(struct Grade* st, struct Sub* sub, struct Pro* pro); // 비밀번호 변경 함수
void CalculateFunc(struct Grade* st, struct Sub* sub); // 점수, 학점을 저장하는 함수

// 이상 System.c

struct Grade
{
	char id[11]; // 학생 id 크기는 11
	char password[11]; // 학생 pw 크기는 11
	int subject[100];     // 과목 100(최대)개에 대한 점수
	int sum; // 합계
	float avg; // 평균
	char *rating[100]; // 학점 등급  [(최대)100과목] { ex) rating[0]는 국어성적, rating[1]은 영어성적 }
	int callnum; // 학생 성적 호출시 해당 인덱스 값을 기억하기 위한 변수
};

struct Pro
{
	char id[11];
	char password[11];
	int callnum; // 비밀번호 변경 호출시 해당 인덱스 값을 기억하기 위한 변수
};

struct Sub
{
	char subjectname[11];
};

#endif