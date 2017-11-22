#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

struct Item{	
	int value;
	Item *next;
};

Item *first = 0;

void pushBegin(int a);
void pushBack(int a);
int popBegin();
int popBack();
void printList();
void clear();

void push2(int a){
	if (first == 0) return;
	Item *p = new Item;
	Item *p1, *p2, *p3;
	p -> value = a;
	p1 = first;
	p2 = first -> next;
	p1 -> next = p;
	p -> next = p2;
	
}


void main(){
	for (int i = 0; i < 5; i++)
		pushBegin(i);
	printList();
	push2(22);
	printList();
	getch();
}

void pushBegin(int a){
	Item *p;
	p = new Item;
	p -> value = a;
	p -> next = first;
	first = p;
}

int popBegin(){
	if (first == 0)
		return 0;
	Item *p = first;
	first = p -> next;
	int a = p -> value;
	delete p;
	return a;
}

void printList(){
	if (first == 0){
		printf("List is empty\n");
		return;
	}
	Item *p = first;
	while (p != 0){
		printf("%d\t", p->value);
		p = p -> next;
	}
	printf("\n");
}

void clear(){
	while (first != 0)
		popBegin();
}

void pushBack(int a){
	if (first == 0){
		pushBegin(a);
		return;
	}
	Item *last = first;
	while (last -> next != 0)
		last = last -> next;
	Item *p = new Item;
	p -> value = a;
	p -> next = 0;
	last -> next = p;

}

int popBack(){
	if (first == 0)
		return 0;
	if (first -> next == 0)
		return popBegin();
	Item *p1, *p2;
	p1 = first;
	p2 = p1 -> next;
	while (p2 -> next != 0){
		p1 = p1 -> next;
		p2 = p2 -> next;
	}
	p1 -> next = 0;
	int a = p2 -> value;
	delete p2;
	return a;
}

//*******************************************************************************************
#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <time.h>

struct Item{
	int value;
	Item *next;
	Item *prev;
};

Item *first = 0;
Item *last = 0;

void pushBegin(int a);
void pushBack(int a);
int popBegin();
int popBack();
void printList();
void clear();


void main(){
	for (int i = 0; i < 5; i++)
		pushBegin(i);
	printList();
	popBack();
	printList();
	pushBack(111);
	printList();
	getch();
}

void pushBegin(int a){
	if (first == 0){
		first = new Item;
		first -> value = a;
		first -> next = 0;
		first -> prev = 0;
		last = first;
		return;
	}
	Item *p = new Item;
	p -> value = a;
	p -> next = first;
	p -> prev = 0;
	first -> prev = p;
	first = p;
}

int popBegin(){	
	if (first == 0) return 0;
	if (first -> next == 0){
		int a = first -> value;
		delete first;
		first = last = 0;
		return a;
	}
	Item *p = first;
	first = first -> next;
	first -> prev = 0;
	int a = p -> value;
	delete p;
	return a;
}

void printList(){
	if (first == 0){
		printf("List is empty\n");
		return;
	}
	Item *p = first;
	while (p != 0){
		printf("%d\t", p->value);
		p = p -> next;
	}
	printf("\n");
}

void clear(){
	while (first != 0)
		popBegin();
}

void pushBack(int a){
	if (first == 0){
		first = new Item;
		first -> value = a;
		first -> next = 0;
		first -> prev = 0;
		last = first;
		return;
	}
	Item *p = new Item;
	p -> value = a;
	p -> next = 0;
	p -> prev = last;
	last -> next = p;
	last = p;

}

int popBack(){
	if (first == 0) return 0;
	if (first -> next == 0){
		int a = first -> value;
		delete first;
		first = last = 0;
		return a;
	}
	Item *p = last;
	last = last -> prev;
	last -> next = 0;
	int a = p -> value;
	delete p;
	return a;
}


